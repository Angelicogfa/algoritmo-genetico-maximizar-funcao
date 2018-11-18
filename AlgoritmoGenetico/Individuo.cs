using System;
using System.Collections;
using System.Linq;
using System.Text;

namespace AlgoritmoGenetico
{
    public class Individuo
    {
        private BitArray cromossomo;

        public Individuo()
        {
            cromossomo = new BitArray(Constantes.TamanhoCromossomo);
            for (int i = 0; i < cromossomo.Length; i++)
                cromossomo[i] = Constantes.random.NextDouble() > 0.5f;
        }

        public bool this[int index]
        {
            get { return cromossomo[index]; }
            set { AlterarGene(index, value); }
        }

        public bool[] Genes => cromossomo.Cast<bool>().ToArray();
        public void AlterarGene(int index, bool gene) => cromossomo[index] = gene;

        public double Aptidao { get; private set; }
        public double PercentualAptidao { get; private set; }
        public double[] FaixaRoleta { get; private set; } = { 0, 0 };

        public void AlterarAptidao(double aptidao) => Aptidao = aptidao;
        public void AlterarPercentualAptidao(double percentual) => PercentualAptidao = percentual;

        public void MutarGene(int index)
        {
            if (index < cromossomo.Length)
                this[index] = !this[index];
        }

        public Individuo GerarFilho(Individuo outro, int pontoCorte, bool crossover = true)
        {
            Individuo filho = new Individuo();

            for (int i = 0; i < Genes.Length; i++)
                filho[i] = this[i];

            if (!crossover) return filho;

            for (int i = pontoCorte; i < Genes.Length; i++)
                filho[i] = outro[i];

            return filho;
        }

        public void AlterarRoleta(double inicio, double fim)
        {
            FaixaRoleta[0] = inicio;
            FaixaRoleta[1] = fim;
        }

        public int Valor
        {
            get
            {
                if (cromossomo.Length > 32)
                    throw new InvalidOperationException("O comprimento do do cromossomo não deve ultrapassar 32 bits");

                int[] valor = new int[1];
                cromossomo.CopyTo(valor, 0);
                return valor[0];
            }
        }

        public override string ToString()
        {
            StringBuilder texto = new StringBuilder();
            texto.Append("Genes:");
            foreach (var item in Genes.Reverse())
                texto.AppendFormat("{0}", item ? 1 : 0);
            texto.AppendFormat(" Valor:{0}", Valor);
            texto.AppendFormat(" Aptidão:{0}", Aptidao);
            texto.AppendFormat(" Percentual Aptidão:{0}", PercentualAptidao);

            return texto.ToString();
        }
    }
}
