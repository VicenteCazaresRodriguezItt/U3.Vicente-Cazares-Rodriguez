using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcuInterface
{
    //no se puede heredar asi que al poner eso : tenemos que escribir todo los atributos de las interfaces, siendo los metodos que usaremos y las variables
    class Principal:IDatos,IMethods
    {
        public double N1 { get ; set ; }
        public double N2 { get ; set; }
        public double Res { get; set; }

        public void Menu()
        {
           
            
            //para que no haya errores, hacemos que cada vez que se llame al menu se hagan 0 los valores
            N1 = 0;
            N2 = 0;
            //opcion para el switch
            int opc;
           
            Console.WriteLine("Este es el menu:\n1.Sumar\n2.Restar\n3.Multiplicar\n4.Dividir\n5.Salir");
            Console.WriteLine("elije una opcion");

            //hacemos el swtich para la opcion
            opc =Convert.ToInt32(Console.ReadLine());
            switch (opc)
            {
                case 1:
                    Console.Clear();
                    Console.WriteLine("=================================");
                    Console.WriteLine("      Bienvenido a Sumar");
                    Console.WriteLine("=================================");
                    Console.WriteLine("Ingresa el pimer valor");
                    //le damos los valores a los numeros en la interface
                   N1= Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Ingresa el segundo valor");
                    N2 = Convert.ToDouble(Console.ReadLine());
                    //llamamos al metodo de la interface que necesitamos
                    Suma();
                    Console.WriteLine("El resultado es: "+Res);
                    break;
                case 2:
                    Console.Clear();
                    Console.WriteLine("=================================");
                    Console.WriteLine("     Bienvenido a Restar");
                    Console.WriteLine("=================================");
                    Console.WriteLine("Ingresa el pimer valor");
                    N1 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Ingresa el segundo valor");
                    N2 = Convert.ToDouble(Console.ReadLine());
                    Resta();
                    Console.WriteLine("El resultado es: " + Res);
                    break;
                case 3:
                    Console.Clear();
                    Console.WriteLine("=================================");
                    Console.WriteLine("    Bienvenido a Multiplicar");
                    Console.WriteLine("=================================");
                    Console.WriteLine("Ingresa el pimer valor");
                    N1 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Ingresa el segundo valor");
                    N2 = Convert.ToDouble(Console.ReadLine());
                    Multiplicacion();
                    Console.WriteLine("El resultado es: " + Res);
                    break;
                case 4:
                    Console.Clear();
                    Console.WriteLine("=================================");
                    Console.WriteLine("     Bienvenido a Dividir");
                    Console.WriteLine("=================================");
                    Console.WriteLine("Ingresa el pimer valor");
                    N1 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Ingresa el segundo valor");
                    N2 = Convert.ToDouble(Console.ReadLine());
                    Division();
                    Console.WriteLine("El resultado es: " + Res);
                    break;
                case 5:
                    Console.Clear();
                    Console.WriteLine("=================================");
                    Console.WriteLine("Adios :P");
                    Console.WriteLine("=================================");
                    Console.ReadKey();
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("=================================");
                    Console.WriteLine("Ingrese una opcion valida");
                    Console.ReadKey();
                    break;
            }
            Console.ReadKey();
            //iniciamos con un console.clear para que se limpie la consola cada vez que se llame al menu, ya que se llamara cuando salga el resultado
            Console.Clear();
            Menu();

        }

        public double Division()
        {
            Res = N1 / N2;
            return Res;
        }

        public double Multiplicacion()
        {
            Res = N1 * N2;
            return Res;
        }

        public double Resta()
        {
            Res = N1 - N2;
            return Res;
        }

        public double Suma()
        {
            Res = N1 + N2;
            return Res;
        }
    }
}
