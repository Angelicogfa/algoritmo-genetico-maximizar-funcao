using Xunit;

namespace AlgoritmoGenetico.Teste
{
    public class IndividuoTeste
    {
        [Fact]
        public void GerarIndividuo()
        {
            Individuo individuo = new Individuo();
            Assert.NotNull(individuo);
            Assert.NotEqual("", individuo.ToString());
        }

        [Fact]
        public void GerarFilho()
        {
            Individuo pai = new Individuo();
            var filho = pai.GerarFilho(null, 0, false);

            for (int i = 0; i < pai.Genes.Length; i++)
                Assert.Equal(pai.Genes[i], filho.Genes[i]);
        }

        [Fact]
        public void GerarFilhoCrossover()
        {
            int crossoverIndex = 5;
            Individuo pai = new Individuo();
            Individuo mae = new Individuo();
            var filhoPai = pai.GerarFilho(mae, crossoverIndex, true);
            var filhoMae = mae.GerarFilho(pai, crossoverIndex, true);

            Assert.NotEqual(pai.Genes, filhoPai.Genes);
            Assert.NotEqual(mae.Genes, filhoPai.Genes);
            Assert.NotEqual(pai.Genes, filhoMae.Genes);
            Assert.NotEqual(mae.Genes, filhoMae.Genes);

            for (int i = 0; i < filhoPai.Genes.Length; i++)
            {
                if(i < crossoverIndex)
                    Assert.Equal(pai.Genes[i], filhoPai.Genes[i]);
                else
                    Assert.Equal(mae.Genes[i], filhoPai.Genes[i]);
            }

            for (int i = 0; i < filhoMae.Genes.Length; i++)
            {
                if (i < crossoverIndex)
                    Assert.Equal(mae.Genes[i], filhoMae.Genes[i]);
                else
                    Assert.Equal(pai.Genes[i], filhoMae.Genes[i]);
            }
        }
    }
}
