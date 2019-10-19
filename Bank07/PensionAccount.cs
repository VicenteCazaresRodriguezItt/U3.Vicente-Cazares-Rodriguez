using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank07
{
    public class PensionAccount : Account
    {
        //hacemos la encapulacion de las variables que utilizaremos en el codigo
        public DateTime Expiration { get; set; }
        public int Quotation { get; set; }
        public int NAccountPrincipal { get; set; }
    }
}
