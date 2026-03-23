using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class ListagemForm : Form
    {
        private OpenFileDialog leitura = new OpenFileDialog();
        private SaveFileDialog salvamento = new SaveFileDialog();
        private string caminho;
        protected Pessoa pessoa = null;

        public ListagemForm()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Ao clicar, o código irá visualizar os dados
        /// </summary>
        /// <param name="sender">Botão de BtnObterDados</param>
        /// <param name="e">O evento de Click</param>

        private void button1_Click(object sender, EventArgs e)
        {
            /* Filtrar o nome do arquivo
             nomenclatura: nome-do-arquivo que aparece para o usuário | * .nome da extensão
             | (pipeline): Serve para separar o conteúdo entre 
             * : Serve para dizer que ele aceita qualquer coisa 
             */
            leitura.Filter = "Arquivo TXT|*.txt";
            // Voltar nessa linha - 1
            leitura.Title = "Selecione o arquivo que contém os dados";

            // Verificar se deu tudo certo após clicar em OK, após selecionar o dado
            // Se ao obter o caminho deu certo, continua, caso contrário encerra
            if (leitura.ShowDialog() != DialogResult.OK)
            {
                return;
            }

            // Obtendo o caminho do arquivo
            caminho = leitura.FileName;

            // Tenta executar o trecho do código
            LerArquivo(caminho);
        }

        public void LerArquivo(string caminho)
        {
            try
            {
                // Importar a biblioteca: System.IO (manipulação de arquivos)
                // O método: File.ReadAllText - Irá ler os dados dentro do arquivo
                var textoLido = File.ReadAllText(caminho);

                // Extrair Texto e coloca dentro do vetor linhas
                string[] linhas = textoLido.Split('\n');

                for (int i = 0; i < linhas.Length; i += 4)
                {
                    if (i + 3 > linhas.Length)
                    {
                        break;
                    }

                    string nome = linhas[i];
                    char sexo = linhas[i + 1].ToString()[0];
                    string escolaridade = linhas[i + 2];
                    string classe = linhas[i + 3];

                    Pessoa pessoa = new Pessoa(nome, sexo, escolaridade, classe);
                    lboDados.Items.Add(pessoa);
                }
            } // Caso acontença qualquer erro na linha no try, ele irá cair nesse bloco 
            catch (Exception erro)
            {
                // Mostra o erro
                MessageBox.Show(erro.Message);
            }
        }



        private void lboDados_SelectedIndexChanged(object sender, EventArgs e)
        {

            Pessoa pessoaExistente = (sender as ListBox).SelectedItem as Pessoa;

            if (pessoaExistente == null)
            {
                return;
            }

            Pessoa novaPessoa;
            using (CadastroForm cadastroForm = new CadastroForm(pessoaExistente))
            {
                cadastroForm.ShowDialog();
                novaPessoa = cadastroForm.GetPessoa();
            }

            lboDados.ClearSelected();

            for (int i = 0; i < lboDados.Items.Count; i++)
            {
                if (lboDados.Items[i] == pessoaExistente)
                {
                    lboDados.Items[i] = novaPessoa;
                    break;
                }
            }
            lboDados.Update();
        }
    }
}
