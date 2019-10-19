using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoList
{
    class Program
    {
        static void Main(string[] args)
        {
            //instanciamos para acceder a princiapl dentro de repotarea
            RepoTarea tarea = new RepoTarea();
            //mandamos a llamar al metodo
            tarea.principal();
        }
    }
}
