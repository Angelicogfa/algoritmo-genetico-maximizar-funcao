using System;

namespace AlgoritmoGenetico
{
    public static class Constantes
    {
        public static int TamanhoCromossomo => 9;
        public static int TamanhoPopulacao => 500;
        public static int TamanhoEixoX { get { return (int)Math.Pow(2, TamanhoCromossomo); } }
        public static Random random = new Random((int)DateTime.Now.Ticks);

        public static double FuncaoAptidao(double valor)
        {
            return (100 + Math.Abs(valor * Math.Sin(Math.Sqrt(Math.Abs(valor)))));
        }
    }
}
