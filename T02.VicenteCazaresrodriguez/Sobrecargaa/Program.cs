using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sobrecargaa
{
    class Program
    {
        static void Main(string[] args)
        {
            //instanciamos el metodo 
            Operaciones oper = new Operaciones();
            //ponemos mensajes para que los vea el usuario y haga lo dicho
            Console.WriteLine("Los numeros que se usaran son: 4, 6 y 2.");
            Console.WriteLine("presiona enter para comenzar");
            Console.ReadKey();
            //llamamos a el subprograma despues de presionar una tecla
            oper.Sumas();
        }
    }
}
