using System.Collections.Generic;

namespace AlgoritmoGenetico
{
    public class AlgoritmoGen
    {
        private readonly double taxaCrossover;
        private readonly double taxaMutacao;

        public AlgoritmoGen(double taxaCrossover, double taxaMutacao)
        {
            this.taxaCrossover = taxaCrossover;
            this.taxaMutacao = taxaMutacao;
        }

        /// <summary>
        /// Inicia o AG
        /// Avaliação da população
        /// Selecionar pais
        /// realizar cruzamento
        /// aplicar mutacao
        /// apagar velhos membros
        /// inserir novos
        /// re-avaliar a população
        /// </summary>
        /// <param name="populacao"></param>
        /// <returns></returns>
        public Populacao ExecutaAG(Populacao populacao)
        {
            List<Individuo> buffer = new List<Individuo>();

            for (int i = 0; i < Constantes.TamanhoPopulacao / 2; i++)
            {
                Individuo pai = GirarRoleta(populacao);
                Individuo mae = GirarRoleta(populacao);

                Individuo[] filhos = Crossover(pai, mae);
                filhos[0] = Mutacao(filhos[0]);
                filhos[1] = Mutacao(filhos[1]);

                buffer.AddRange(filhos);
            }

            Populacao novaPopulacao = new Populacao(buffer);

            return novaPopulacao;
        }

        private Individuo[] Crossover(Individuo pai, Individuo mae)
        {
            Individuo[] filhos = new Individuo[2];
            int pontoCorte = Constantes.random.Next(0, Constantes.TamanhoCromossomo - 1);

            bool crossover = Constantes.random.NextDouble() < taxaCrossover;

            filhos[0] = pai.GerarFilho(mae, pontoCorte, crossover);
            filhos[1] = mae.GerarFilho(pai, pontoCorte, crossover);

            return filhos;
        }

        private Individuo Mutacao(Individuo individuo)
        {
            bool mutacao = Constantes.random.NextDouble() < taxaMutacao;
            if (!mutacao) return individuo;

            int pontoMutacao = Constantes.random.Next(0, Constantes.TamanhoCromossomo - 1);
            individuo.MutarGene(pontoMutacao);
            return individuo;
        }

        private Individuo GirarRoleta(Populacao populacao)
        {
            double numeroSorteado = Constantes.random.NextDouble() * 100;
            foreach (var individuo in populacao.Individuos)
            {
                if (numeroSorteado >= individuo.FaixaRoleta[0] && 
                    numeroSorteado <= individuo.FaixaRoleta[1])
                    return individuo;
            }
            return null;
        }
    }
}
