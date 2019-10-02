using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversionoOut
{
    class Program
    {
        static void Main(string[] args)
        {
            //damos la bienvenida 
            Console.WriteLine("Hola bienvenido");
            //hacemos que al presionar una tecla se inicie las operaciones 
            Console.WriteLine("presiona enter para iniciar");
            Console.ReadKey();
            //iniciamos instanciando 
            Principal prins = new Principal();
            //llamamos al metodo
            prins.Opercion();
        }
    }
}
