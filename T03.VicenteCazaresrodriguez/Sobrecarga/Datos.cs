using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sobrecarga
{
    public class Datos
    {
       public void mostrardatos()
        {

            //instanciamos
            Operaciones op = new Operaciones();
            //iniciamos la bienvenida
            Console.WriteLine("Que pex");
            Console.WriteLine("ingresa 3 datos");
            Console.WriteLine("dato 1");
            //lo convertimos en double para evirtar errores por que esta en string
            double cool = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("dato 2");
            double cool2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("dato 3");
            double cool3 = Convert.ToDouble(Console.ReadLine());
            //hacemos las multiplicaciones de las sobrecargas
            double Res = op.Multiplicacion(cool* cool2* cool3);
            Console.WriteLine("el resultado es " + Res);
            double Res2= op.Multiplicacion(cool * cool2 );
            Console.WriteLine("el resultado es " + Res2);
            double Res3= op.Multiplicacion(cool);
            Console.WriteLine("el resultado es " + Res3);
        }
    }
}
