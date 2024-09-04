using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula003
{
    internal class Turma
    {
        public int cod;
        public string serie;

        public void exibir()
        {
            Console.WriteLine($"{cod}°{serie}");
        }
            
    }
}
