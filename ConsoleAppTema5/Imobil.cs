using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppTema5
{
    public class Imobil
    {
        public int Inaltime { get; set; }
        public int Suprafata { get; set; }
        public string Tip { get; set; }

        public void NumberOfPeople()
        {
            Console.WriteLine("there are 0 people living here");
        }

        public void Reabilitare(int floorNumbers)
        {
            Console.WriteLine("Au fost reabilitate " + floorNumbers+ " etaje");
        }

        public void Reabilitare()
        {
            Console.WriteLine("A fost reabilitat tot imobilul");
        }
    }
}
