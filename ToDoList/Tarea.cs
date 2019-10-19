using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoList
{
  public  class Tarea
    {
        //name se usara para el nombre de la tarea
        public string name { get; set; }
        // description para la descripcion de la tarea
        public string description { get; set; }
        //time se usara para la hora de la tarea en que se entregara
        public string time { get; set; }
        //date se usara con un datetime por que sera para una fecha
        public DateTime date { get; set; }
        //y por ultimo el status se usara para el estatus de la tarea
        public string status { get; set; }
    }
}
