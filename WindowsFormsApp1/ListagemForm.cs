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
            btnSalvar.Enabled = false;
            btnSalvarComo.Enabled = false;
            btnInserir.Enabled = false;
        }
        /// <summary>
        /// Ao clicar, o código irá visualizar os dados
        /// </summary>
        /// <param name="sender">Botão de BtnObterDados</param>
        /// <param name="e">O evento de Click</param>

        private void button1_Click(object sender, EventArgs e)
        {

            // Libera os botões após a extração do arquivo
            if (caminho != null) {
                btnSalvar.Enabled = true;
                btnSalvarComo.Enabled = true;
                btnInserir.Enabled = true;
            }

            // Limpar nossa lista
            lboDados.Items.Clear();

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


        /// <summary>
        /// Função que ao selecionar uma pessoa na lista, posso atualizar ou excluir sua informação
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lboDados_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Vou obter os dados da pessoa antes de atualizar
            Pessoa pessoaExistente = (sender as ListBox).SelectedItem as Pessoa;

            // Valida se o dado selecionado existe
            if (pessoaExistente == null)
            {
                return;
            }

            // Cria uma nova entidade de pessoa para obter a atualização dos dados
            Pessoa novaPessoa;
            using (CadastroForm cadastroForm = new CadastroForm(pessoaExistente)) // Abra o formulário de cadastro da entidade selecionada
            {
                cadastroForm.ShowDialog();
                novaPessoa = cadastroForm.Pessoa;
            }
            // Retiro a seleção no ListBox da pessoa que vai ser atualizada
            lboDados.ClearSelected();

            if (novaPessoa == null)
            {
                lboDados.Items.Remove(pessoaExistente);
            }
            else
            {
                // Procuro a pessoa que será atualizada
                for (int i = 0; i < lboDados.Items.Count; i++)
                {
                    // Se encontrar mude
                    if (lboDados.Items[i] == pessoaExistente)
                    {
                        lboDados.Items[i] = novaPessoa; // atribui a nova pessoa ao listbox
                        break;
                    }
                }
            }
            // Atualiza o nosso listBOx com as novas informações
            lboDados.Update();
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            // Cria uma nova pessoa
            Pessoa novaPessoa;

            // Aguarda uma resposta de Cadstro 
            using (CadastroForm cadastro = new CadastroForm())
            {
                cadastro.ShowDialog();
                novaPessoa = cadastro.Pessoa;
            }

            // Caso nova pessoa seja vazia, não adiciona na lista
            if (novaPessoa == null) { return; }

            // Adiciona a nova pessoa no final da lista
            lboDados.Items.Add(novaPessoa);
            lboDados.Update();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            // se não tiver base de dados, impede o salvamento
            if (caminho == null) { return; }

            // Faz a abertura do arquivo txt
            StreamWriter streamWriter = new StreamWriter(caminho);

            // Cria o texto para o salvamento
            string texto = "";

            // Adiciona os dados dentro do arquivo
            foreach (Pessoa pessoa in lboDados.Items)
            {
                texto += pessoa.Nome + "\n";
                texto += pessoa.Sexo == 'F' ? "Feminino\n" : "Masculino\n";
                texto += pessoa.Escolaridade + "\n";
                texto += pessoa.Classe + "\n";
            }
            // Salva os dados dentro do arquivo
            streamWriter.WriteLine(texto);

            // Fecha o arquivo
            streamWriter.Close();
        }

        private void btnSalvarComo_Click(object sender, EventArgs e)
        {
            if (lboDados.Items.Count == 0) 
            { 
                return; 
            }

            salvamento.Filter = "Arquivo TXT|*.txt"; // Filtra
            salvamento.FileName = "dadosdogoverno"; // sugere nome do arquivo
            salvamento.Title = "Salvar arquivo"; // nome do diálogo

            // verifica se a pessoa selecionou o local de salvamento e digitou o nome do arquivo
            if (salvamento.ShowDialog() != DialogResult.OK && salvamento.FileName == null)
            {
                return;
            }

            // Abre o arquivo na pasta
            FileStream file = salvamento.OpenFile() as FileStream;

            //Obtem o arquivo salvo
            StreamWriter streamWriter = new StreamWriter(file);

            // Cria o texto para o salvamento
            string texto = "";

            // Adiciona os dados dentro do arquivo
            foreach (Pessoa pessoa in lboDados.Items)
            {
                texto += pessoa.Nome + "\n";
                texto += pessoa.Sexo == 'F' ? "Feminino\n" : "Masculino\n";
                texto += pessoa.Escolaridade + "\n";
                texto += pessoa.Classe + "\n";
            }
            // Salva os dados dentro do arquivo
            streamWriter.WriteLine(texto);

            // Fecha o arquivo
            streamWriter.Close();
        }
    }
}
