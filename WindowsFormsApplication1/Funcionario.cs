using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    public class Funcionario
    {
        private int id;
        private String nome;
        private String endereco;
        private String telefone;
        private String celular;
        private String ocupacao;
        private String login;
        private String senha;
        private DateTime dataCadastro;
        private bool ativo;


        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public String Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public String Endereco
        {
            get { return endereco; }
            set { endereco = value; }
        }

        public String Telefone
        {
            get { return telefone; }
            set { telefone = value; }
        }

        public String Celular
        {
            get { return celular; }
            set { celular = value; }
        }

        public String Ocupacao
        {
            get { return ocupacao; }
            set { ocupacao = value; }
        }

        public String Login
        {
            get { return login; }
            set { login = value; }
        }

        public String Senha
        {
            get { return senha; }
            set { senha = value; }
        }

        public DateTime DataCadastro
        {
            get { return dataCadastro; }
            set { dataCadastro = value; }
        }

        public bool Ativo
        {
            get { return ativo; }
            set { ativo = value; }
        }






    }
}
