namespace AlgoritmoGenetico
{
    public static class PopulacaoExtension
    {
        public static void OrdenarPopulacao(this Individuo[] individuos)
        {
            Individuo aux = null;
            for (int i = 0; i < individuos.Length; i++)
                for (int j = 0; j < individuos.Length; j++)
                {
                    if (individuos[i].PercentualAptidao < individuos[j].PercentualAptidao)
                    {
                        aux = individuos[i];
                        individuos[i] = individuos[j];
                        individuos[j] = aux;
                    }
                }
        }
    }
}
