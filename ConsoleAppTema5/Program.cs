using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppTema5
{
    class Program
    {
        static void Main(string[] args)
        {
            Exercitiul1();
            Exercitiul2();

        }

        static void Exercitiul1()
        {
            Pisica ruffy = new Pisica();
            ruffy.Talk("miau");
            ruffy.Fly();
            Console.WriteLine();
            Caine rex = new Caine("Rex",3,30);
            rex.Talk(rex.Varsta,rex.Greutate);
            rex.Fly();
            //Console.ReadLine();
        }

        static void Exercitiul2()
        {
            Casa cuib = new Casa(10, 100);
            cuib.NumberOfPeople();
            cuib.Reabilitare();
            Console.WriteLine();
            Bloc burjKhalifa = new Bloc("skyscraper", 10000, 840);
            burjKhalifa.NumberOfPeople();
            burjKhalifa.Reabilitare(40);
            Console.ReadLine();
        }
    }
}
