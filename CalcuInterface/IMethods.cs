using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcuInterface
{
    interface IMethods
    {
        //no pueden ser publicas las variables y ni los metodos de una interface
        double Suma();
        double Resta();
        double Multiplicacion();
        double Division();
    }
}
