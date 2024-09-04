using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula003
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            /*Aluno primeiroAluno = new Aluno();

            primeiroAluno.nomeAluno = "Daniel Sallesse";
            primeiroAluno.idadeAluno = 25;
            primeiroAluno.notaAluno = 7.5;
            primeiroAluno.exibirDados();

            Aluno segundoAluno = new Aluno();

            segundoAluno.nomeAluno = "Rogério Vaughan";
            segundoAluno.idadeAluno = 52;
            segundoAluno.notaAluno = 3.5;
            segundoAluno.exibirDados();

            Aluno terceiroAluno = new Aluno();

            terceiroAluno.nomeAluno = "Andre Henning";
            terceiroAluno.idadeAluno = 45;
            terceiroAluno.notaAluno = 9.5;
            terceiroAluno.exibirDados();*/

            Turma primeiraTurma = new Turma();

            primeiraTurma.cod = 1;
            primeiraTurma.serie = "A";
            primeiraTurma.exibir();

            Turma segundaTurma = new Turma();

            segundaTurma.cod = 2;
            segundaTurma.serie = "B";
            segundaTurma.exibir();

            Turma terceiraTurma = new Turma();

            terceiraTurma.cod = 3;
            terceiraTurma.serie = "C";
            terceiraTurma.exibir();


        }
    }
}
