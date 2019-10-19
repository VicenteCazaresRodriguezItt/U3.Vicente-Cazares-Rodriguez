using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank07
{
  public  class Accountdata
    {
        //aqui podemos enonctrar las cuentas con sus respectivos detalles como, expiracion, numero de cuenta, el nombre de la persona y el interes aplicado a el y retorna valor a pensiones
        public List<PensionAccount> Pensiones()
        {
            List<PensionAccount> pensions = new List<PensionAccount>();
            pensions.Add(new PensionAccount { AccountNumber = 12345, Balance = 12000, Expiration = new DateTime(2020, 04, 02), Headline = "Vicente el chido", Interest = 2.21, NAccountPrincipal = 12345, Quotation = 25 });
            pensions.Add(new PensionAccount { AccountNumber = 11234, Balance = 13000, Expiration = new DateTime(2020, 04, 02), Headline = "pablo el naco", Interest = 2.21, NAccountPrincipal = 11234, Quotation = 25 });
            pensions.Add(new PensionAccount { AccountNumber = 12234, Balance = 40000, Expiration = new DateTime(2020, 04, 02), Headline = "pepe pica piedras", Interest = 2.21, NAccountPrincipal = 12234, Quotation = 25 });
            pensions.Add(new PensionAccount { AccountNumber = 13345, Balance = 50000, Expiration = new DateTime(2020, 04, 02), Headline = "Elva ginon", Interest = 2.21, NAccountPrincipal = 13345, Quotation = 25 });
            pensions.Add(new PensionAccount { AccountNumber = 14456, Balance = 60000, Expiration = new DateTime(2020, 04, 02), Headline = "Sancho panza", Interest = 2.21, NAccountPrincipal = 14456, Quotation = 25 });
            return pensions;

        }
        public List<AccountSave> Saves()
        {
            //creamos una lista con account save para retornar la instanciacion 
            List<AccountSave> saves = new List<AccountSave>();

            return saves;

        }
        public List<CurrentAccount> Currents()
        {
            //hacemos lo mismo que con Saves method

            List<CurrentAccount> currents = new List<CurrentAccount>();

            return currents;

        }

    }
}

