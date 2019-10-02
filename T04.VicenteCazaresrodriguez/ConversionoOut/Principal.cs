    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversionoOut
{
   public class Principal
    {
        //iniciamos el out, para que el argumento pase como referencia 
public void Convertir(int totalcen, out int pesos, out int centavos)
        {
            //aqui hacemos los calculos
            pesos = totalcen / 100;
            centavos = totalcen % 100;
        }
        //metodo out
        public void Opercion()
        {
            //declaramos las variables
            int totalcen, pesos, centavos;
            pesos = 0;
            centavos = 0;
            //pedimos los centavos que se convertiran en pesos
            Console.WriteLine("ingrese los centavos");
            //damos salida al resultado convirtiendo de string a int el resultado
            totalcen = Convert.ToInt32(Console.ReadLine());
            //se inicia con el parametro, pesos y centavos seran de salida
            Convertir(totalcen, out pesos, out centavos);
            //concatenamos el resultado para que salga corrido 
            Console.WriteLine("La conversion es: $" +pesos +"."+centavos+ " pesos");
            //readkey para que no se elimine antes de que salga el resultado
            Console.ReadKey();

            
        }
    }
}
