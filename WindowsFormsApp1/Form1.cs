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
    public partial class Form1 : Form
    {
        private OpenFileDialog leitura = new OpenFileDialog();
        private SaveFileDialog salvamento = new SaveFileDialog();
        private string caminho;

        public Form1()
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
            try
            {
                // Importar a biblioteca: System.IO (manipulação de arquivos)
                // O método: File.ReadAllText - Irá ler os dados dentro do arquivo
                var textoLido = File.ReadAllText(caminho);

                // Extrair Texto e coloca dentro do vetor linhas
                string[] linhas = textoLido.Split('\n');

                foreach (string linha in linhas) { 
                    lboDados.Items.Add(linha);
                }

            } // Caso acontença qualquer erro na linha no try, ele irá cair nesse bloco 
            catch (Exception erro) {
                // Mostra o erro
                MessageBox.Show(erro.Message);
            }
        }
    }
}
