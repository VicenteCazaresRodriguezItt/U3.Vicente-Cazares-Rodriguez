using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoList
{
   public class MainData
    {
       //instanciamos tarea para hacer la lista de ese atributos que hay alli
        List<Tarea> lista = new List<Tarea>();
        

        //modifificadores de acceso
        public void GetDataTarea()
        {   
            //instanciamos tarea para acceder a los atributos que tiene
            Tarea t = new Tarea();
            //pedimos al usuario sus datos
            //y los asignamos a las variables que tenemos a tareas por medio de la instanciacion de la clase
            Console.WriteLine("Ingrese el nombre de la tarea:");
            t.name = Console.ReadLine();
            Console.WriteLine("Ingrese la descripcion de la tarea:");
            t.description = Console.ReadLine();
            Console.WriteLine("Ingrese la hora en la que se entregara de la tarea:");
            t.time = Console.ReadLine();
            Console.WriteLine("Ingrese la fecha en la que se entregara la tarea:");
            t.date = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine("Ingrese el estatus en el que se encuentra la tarea:");
            t.status = Console.ReadLine();
            //usaamos list add para que cada vez que se agregue los datos se agreguen como si fuera un arreglo, no tenemos un limite definido por eso se agregan mas y mas
            lista.Add(t);
        }

        public void ListadeTareas()
        {
         //emprimimos las tareas que hay con un foreach para que se empriman todas, solo los nombres de las tareas no mas   
            foreach(Tarea d in lista)
            {
                Console.WriteLine(d.name);
                Console.WriteLine("");

            }
            //puse un readkey para que se pudieran ver los datos antes de que se vaya al menu de nuevo
            Console.ReadKey();
        }

        internal void DettalleDeTareas()
        {
            //usamos un foreach de igual manera, solo hice copypaste de el pasado y cambie las variables y agregue en la impersion el nombre y que en el siguiente renglon se agregue la descrip
            foreach (Tarea d in lista)
            {
                Console.WriteLine("El detalle de la tarea "+d.name+" es:\n"+d.description);
                Console.WriteLine("========================================");
                Console.WriteLine("");
            }
            Console.ReadKey();
        }

        internal void ListaDeEstatus()
        {
            //lo mismo que en el pasado pero con otras variables
            foreach (Tarea d in lista)
            {
                Console.WriteLine("El estatus de la tarea " + d.name + " es:\n" + d.status);
                Console.WriteLine("========================================");
                Console.WriteLine("");
            }
            Console.ReadKey();
        }

        internal void CambiarEstatus()
        {
            
            foreach (Tarea d in lista)
            {
                //usamos una variable string en la cual se pondra el nombre, el nombre y no la fecha por que tendremos problemas si lo hacemos por fecha ya que si hay mas de 1 valdra vrga
                string opc;
                Console.WriteLine("ingrese el nombre de la tarea, para cambiar su estatus:");
                //asignamos el valor que nos da el usuario en opc
               opc= Console.ReadLine();
                //si opc era igual a un nombre de una tarea entonces procedera 
                if (opc == d.name)
                {
                    //mostramos al usuario el estatus que tenemos antes de cambiarlo
                    Console.WriteLine("");
                    Console.WriteLine("El estatus es: "+d.status);
                    Console.WriteLine("");
                    //asignamos el nuevo estatus a la lista en estatus de ese objeto
                    Console.WriteLine("Ingrese el nuevo estatus:");
                    d.status = Console.ReadLine();
                    Console.WriteLine("===================================================");
                    Console.WriteLine("");
                    Console.WriteLine("el nuevo estatus de la tarea "+d.name+" es "+d.status);
                    Console.ReadKey();
                }
                //un return por que me daba abria de nuevo lo pasado, opte por esto para que se saliera del metodo al menu
                return;
            }
            Console.ReadKey();
        }
        internal void VerTareas()
        {
            //aqui a diferencia del otro, lo hacemos con una fecha ya que solo mostrara las tareas y sus datos, pueden haber varias en una fecha
            DateTime opc;
            Console.WriteLine("ingrese una fecha de una tarea:");
           opc= Convert.ToDateTime(Console.ReadLine());
            
            //hacemos lo mismo que en cambiar estatus nomas que aqui no cambiamos nada, solo emprimimos en base a la fecha las tareas que tenemos 
            //esta primero cambiar estatus por que despues de acabar el codigo cambie de posicion los dos
            foreach (Tarea d in lista)
            {
                    if (opc == d.date)
                    {
                    Console.WriteLine("");
                        Console.WriteLine("Los datos de la tarea " + d.name + " es:\n" + d.description + "\n" + "se entrega a las " + d.time + " del dia " + d.date.ToString("MM/dd/yyyy"));
                        Console.WriteLine("========================================");
                    Console.WriteLine("");
                    }
            }
            Console.ReadKey();
        }
    }
}
