using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank07
{
    class Program
    {
        static void Main(string[] args)
        {
            //instanciamos para poder poder llamar al metodo principal en repobank
            RepoBank r = new RepoBank();
            r.Principal();
        }
    }
}
