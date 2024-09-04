using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula003
{
    internal class Aluno
    {
        public String nomeAluno;
        public int idadeAluno;
        public Double notaAluno;

        public void exibirDados()
        {
            Console.WriteLine($" Aluno: {nomeAluno} \n Idade: {idadeAluno} \n Nota: {notaAluno} \n");
        }

    }
}
