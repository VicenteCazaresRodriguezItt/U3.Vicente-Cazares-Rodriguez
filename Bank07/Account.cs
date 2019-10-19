using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank07
{
   public class Account
    {
        
        //Creación de Atributos Principales
        public int AccountNumber { get; set; }

        public string Headline { get; set; }

        public double Balance { get; set; }

        public double Interest { get; set; }

        //aqui hacemos las operaciones para las opciones del usuario pensionado despues de que meta su cuenta correcta
        public bool Ingreso()
        {
            return false;

        }
        public double InteresPorMes(double Interes)
        {
            var iTotal = Interes * .16;
            return iTotal;

        }
        public void ConsultarSaldo(Account account)
        {

            Console.WriteLine("Su saldo Actual es de  $" + account.Balance);
        }
        public void Tranferir()
        {

        }
    }
}

