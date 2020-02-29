using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppTema5
{
    public class Pisica : Animal
    {
        public Pisica()
        {
            Nume = "pisica";
            Varsta = 2;
            Greutate = 4;
        }
        
        public void Fly()
        {
            Console.WriteLine("I wish!");
        }
    }
}
