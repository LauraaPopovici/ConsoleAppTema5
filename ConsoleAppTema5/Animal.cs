using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppTema5
{
    public class Animal
    {
        public int Varsta { get; set; }
        public int Greutate { get; set; }
        public string Nume { get; set; }

        public void Talk()
        {
            Console.WriteLine("Nothing to say");
        }

        public void Talk(string language)
        {
            Console.WriteLine(language);
        }

        public void Talk(int age, int weight)
        {
            Console.WriteLine("greutate: " + weight + " varsta: " + age);
        }

        public void Fly()
        {
            Console.WriteLine("flying now");
        }
    }
}
