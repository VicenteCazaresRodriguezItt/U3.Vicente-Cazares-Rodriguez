using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sobrecargaa
{
    public class Operaciones
    {

        public void Sumas()
        {
            //iniciamos la sobre carga
            //los numeros dentro del parentesis seran sustituidos en la operaciones, la sobre carga 
            //se hara cargo de poner los numeros correctos a sumar
            double res1 = Suma(4, 6, 2);
            Console.WriteLine("La respuesta es: " + res1);
            Console.ReadKey();
            //solo se usaran 2 datos
            double res2 = Suma(4, 6);
            Console.WriteLine("La respuesta es: " + res2);
            //read key para que cada vez que aplastemos enter se haga una por una y no salga todo de golpe
            Console.ReadKey();

            double res3 = Suma(4);
            Console.WriteLine("La respuesta es: " + res3);
            Console.ReadKey();

        }

        public  double Suma(int a, int b, int c)
        {
            //return para que retorne valor
            return a + b + c;
        }

        public  double Suma(int a, int b)
        {
            return a + b;
        }

        public  double Suma(int a)
        {
            return a ;
        }
    }
}
