namespace WindowsFormsApp1.Views
{
    partial class ControladorDeJanelas
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
            this.botaoCarregarJanelas = new System.Windows.Forms.Button();
            this.botaoSair = new System.Windows.Forms.Button();
            this.limparJanelas = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.quantidadeDeJanelas = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // botaoCarregarJanelas
            // 
            this.botaoCarregarJanelas.Location = new System.Drawing.Point(12, 12);
            this.botaoCarregarJanelas.Name = "botaoCarregarJanelas";
            this.botaoCarregarJanelas.Size = new System.Drawing.Size(75, 23);
            this.botaoCarregarJanelas.TabIndex = 0;
            this.botaoCarregarJanelas.Text = "Carregar";
            this.botaoCarregarJanelas.UseVisualStyleBackColor = true;
            this.botaoCarregarJanelas.Click += new System.EventHandler(this.botaoCarregarJanelas_Click);
            // 
            // botaoSair
            // 
            this.botaoSair.Location = new System.Drawing.Point(12, 41);
            this.botaoSair.Name = "botaoSair";
            this.botaoSair.Size = new System.Drawing.Size(75, 23);
            this.botaoSair.TabIndex = 1;
            this.botaoSair.Text = "Sair";
            this.botaoSair.UseVisualStyleBackColor = true;
            this.botaoSair.Click += new System.EventHandler(this.botaoSair_Click);
            // 
            // limparJanelas
            // 
            this.limparJanelas.AutoSize = true;
            this.limparJanelas.Location = new System.Drawing.Point(93, 12);
            this.limparJanelas.Name = "limparJanelas";
            this.limparJanelas.Size = new System.Drawing.Size(102, 17);
            this.limparJanelas.TabIndex = 2;
            this.limparJanelas.Text = "Limpar Janelas?";
            this.limparJanelas.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(93, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Janelas:";
            // 
            // quantidadeDeJanelas
            // 
            this.quantidadeDeJanelas.AutoSize = true;
            this.quantidadeDeJanelas.Location = new System.Drawing.Point(145, 46);
            this.quantidadeDeJanelas.Name = "quantidadeDeJanelas";
            this.quantidadeDeJanelas.Size = new System.Drawing.Size(13, 13);
            this.quantidadeDeJanelas.TabIndex = 4;
            this.quantidadeDeJanelas.Text = "0";
            // 
            // ControladorDeJanelas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(347, 264);
            this.Controls.Add(this.quantidadeDeJanelas);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.limparJanelas);
            this.Controls.Add(this.botaoSair);
            this.Controls.Add(this.botaoCarregarJanelas);
            this.Name = "ControladorDeJanelas";
            this.Text = "Janela Principal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button botaoCarregarJanelas;
        private System.Windows.Forms.Button botaoSair;
        private System.Windows.Forms.CheckBox limparJanelas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label quantidadeDeJanelas;
    }
}

