using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
   public class Operacion
    {
        //instanciamos
        Valor val = new Valor();
        //variable para la respuesta
        double res;
        
        public double Sumar(Valor val)
        {
            //hacemos las operaciones con las variables que encapsulamos, lo hacemos con los 4 casos
            //y retornamos res 
            res = val.Valor1 + val.Valor2;
            return res;
        }

        public double Resta(Valor val)
        {
            res = val.Valor1 - val.Valor2;
            return res;
        }
        public double Multiplicacion(Valor val)
        {
            res = val.Valor1 * val.Valor2;
            return res;
        }
        public double Division(Valor val)
        {
            res = val.Valor1 / val.Valor2;
            return res;
        }
    }
}
