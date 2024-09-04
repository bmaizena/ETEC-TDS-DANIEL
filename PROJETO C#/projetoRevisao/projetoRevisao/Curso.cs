using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetoRevisao
{
    internal class Curso
    {
        public int id;
        private string nome;
        public Professor prof;
        public Modalidade mod;


        public void setNome(String nome)
        {
            this.nome = nome.ToUpper();
        }

    }
}
