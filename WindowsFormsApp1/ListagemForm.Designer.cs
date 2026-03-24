namespace WindowsFormsApp1
{
    partial class ListagemForm
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
            this.lboDados = new System.Windows.Forms.ListBox();
            this.btnObterDados = new System.Windows.Forms.Button();
            this.btnInserir = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnSalvarComo = new System.Windows.Forms.Button();
            this.lblClasseA = new System.Windows.Forms.Label();
            this.lblClasseC = new System.Windows.Forms.Label();
            this.lblClasseB = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lboDados
            // 
            this.lboDados.FormattingEnabled = true;
            this.lboDados.Name = "lboDados";
            this.lboDados.TabIndex = 0;
            this.lboDados.SelectedIndexChanged += new System.EventHandler(this.lboDados_SelectedIndexChanged);
            // 
            // btnObterDados
            // 
            this.btnObterDados.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnObterDados.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnObterDados.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnObterDados.ForeColor = System.Drawing.Color.Transparent;
            this.btnObterDados.Name = "btnObterDados";
            this.btnObterDados.Size = new System.Drawing.Size(116, 23);
            this.btnObterDados.TabIndex = 1;
            this.btnObterDados.Text = "Extrair Dados";
            this.btnObterDados.UseVisualStyleBackColor = false;
            this.btnObterDados.Click += new System.EventHandler(this.button1_Click);
            // 
            // 
            // ListagemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblClasseB);
            this.Controls.Add(this.lblClasseC);
            this.Controls.Add(this.lblClasseA);
            this.Controls.Add(this.btnSalvarComo);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnInserir);
            this.Controls.Add(this.btnObterDados);
            this.Controls.Add(this.lboDados);
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lboDados;
        private System.Windows.Forms.Button btnObterDados;
        private System.Windows.Forms.Button btnInserir;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnSalvarComo;
        private System.Windows.Forms.Label lblClasseA;
        private System.Windows.Forms.Label lblClasseC;
        private System.Windows.Forms.Label lblClasseB;
    }
}

