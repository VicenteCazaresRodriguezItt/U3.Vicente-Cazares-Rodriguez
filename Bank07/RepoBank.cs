using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank07
{
   public class RepoBank
    {
        //instanciamos globalmente para el foreach y otros metodos
        Accountdata ad;
        public RepoBank()
        {
            //hacemos que la clase accountdata sea instanciada en ad
            ad = new Accountdata();
        }
        internal void Principal()
        {
            //iniciamos el programa dando la bienvenida y llamndo al metodo menu
            Console.WriteLine("Bienvenidos A el Banco mi cosita :^)");
            Menu();
            Console.ReadLine();
        }

        private void Menu()
        {
            //agregamos el menu con 3 casos o opciones
            Console.WriteLine("Ingrese una opcion");
            Console.WriteLine("1.- Cuenta Ahorro \n2.- Pensiones \n3.- Cuenta Corriente");
            //en vez de poner el resultaod en una variable int, lo pasamos directo en string y ya el resultado
            switch (Console.ReadLine())
            {
                //damos la bienvenida con cada case y ademas llamamos a sus respectivos metodos
                case "1":
                    Console.WriteLine("Bienvenido a Cuenta Ahorro");
                    GetDataSave();
                    break;
                case "2":
                    Console.WriteLine("Bienvenido a Pensiones");
                    GetDataPension();

                    break;

                case "3":
                    Console.WriteLine("Bienvenido a Cuenta Corriente");
                    GetDataCurrent();
                    break;

                default:
                    break;
            }
        }

        private void GetDataCurrent()
        {   
            
            int number = GetData();

        }



        private void GetDataPension()
        {
            //este metodo se usara para abrir la cuenta de los pensionados
            int number = GetData();
            var lista = ad.Pensiones();
            PensionAccount p = new PensionAccount();
            //usamos un foreach para que evalue todas las posbiles cuentas que tenemos almacenadas
            foreach (var cuenta in lista)
            {
                //si el numero es igual a una cuenta en la clase instanciada de cuenta, entonces hara lo siguiente
                if (number == cuenta.AccountNumber)
                {
                    p = cuenta;
                }
                //Console.WriteLine(item.Headline);
            }

            Console.WriteLine("Bienvenido " + p.Headline);

            MenuUsuario(p);
        }

        private void MenuUsuario(Account p)
        {
            //aqui mostramos el menu del usuario
            Console.Clear();
            Console.WriteLine("Bienvenido a tu Cuenta :" + p.Headline);
            Console.WriteLine("1.- Consultar Saldo \n2.- Transferir \n3.- Interes x Mes 4.- Ingreso");
            Console.WriteLine("Elije una Opcion");

            //ya estando en su cuenta podra acceder a las opciones que le demos, aqui meteremos los metodos que usara el usuario para cada opcion
            switch (Console.ReadLine())
            {
                case "1":
                    p.ConsultarSaldo(p);
                    break;
                case "2":

                    break;
                case "3":

                    break;
                case "4":

                    break;

                default:
                    break;
            }

        }

        private void GetDataSave()
        {
            int number = GetData();
        }

        private int GetData()
        {
            //tomamos lo que el usuario mete como su numero de cuenta paraque sea evaluado despues y retorne el valor en int
            Console.WriteLine("Ingrese Su Numero de Cuenta");
            string res = Console.ReadLine();
            return Convert.ToInt32(res);
        }


    }

}
