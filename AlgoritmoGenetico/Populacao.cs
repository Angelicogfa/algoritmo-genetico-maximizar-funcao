using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AlgoritmoGenetico
{
    public class Populacao
    {
        public Populacao()
        {
            Individuos = new Individuo[Constantes.TamanhoPopulacao];
            for (int i = 0; i < Individuos.Length; i++)
                Individuos[i] = new Individuo();

            AtualizarPopulacao();
        }

        internal Populacao(IEnumerable<Individuo> novosIndividuos)
        {
            Individuos = novosIndividuos.ToArray();
            AtualizarPopulacao();
        }

        public Individuo[] Individuos { get; private set; }

        public Individuo this[int index]
        {
            get { return Individuos[index]; }
            set { Individuos[index] = value; }
        }

        public double Media
        {
            get
            {
                double media = 0;
                foreach (var individuo in Individuos)
                {
                    media += individuo.Aptidao;
                }
                return media / Individuos.Length;
            }
        }

        private void CalcularApitidao()
        {
            foreach (var individuo in Individuos)
                individuo.AlterarAptidao(Constantes.FuncaoAptidao(individuo.Valor));
        }

        private void CalcularPercentualApitidao()
        {
            double total = 0;
            foreach (var individuo in Individuos)
                total += individuo.Aptidao;

            foreach (var individuo in Individuos)
                individuo.AlterarPercentualAptidao(individuo.Aptidao * 100 / total);
        }

        private void CalularRangeRoleta()
        {
            OrdenarPopulacao();
            double somatoria = 0;

            for (int i = 0; i < Individuos.Length; i++)
            {
                if(i == 0)
                {
                    somatoria += Individuos[i].PercentualAptidao;
                    Individuos[i].AlterarRoleta(0, somatoria);
                }
                else if(i == Individuos.Length - 1)
                    Individuos[i].AlterarRoleta(somatoria, 100);
                else
                    Individuos[i].AlterarRoleta(somatoria, somatoria += Individuos[i].PercentualAptidao);
            }
        }

        public void OrdenarPopulacao() => Individuos.OrdenarPopulacao();


        public void AtualizarPopulacao()
        {
            CalcularApitidao();
            CalcularPercentualApitidao();
            CalularRangeRoleta();
        }

        public override string ToString()
        {
            StringBuilder texto = new StringBuilder();
            foreach (var individuo in Individuos)
            {
                texto.AppendFormat("{0}     |     {1}     \n",
                                    individuo.ToString(),
                                    individuo.FaixaRoleta[0].ToString() + ':' + individuo.FaixaRoleta[1].ToString());
            }
            return texto.ToString();
        }
    }
}
