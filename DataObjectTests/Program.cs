using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataObjectTests
{
    class Program
    {
        static void Main(string[] args)
        {
            var sum = 0;
            for (int i = 0; i < 100; i+=2)
            {
                MapValidation mapTestA = new MapValidation();
                MapValidation mapTestB = new MapValidation();
                var Test1 = mapTestA.WholeTest();
                var Test2 = mapTestB.WholeTest();
                Console.WriteLine("Mapa nr {0}, wynik: {1}\t Mapa nr {2}, wynik: {3}", i,Test1, i+1,Test2);
                if (Test1) sum++;
                if (Test2) sum++;

            }
            Console.WriteLine("Poprawnie wygenerowano: {0}% z map",sum);
            MapValidation mapTest2 = new MapValidation();
            //mapTest2.Tests();
            Console.ReadKey();
        }
    }
}
