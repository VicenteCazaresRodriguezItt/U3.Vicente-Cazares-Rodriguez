using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sobrecarga
{
    class Program
    {
        static void Main(string[] args)
        {
            //experimento con la sobre carga poniendo los valores uno mismo
            //esto no se utiliza 
            //instanciamos
            Operaciones op = new Operaciones();
            //asignamos las respuestas
             var res1 = op.Multiplicacion(2, 3, 4);
            var res2 = op.Multiplicacion(5, 3);
            var res3 = op.Multiplicacion(2);
            Datos d = new Datos();
            //llamamos al metodo 
            d.mostrardatos();
            Console.ReadKey();

        }
    }
}
