using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroDeObrasDeArte
{
    public class Arte : IArte
    {
        public Arte()
        {
            this._Nome = "";
            this.Descricao = "";
        }

        public Arte(string nome, string descricao)
        {
            this._Nome = nome;
            this.Descricao = descricao;
        }

        private string nome;
        public string _Nome
        {
            get { return this._Nome; }

            set { this.nome = value.ToUpper(); }
        }
        private string descricao;
        public string Descricao
        {
            get { return this.descricao; }

            set { this.descricao = value.ToUpper(); }
        }
        public void Exibir()
        {
            //Console.WriteLine("Arte: " + this.Nome + " Descricao: " + this.Descricao);
            Console.WriteLine("Arte: {0} - Descricao: {1}", this.nome, this.Descricao);
        }
    }

}

