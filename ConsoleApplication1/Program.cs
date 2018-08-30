using Clones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa pesoa1 = new Pessoa();
            pesoa1.Id = 1234;
            pesoa1.Nome = "João";
            pesoa1.UsaOculos = true;


            Pessoa pessoa2 = new Pessoa();
            CloneObject.CopyValues<Pessoa>(pessoa2, pesoa1);

            Console.ReadKey();


        }
    }
}
