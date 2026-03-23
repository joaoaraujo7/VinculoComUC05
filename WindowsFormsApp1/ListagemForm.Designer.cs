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
            this.lboDados.Location = new System.Drawing.Point(52, 29);
            this.lboDados.Name = "lboDados";
            this.lboDados.Size = new System.Drawing.Size(696, 238);
            this.lboDados.TabIndex = 0;
            this.lboDados.SelectedIndexChanged += new System.EventHandler(this.lboDados_SelectedIndexChanged);
            // 
            // btnObterDados
            // 
            this.btnObterDados.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnObterDados.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnObterDados.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnObterDados.ForeColor = System.Drawing.Color.Transparent;
            this.btnObterDados.Location = new System.Drawing.Point(632, 394);
            this.btnObterDados.Name = "btnObterDados";
            this.btnObterDados.Size = new System.Drawing.Size(116, 23);
            this.btnObterDados.TabIndex = 1;
            this.btnObterDados.Text = "Extrair Dados";
            this.btnObterDados.UseVisualStyleBackColor = false;
            this.btnObterDados.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnInserir
            // 
            this.btnInserir.BackColor = System.Drawing.Color.Gold;
            this.btnInserir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnInserir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInserir.ForeColor = System.Drawing.Color.Black;
            this.btnInserir.Location = new System.Drawing.Point(296, 394);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(116, 23);
            this.btnInserir.TabIndex = 2;
            this.btnInserir.Text = "Inserir";
            this.btnInserir.UseVisualStyleBackColor = false;
            this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.Color.OliveDrab;
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.ForeColor = System.Drawing.Color.Transparent;
            this.btnSalvar.Location = new System.Drawing.Point(52, 394);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(116, 23);
            this.btnSalvar.TabIndex = 3;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnSalvarComo
            // 
            this.btnSalvarComo.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnSalvarComo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSalvarComo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvarComo.ForeColor = System.Drawing.Color.Transparent;
            this.btnSalvarComo.Location = new System.Drawing.Point(174, 394);
            this.btnSalvarComo.Name = "btnSalvarComo";
            this.btnSalvarComo.Size = new System.Drawing.Size(116, 23);
            this.btnSalvarComo.TabIndex = 4;
            this.btnSalvarComo.Text = "Salvar Como";
            this.btnSalvarComo.UseVisualStyleBackColor = false;
            this.btnSalvarComo.Click += new System.EventHandler(this.btnSalvarComo_Click);
            // 
            // lblClasseA
            // 
            this.lblClasseA.AutoSize = true;
            this.lblClasseA.Location = new System.Drawing.Point(49, 299);
            this.lblClasseA.Name = "lblClasseA";
            this.lblClasseA.Size = new System.Drawing.Size(55, 13);
            this.lblClasseA.TabIndex = 5;
            this.lblClasseA.Text = "lblClasseA";
            // 
            // lblClasseC
            // 
            this.lblClasseC.AutoSize = true;
            this.lblClasseC.Location = new System.Drawing.Point(49, 369);
            this.lblClasseC.Name = "lblClasseC";
            this.lblClasseC.Size = new System.Drawing.Size(55, 13);
            this.lblClasseC.TabIndex = 6;
            this.lblClasseC.Text = "lblClasseC";
            // 
            // lblClasseB
            // 
            this.lblClasseB.AutoSize = true;
            this.lblClasseB.Location = new System.Drawing.Point(49, 331);
            this.lblClasseB.Name = "lblClasseB";
            this.lblClasseB.Size = new System.Drawing.Size(55, 13);
            this.lblClasseB.TabIndex = 7;
            this.lblClasseB.Text = "lblClasseB";
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
            this.Name = "ListagemForm";
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

