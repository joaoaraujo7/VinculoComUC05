using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    /// <summary>
    /// Representa a pessoa da base de dados dadosdogoverno.txt
    /// </summary>
    /// <param name="nome">Nome da pessoa na base de dados </param>
    /// <param name="sexo">Sexo da pessoa na base de dados </param>
    /// <param name="escolaridade">Escolaridade da pessoa na base de dados </param>
    /// <param name="classe">Classe da pessoa na base de dados </param>
    public class Pessoa
    {
        /* modificadores de acesso c#:
            private -> visível apenas dentro da classe
            internal -> visível apenas dentro do projeto
            public -> visível para todos
        */

        public string Nome { get; private set; }
        public char Sexo { get; private set; }
        public string Escolaridade { get; private set; }
        public string Classe { get; private set; }

        public Pessoa(string nome, char sexo, string escolaridade, string classe)
        {
            Nome = nome;
            Sexo = sexo;
            Escolaridade = escolaridade;
            Classe = classe;
        }

        /// <summary>
        /// Atualiza os campos Nome, Escolaridade, Sexo e Classe com os valores fornecidos.
        /// </summary>
        /// <param name="nome">Novo valor para o campo Nome.</param>
        /// <param name="sexo">Novo valor para o campo Sexo.</param>
        /// <param name="escolaridade">Novo valor para o campo Escolaridade.</param>
        /// <param name="clase">Novo valor para o campo Classe.</param>

        public void AtualizarCampos(string nome, char sexo, string escolaridade, string clase)
        {
            Nome = nome;
            Sexo = sexo;
            Escolaridade = escolaridade;
            Classe = clase;
        }

        public string Exibicao()
        {
            return $"{Nome} - {Sexo} - {Escolaridade} - {Classe}";
        }

        public override string ToString() => $"{Nome} - {Sexo} - {Escolaridade} - {Classe}";
    }
}
