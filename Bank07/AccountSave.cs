using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank07
{
    public class AccountSave : Account
    {
        public DateTime Expiration { get; set; }

        public double IngresoPorMes()
        {
            return 0;
        }
    }
}
