using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppTema5
{
    public class Caine : Animal
    {
        public Caine(string name, int age, int weight)
        {
            Nume = name;
            Varsta = age;
            Greutate = weight;
        }

        public void Fly()
        {
            Console.WriteLine("No thank you.");
        }
    }
}
