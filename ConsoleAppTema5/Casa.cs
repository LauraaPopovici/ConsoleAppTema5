using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppTema5
{
    public class Casa : Imobil
    {
        public Casa(int inaltime, int suprafata)
        {
            Tip = "casa";
            Inaltime = inaltime;
            Suprafata = suprafata;
        }

        public void NumberOfPeople()
        {
            Console.WriteLine("there are " + Suprafata*1 + " people living here");
        }
    }
}
