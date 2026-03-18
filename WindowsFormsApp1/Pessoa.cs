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
    internal class Pessoa
    {
        /* modificadores de acesso c#:
            private -> visível apenas dentro da classe
            internal -> visível apenas dentro do projeto
            public -> visível para todos
        */

        private string _nome;
        private char _sexo;
        private string _escolaridade;
        private string _classe;

        public Pessoa(string nome, char sexo, string escolaridade, string classe)
        {
            _nome = nome;
            _sexo = sexo;
            _escolaridade = escolaridade;
            _classe = classe;
        }

        public string Exibicao()
        {
            return $"{_nome} - {_sexo} - {_escolaridade} - {_classe}";
        }
    }
}
