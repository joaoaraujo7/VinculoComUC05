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
        private Pessoa _pessoa;

        public CadastroForm(Pessoa pessoa)
        {
            InitializeComponent();
            _pessoa = pessoa;
            txtNome.Text = pessoa.Nome;
            txtEscolaridade.Text = pessoa.Escolaridade;
            rdoFeminino.Checked = pessoa.Sexo is 'F';
            rdoMasculino.Checked = pessoa.Sexo is 'M';
            cboClasse.SelectedItem = pessoa.Classe.Substring(0, 8);
        }

        public Pessoa GetPessoa() {return _pessoa;}

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            string nome = txtNome.Text;
            char sexo = rdoFeminino.Checked ? 'F' : 'M';
            string escolaridade = txtEscolaridade.Text;
            string classe = cboClasse.SelectedItem as string;
            _pessoa.AtualizarCampos(nome, sexo, escolaridade, classe);
            Close();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {

        }
    }
}
