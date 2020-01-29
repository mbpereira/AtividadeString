namespace WindowsFormsApp1.Views
{
    partial class FerramentaDeTexto
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.texto = new System.Windows.Forms.TextBox();
            this.labelInformativo = new System.Windows.Forms.Label();
            this.botalLadoALado = new System.Windows.Forms.Button();
            this.botaoCascata = new System.Windows.Forms.Button();
            this.botaoFechar = new System.Windows.Forms.Button();
            this.botaoSair = new System.Windows.Forms.Button();
            this.textoSincronizado = new System.Windows.Forms.Label();
            this.ferramenta = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // texto
            // 
            this.texto.Location = new System.Drawing.Point(13, 33);
            this.texto.Name = "texto";
            this.texto.Size = new System.Drawing.Size(322, 20);
            this.texto.TabIndex = 2;
            this.texto.TextChanged += new System.EventHandler(this.texto_TextChanged);
            // 
            // labelInformativo
            // 
            this.labelInformativo.AutoSize = true;
            this.labelInformativo.Location = new System.Drawing.Point(12, 9);
            this.labelInformativo.Name = "labelInformativo";
            this.labelInformativo.Size = new System.Drawing.Size(80, 13);
            this.labelInformativo.TabIndex = 3;
            this.labelInformativo.Text = "Digite um texto:";
            // 
            // botalLadoALado
            // 
            this.botalLadoALado.Location = new System.Drawing.Point(12, 59);
            this.botalLadoALado.Name = "botalLadoALado";
            this.botalLadoALado.Size = new System.Drawing.Size(80, 23);
            this.botalLadoALado.TabIndex = 4;
            this.botalLadoALado.Text = "Lado a Lado";
            this.botalLadoALado.UseVisualStyleBackColor = true;
            this.botalLadoALado.Click += new System.EventHandler(this.botalLadoALado_Click);
            // 
            // botaoCascata
            // 
            this.botaoCascata.Location = new System.Drawing.Point(13, 88);
            this.botaoCascata.Name = "botaoCascata";
            this.botaoCascata.Size = new System.Drawing.Size(79, 23);
            this.botaoCascata.TabIndex = 5;
            this.botaoCascata.Text = "Cascata";
            this.botaoCascata.UseVisualStyleBackColor = true;
            this.botaoCascata.Click += new System.EventHandler(this.botaoCascata_Click);
            // 
            // botaoFechar
            // 
            this.botaoFechar.Location = new System.Drawing.Point(12, 117);
            this.botaoFechar.Name = "botaoFechar";
            this.botaoFechar.Size = new System.Drawing.Size(80, 23);
            this.botaoFechar.TabIndex = 6;
            this.botaoFechar.Text = "Fechar";
            this.botaoFechar.UseVisualStyleBackColor = true;
            // 
            // botaoSair
            // 
            this.botaoSair.Location = new System.Drawing.Point(225, 117);
            this.botaoSair.Name = "botaoSair";
            this.botaoSair.Size = new System.Drawing.Size(110, 23);
            this.botaoSair.TabIndex = 7;
            this.botaoSair.Text = "Sair";
            this.botaoSair.UseVisualStyleBackColor = true;
            // 
            // textoSincronizado
            // 
            this.textoSincronizado.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textoSincronizado.AutoSize = true;
            this.textoSincronizado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textoSincronizado.Location = new System.Drawing.Point(111, 183);
            this.textoSincronizado.Name = "textoSincronizado";
            this.textoSincronizado.Size = new System.Drawing.Size(16, 17);
            this.textoSincronizado.TabIndex = 1;
            this.textoSincronizado.Text = "?";
            this.textoSincronizado.TextChanged += new System.EventHandler(this.texto_TextChanged);
            // 
            // ferramenta
            // 
            this.ferramenta.AutoSize = true;
            this.ferramenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ferramenta.Location = new System.Drawing.Point(0, 214);
            this.ferramenta.Name = "ferramenta";
            this.ferramenta.Size = new System.Drawing.Size(206, 24);
            this.ferramenta.TabIndex = 0;
            this.ferramenta.Text = "Ferramenta de Texto";
            this.ferramenta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FerramentaDeTexto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(347, 264);
            this.Controls.Add(this.botaoSair);
            this.Controls.Add(this.botaoFechar);
            this.Controls.Add(this.botaoCascata);
            this.Controls.Add(this.botalLadoALado);
            this.Controls.Add(this.labelInformativo);
            this.Controls.Add(this.texto);
            this.Controls.Add(this.textoSincronizado);
            this.Controls.Add(this.ferramenta);
            this.Name = "FerramentaDeTexto";
            this.Text = "FerramentaDeTexto";
            this.ResumeLayout(false);
            this.PerformLayout();

        }



        #endregion
        private System.Windows.Forms.TextBox texto;
        private System.Windows.Forms.Label labelInformativo;
        private System.Windows.Forms.Button botalLadoALado;
        private System.Windows.Forms.Button botaoCascata;
        private System.Windows.Forms.Button botaoFechar;
        private System.Windows.Forms.Button botaoSair;
        private System.Windows.Forms.Label textoSincronizado;
        private System.Windows.Forms.Label ferramenta;


    }
}