using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unit_Converter
{
    class Principal
    {
        public void Menu()
        {
            Console.WriteLine("Este es el menu de conversiones: 1. Centimetros a metros. 2. Metros a pulgadas 3. Litros a mililitros.");
            Console.WriteLine("4. Salir.");
            //variables 
            Dato dato = new Dato();
            double res = 0;
            //asignacion de variables
            dato.Unit = Convert.ToInt32(Console.ReadLine());
           
            
            //hacemos un switch para las opciones
            switch (dato.Unit)
            {
                case 1:
                    Console.Write("Ingrese los centimetros deseados:");
                    dato.Amount = Convert.ToDouble(Console.Read());
                    res = dato.Amount / 100;
                    Console.WriteLine(dato.Amount+" centimetros son "+res+" metros.");
                    Console.ReadKey();
                    break;
                case 2:
                    Console.Write("ingrese las metros deseados:");
                    dato.Amount = Convert.ToDouble(Console.Read());
                    res = dato.Amount * 39.37;
                    Console.WriteLine(dato.Amount + " metros son " + res + " pulgadas.");
                    Console.ReadKey();
                    break;
                case 3:
                    Console.Write("ingrese los litros deseados:");
                    dato.Amount = Convert.ToDouble(Console.Read());
                    res = dato.Amount * 1000;
                    Console.WriteLine(dato.Amount + " litros son " + res + " mililitros.");
                    Console.ReadKey();
                    break;
                case 4:
                    Console.WriteLine("Adios");
                    System.Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Ingrese un numero valido");
                    Menu();
                    break;

            }

        }
    }
}
