using Xunit;

namespace AlgoritmoGenetico.Teste
{
    public class AlgoritmoGenTeste
    {
        [Fact]
        public void GerarPopulacao()
        {
            AlgoritmoGen algoritmoGen = new AlgoritmoGen(0.8, 0.01);
            Populacao populacao = new Populacao();

            Populacao novaPopulacao = algoritmoGen.ExecutaAG(populacao);
            Assert.NotEqual(populacao, novaPopulacao);
            Assert.NotEqual(populacao.ToString(), novaPopulacao.ToString());
        }
    }
}
