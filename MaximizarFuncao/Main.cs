using AlgoritmoGenetico;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ZedGraph;

namespace MaximizarFuncao
{
    public partial class Main : Form
    {
        private Populacao populacao;
        private AlgoritmoGen algoritmoGen;

        private GraphPane panePopulacao;
        private GraphPane paneMediaPopulacao;

        private PointPairList curvaGrafico = new PointPairList();
        private PointPairList populacaoGrafico = new PointPairList();
        private PointPairList mediaPopulacao = new PointPairList();

        public Main()
        {
            InitializeComponent();

            panePopulacao = grafPopulacao.GraphPane;
            panePopulacao.Title.Text = "População";
            panePopulacao.XAxis.Title.Text = "Gerações";
            panePopulacao.YAxis.Title.Text = "Indivíduos";
            grafPopulacao.Refresh();

            paneMediaPopulacao = grafMediaPopulacao.GraphPane;
            paneMediaPopulacao.Title.Text = "Média da população";
            paneMediaPopulacao.XAxis.Title.Text = "Gerações";
            paneMediaPopulacao.YAxis.Title.Text = "Média";
            grafMediaPopulacao.Refresh();

            for (int i = 0; i < Constantes.TamanhoEixoX; i++)
                curvaGrafico.Add(i, Constantes.FuncaoAptidao(i));

            LineItem func = panePopulacao.AddCurve("Função", curvaGrafico, System.Drawing.Color.Red, SymbolType.None);
            AtualizarGraficoPopulacao();
            AtualizarGraficoMediaPopulacao();
        }

        private void AtualizarGraficoMediaPopulacao()
        {
            grafMediaPopulacao.AxisChange();
            grafMediaPopulacao.Invalidate();
            grafMediaPopulacao.Refresh();
        }

        private void AtualizarGraficoPopulacao()
        {
            grafPopulacao.AxisChange();
            grafPopulacao.Invalidate();
            grafPopulacao.Refresh();
        }

        private void btnPopulacao_Click(object sender, System.EventArgs e)
        {
            btnExecucao.Enabled = true;
            populacao = new Populacao();
            populacaoGrafico = new PointPairList();

            for (int i = 0; i < Constantes.TamanhoPopulacao; i++)
            {
                populacaoGrafico.Add(populacao[i].Valor, populacao[i].Aptidao);
            }

            LineItem lineItem = panePopulacao.AddStick("Indivíduos", populacaoGrafico, Color.Blue);
            AtualizarGraficoPopulacao();
        }

        private void btnExecucao_Click(object sender, System.EventArgs e)
        {
            btnExecucao.Enabled = btnPopulacao.Enabled = false;
            algoritmoGen = new AlgoritmoGen((double)txtCrossover.Value, (double)txtMutacao.Value);
            for (int i = 0; i < txtIteracao.Value; i++)
            {
                populacao = algoritmoGen.ExecutaAG(populacao);
                mediaPopulacao.Add(i, populacao.Media);

                grafPopulacao.GraphPane.CurveList.Clear();
                grafPopulacao.GraphPane.GraphObjList.Clear();
                grafMediaPopulacao.GraphPane.CurveList.Clear();
                grafMediaPopulacao.GraphPane.GraphObjList.Clear();

                populacaoGrafico = new PointPairList();
                for (int j = 0; j < Constantes.TamanhoPopulacao; j++)
                    populacaoGrafico.Add(populacao[j].Valor, populacao[j].Aptidao);

                LineItem media = paneMediaPopulacao.AddCurve("Média", mediaPopulacao, Color.Red, SymbolType.None);
                LineItem func = panePopulacao.AddCurve("Função", curvaGrafico, Color.Red, SymbolType.None);
                LineItem individuos = panePopulacao.AddStick("Indivíduos", populacaoGrafico, Color.Blue);

                AtualizarGraficoPopulacao();
                AtualizarGraficoMediaPopulacao();
            }

            populacao.OrdenarPopulacao();

            StringBuilder pioresIndividuos = new StringBuilder();
            for (int i = 0; i < 10; i++)
                pioresIndividuos.AppendLine(populacao[i].ToString());

            StringBuilder melhoresIndividuos = new StringBuilder();
            for (int i =Constantes.TamanhoPopulacao -1; i > (Constantes.TamanhoPopulacao - 1) - 10; i--)
                melhoresIndividuos.AppendLine(populacao[i].ToString());

            txtMelhoresIndividuos.Text = melhoresIndividuos.ToString();
            txtPioresIndividuos.Text = pioresIndividuos.ToString();

            btnExecucao.Enabled = btnPopulacao.Enabled = true;
        }
    }
}
