using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
  public class Principal
    {
        //instanciamos las dos clases 
        Valor Val = new Valor();
        Operacion oper = new Operacion();
        
        public void PedirVal()
        {
            //mensaje y captur de datos
            Console.WriteLine("Introduce el primer valor");
            Val.Valor1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Introduce el segundo valor");
            Val.Valor2 = Convert.ToDouble(Console.ReadLine());
            //para ir al menu al acabar 
            Menu();

        }
        public void Menu()
        {
            //opciones para que el usuario introduzca para hacer las operaciones
            Console.WriteLine("1. Sumar, 2. Restar, 3. Multiplicar, 4. Dividir, 5. Salir");
            int opc;
            double res;
            //aqui ya introduce la opcion
            Console.WriteLine("Introduce la opcion");
            opc = Convert.ToInt32(Console.ReadLine());
            //opc = opcion que tome el usuario
            switch (opc)
            {
                case 1:
                    //llamamos al subprograma para que haga la operacion con los valores, dependiendo
                    //de la opcion, se hara una operacion diferente, despues emprimira el resultado y limpiara 
                    //esto lo hacemos con todas
                    res = oper.Sumar(Val);
                    Console.WriteLine("el resultado es: " + res);
                    Console.ReadKey();
                    Console.Clear();

                    break;
                case 2:
                    res = oper.Resta(Val);
                    Console.WriteLine("el resultado es: " + res);
                    Console.ReadKey();
                    Console.Clear();
                    break;
                case 3:
                    res = oper.Multiplicacion(Val);
                    Console.WriteLine("el resultado es: " + res);
                    Console.ReadKey();
                    Console.Clear();
                    break;
                case 4:
                    res = oper.Division(Val);
                    Console.WriteLine("el resultado es: " + res);
                    Console.ReadKey();
                    Console.Clear();
                    
                    break;
                case 5:
                    //salida
                    Environment.Exit(0);
                    break;


            }
        }

        


    }
}
