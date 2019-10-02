using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sobrecarga
{
    public class Operaciones
    {
        

        public double Multiplicacion(double a, double b, double c)
        {
            //hacemos las multiplicaciones con los datos que nos da el usuario
            double res;
            res = a * b * c;
            return res;

        }
        public double Multiplicacion(double a, double b)
        {
            double res;
            res= a* b;
            return res;
        }
        public double Multiplicacion(double a)
        {
           
            double res;
            res = a * 1;
            return res;
        }
    }
}
