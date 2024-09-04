using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoClasses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cliente cli01 = new Cliente();
            cli01.nome = "Daniel";
            cli01.codigo = 01;
            cli01.peso = 90.5;

           


            Veiculo vei01 = new Veiculo();
            vei01.setPlaca("ayu7683");
            vei01.setCor("azul");
            vei01.setAno(2006);


            vei01.exibir();

            Console.WriteLine("----DADOS DO VEI01----");
            Console.WriteLine($"a placa do veiculo é {vei01.getPlaca()}");
            Console.WriteLine($"o ano do veiculo é {vei01.getAno()}");
            Console.WriteLine($"a cor do veiculo é {vei01.getCor()}");

        }
    }
}
