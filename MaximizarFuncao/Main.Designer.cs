namespace MaximizarFuncao
{
    partial class Main
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.grafPopulacao = new ZedGraph.ZedGraphControl();
            this.grafMediaPopulacao = new ZedGraph.ZedGraphControl();
            this.txtMelhoresIndividuos = new System.Windows.Forms.RichTextBox();
            this.txtPioresIndividuos = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCrossover = new System.Windows.Forms.NumericUpDown();
            this.txtMutacao = new System.Windows.Forms.NumericUpDown();
            this.txtIteracao = new System.Windows.Forms.NumericUpDown();
            this.btnPopulacao = new System.Windows.Forms.Button();
            this.btnExecucao = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.txtCrossover)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMutacao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIteracao)).BeginInit();
            this.SuspendLayout();
            // 
            // grafPopulacao
            // 
            this.grafPopulacao.Location = new System.Drawing.Point(12, 79);
            this.grafPopulacao.Name = "grafPopulacao";
            this.grafPopulacao.ScrollGrace = 0D;
            this.grafPopulacao.ScrollMaxX = 0D;
            this.grafPopulacao.ScrollMaxY = 0D;
            this.grafPopulacao.ScrollMaxY2 = 0D;
            this.grafPopulacao.ScrollMinX = 0D;
            this.grafPopulacao.ScrollMinY = 0D;
            this.grafPopulacao.ScrollMinY2 = 0D;
            this.grafPopulacao.Size = new System.Drawing.Size(631, 417);
            this.grafPopulacao.TabIndex = 0;
            // 
            // grafMediaPopulacao
            // 
            this.grafMediaPopulacao.Location = new System.Drawing.Point(659, 79);
            this.grafMediaPopulacao.Name = "grafMediaPopulacao";
            this.grafMediaPopulacao.ScrollGrace = 0D;
            this.grafMediaPopulacao.ScrollMaxX = 0D;
            this.grafMediaPopulacao.ScrollMaxY = 0D;
            this.grafMediaPopulacao.ScrollMaxY2 = 0D;
            this.grafMediaPopulacao.ScrollMinX = 0D;
            this.grafMediaPopulacao.ScrollMinY = 0D;
            this.grafMediaPopulacao.ScrollMinY2 = 0D;
            this.grafMediaPopulacao.Size = new System.Drawing.Size(631, 417);
            this.grafMediaPopulacao.TabIndex = 1;
            // 
            // txtMelhoresIndividuos
            // 
            this.txtMelhoresIndividuos.Location = new System.Drawing.Point(12, 518);
            this.txtMelhoresIndividuos.Name = "txtMelhoresIndividuos";
            this.txtMelhoresIndividuos.Size = new System.Drawing.Size(631, 137);
            this.txtMelhoresIndividuos.TabIndex = 2;
            this.txtMelhoresIndividuos.Text = "";
            // 
            // txtPioresIndividuos
            // 
            this.txtPioresIndividuos.Location = new System.Drawing.Point(659, 518);
            this.txtPioresIndividuos.Name = "txtPioresIndividuos";
            this.txtPioresIndividuos.Size = new System.Drawing.Size(631, 137);
            this.txtPioresIndividuos.TabIndex = 3;
            this.txtPioresIndividuos.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 502);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Melhores Indivíduos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(659, 503);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Piores Indivíduos";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Taxa de Crossover";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Taxa de Mutação";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(247, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Evoluções";
            // 
            // txtCrossover
            // 
            this.txtCrossover.DecimalPlaces = 2;
            this.txtCrossover.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.txtCrossover.Location = new System.Drawing.Point(114, 5);
            this.txtCrossover.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtCrossover.Name = "txtCrossover";
            this.txtCrossover.Size = new System.Drawing.Size(120, 20);
            this.txtCrossover.TabIndex = 9;
            this.txtCrossover.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtCrossover.Value = new decimal(new int[] {
            8,
            0,
            0,
            65536});
            // 
            // txtMutacao
            // 
            this.txtMutacao.DecimalPlaces = 2;
            this.txtMutacao.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.txtMutacao.Location = new System.Drawing.Point(114, 31);
            this.txtMutacao.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtMutacao.Name = "txtMutacao";
            this.txtMutacao.Size = new System.Drawing.Size(120, 20);
            this.txtMutacao.TabIndex = 10;
            this.txtMutacao.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtMutacao.Value = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            // 
            // txtIteracao
            // 
            this.txtIteracao.Location = new System.Drawing.Point(310, 5);
            this.txtIteracao.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.txtIteracao.Name = "txtIteracao";
            this.txtIteracao.Size = new System.Drawing.Size(120, 20);
            this.txtIteracao.TabIndex = 11;
            this.txtIteracao.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtIteracao.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // btnPopulacao
            // 
            this.btnPopulacao.Location = new System.Drawing.Point(250, 30);
            this.btnPopulacao.Name = "btnPopulacao";
            this.btnPopulacao.Size = new System.Drawing.Size(105, 23);
            this.btnPopulacao.TabIndex = 12;
            this.btnPopulacao.Text = "Criar População";
            this.btnPopulacao.UseVisualStyleBackColor = true;
            this.btnPopulacao.Click += new System.EventHandler(this.btnPopulacao_Click);
            // 
            // btnExecucao
            // 
            this.btnExecucao.Enabled = false;
            this.btnExecucao.Location = new System.Drawing.Point(361, 30);
            this.btnExecucao.Name = "btnExecucao";
            this.btnExecucao.Size = new System.Drawing.Size(105, 23);
            this.btnExecucao.TabIndex = 13;
            this.btnExecucao.Text = "Executar";
            this.btnExecucao.UseVisualStyleBackColor = true;
            this.btnExecucao.Click += new System.EventHandler(this.btnExecucao_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1300, 669);
            this.Controls.Add(this.btnExecucao);
            this.Controls.Add(this.btnPopulacao);
            this.Controls.Add(this.txtIteracao);
            this.Controls.Add(this.txtMutacao);
            this.Controls.Add(this.txtCrossover);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPioresIndividuos);
            this.Controls.Add(this.txtMelhoresIndividuos);
            this.Controls.Add(this.grafMediaPopulacao);
            this.Controls.Add(this.grafPopulacao);
            this.MaximumSize = new System.Drawing.Size(1316, 708);
            this.MinimumSize = new System.Drawing.Size(1316, 708);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Algoritmo Genetico";
            ((System.ComponentModel.ISupportInitialize)(this.txtCrossover)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMutacao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIteracao)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ZedGraph.ZedGraphControl grafPopulacao;
        private ZedGraph.ZedGraphControl grafMediaPopulacao;
        private System.Windows.Forms.RichTextBox txtMelhoresIndividuos;
        private System.Windows.Forms.RichTextBox txtPioresIndividuos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown txtCrossover;
        private System.Windows.Forms.NumericUpDown txtMutacao;
        private System.Windows.Forms.NumericUpDown txtIteracao;
        private System.Windows.Forms.Button btnPopulacao;
        private System.Windows.Forms.Button btnExecucao;
    }
}

