using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppTema5
{
    public class Bloc : Imobil
    {
        public Bloc(string tip, int suprafata, int inaltime)
        {
            Tip = tip;
            Suprafata = suprafata;
            Inaltime = inaltime;
        }

        public void NumberOfPeople()
        {
            Console.WriteLine("there are " + Inaltime*100 + "people living here");
        }
    }
}
