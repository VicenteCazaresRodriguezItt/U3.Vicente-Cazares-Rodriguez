using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcuInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            //instanciamos el principal para llamar al menu
            Principal pri = new Principal();

            //llamamos al menu
            Console.WriteLine("=================================");
            Console.WriteLine(" ");
            Console.WriteLine("          Bienvenido");
            Console.WriteLine("");
            Console.WriteLine("=================================");
            pri.Menu();
        }
    }
}
