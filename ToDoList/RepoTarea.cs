using System.Collections.Generic;
using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoList
{
    //heredamos los atributos de maindata a repo por que la neta me marcaba error si instanciaba la clase jajajaja, ahora amo heredar es mas practico
  public class RepoTarea : MainData
    {

        //MainData data = new MainData(); tenia en este lugar la instaciacion para hacerla global y me daba stackoverflow, ¿por que?
        //username solo se utilizara para que muestre el nombre del usuario, no mas
        string username;
        //el metodo principal solo se esta usando para dar la bienvenida y preguntar el nombre del usuario para ponerlo en los encabezados de los otros metodos
        public void principal()
        {
           
            Console.WriteLine("Bienvenido al creador de tareas");
            Console.WriteLine("================================");
            Console.WriteLine("");
            Console.WriteLine("Ingresa tu nombre");
           username= Console.ReadLine();
            Console.WriteLine("================================");
            Menu();
        }
        //menu sera usado para mostrar el menu y los switch para hacer las operaciones llamando a sus metodos 
        public void Menu()
        {
            Console.WriteLine("Ingrese una opcion del menu");
            Console.WriteLine("=================================");
            Console.WriteLine("");
            Console.WriteLine("1. Crear tarea\n2. Lista de tareas\n3. Detalle de la tareas\n4. Lista de estatus\n5. Ver tarea\n6. Cambiar estatus\n7.salir :)");
            switch (Console.ReadLine())
            {
                //iniciamos con GetDatatarea es el que tomara los datos de la tarea
                //ponemos un clear para cada vez que se regrese al metodo se limpie la consola y ademas desde el incio
                //llamamos al metodo getdata para preguntarle al usuario los datos
                case "1":
                    Console.Clear();
                    Console.WriteLine("Bienvenido "+ username +  " a Crear tareas");
                    GetDataTarea();
                    break;
                    //en la segunda opcion sera la lista de tareas, llamamos al metodo que esta dentro de maindata
                case "2":
                    //hacemos lo mismo que en el 1
                    Console.Clear();
                    Console.WriteLine("Bienvenido " + username + " a Lista de tareas");
                    ListadeTareas();
                    break;

                case "3":
                    //hacemos lo mismo del 1
                    Console.Clear();
                    Console.WriteLine("Bienvenido " + username + " a Detalles de las tareas");
                    DettalleDeTareas();
                    break;
                case "4":
                    Console.Clear();
                    Console.WriteLine("Bienvenido " + username + " a la Lista de estatus");
                    ListaDeEstatus();
                    break;
                case "5":
                    //hacemos lo mismo del 1
                    Console.Clear();
                    Console.WriteLine("Bienvenido " + username + " a ver tarea ");
                    VerTareas();
                    break;
                case "6":
                    //hacemos lo mismo que el 1
                    Console.Clear();
                    Console.WriteLine("Bienvenido " + username + " a cambiar Estautus de tareas");
                    CambiarEstatus();
                    break;
                case "7":
                    //hacemos que cuando el usario meta la tecla despues de mostrar el mensaje se cierre la consola
                    Console.Clear();
                    Console.WriteLine("===============================================");
                    Console.WriteLine("ingresa cualquier tecla para salir, Hasta luego");
                    Console.ReadKey();
                    Environment.Exit(0);
                    break;
                default:
                    //si no mete una opcion valida que se llame de nuevo al menu
                    Console.WriteLine("Agregue una opcion valida");
                    break;
}
            //el corchete esta tripiado alli, pero lo puse asi para que se llame siempre al menu hasta que el usuario cierre el programa
            Console.Clear();
            Menu();
        }

        
    }
}
