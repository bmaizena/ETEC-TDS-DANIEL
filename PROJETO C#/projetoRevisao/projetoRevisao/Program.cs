using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetoRevisao
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Curso ds = new Curso();
            ds.id = 01;
            ds.setNome("Desenvolvimento de Sistemas");


            Curso lgt = new Curso();
            lgt.id = 02;
            lgt.setNome("Logística");


            Curso adm = new Curso();
            adm.id = 03;
            adm.setNome("Administração");
            
            
            //---------------------------------------------------------------------------

            Professor p1 = new Professor();
            p1.setNome("Jalin Rabey");
            p1.setMatricula(16);

            Professor p2 = new Professor();
            p2.setNome("Taka Nomuro");
            p2.setMatricula(90);

            Professor p3 = new Professor();
            p3.setNome("Carim Zema");
            p3.setMatricula(76);

            adm.prof = p1;

            //----------------------------------------------------------------------------

            Curso padaria = new Curso();
            padaria.id = 6;
            padaria.setNome("Padaria Buraco Negro");
            padaria.prof = new Professor();
            padaria.prof.setMatricula(23);
            padaria.prof.setNome("Mantegaldo Semsalzino");

            //----------------------------------------------------------------------------

            Curso gastronomia = new Curso();
            gastronomia.id = 66;
            gastronomia.setNome("Restaurante 7 Vidas");

            gastronomia.prof = new Professor();
            gastronomia.prof.setMatricula(12);
            gastronomia.prof.setNome("Erico Jaquinho");

            gastronomia.mod = new Modalidade();
            gastronomia.mod.setCodigo(7);
            gastronomia.mod.setCategoria("Presencial");
        }
    }
}
