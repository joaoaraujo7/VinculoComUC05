using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class CadastroForm : Form
    {
        public Pessoa Pessoa { get; private set; }

        /// <summary>
        /// Construtor para inserção dos dados
        /// </summary>
        public CadastroForm()
        {
            InitializeComponent();
            btnExcluir.Visible = false;
            btnExcluir.Width = 471;
            btnAtualizar.Text = "Inserir";
        }

        /// <summary>
        /// Construtor para editar ou excluir uma pessoa
        /// </summary>
        /// <param name="pessoa"></param>
        public CadastroForm(Pessoa pessoa)
        {
            InitializeComponent();
            Pessoa = pessoa;
            txtNome.Text = pessoa.Nome;
            txtEscolaridade.Text = pessoa.Escolaridade;
            rdoFeminino.Checked = pessoa.Sexo is 'F';
            rdoMasculino.Checked = pessoa.Sexo is 'M';
            cboClasse.SelectedItem = pessoa.Classe.Substring(0, 8);
        }


        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            string nome = txtNome.Text;
            char sexo = rdoFeminino.Checked ? 'F' : 'M';
            string escolaridade = txtEscolaridade.Text;
            string classe = cboClasse.SelectedItem as string;

            // Se a pessoa não existir, cria uma nova
            if (Pessoa == null) { 
                Pessoa = new Pessoa(nome, sexo, escolaridade, classe); 
            }
            else // caso contrário, atualiza
            {
                Pessoa.AtualizarCampos(nome, sexo, escolaridade, classe);
            }

            Close();
        }

        /// <summary>
        /// Informo que a pessoa será nula (vazio) para no outro código excluir da lista
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnExcluir_Click(object sender, EventArgs e)
        {
            Pessoa = null;
            Close();
        }
    }
}
