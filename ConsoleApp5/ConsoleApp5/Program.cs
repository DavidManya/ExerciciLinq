using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp5
{
    class Program
    {
        
        static void Main(string[] args)
        {
            //Fase 1  
            int[] ArrayMostra = new int[15] { 2, 6, 8, 4, 5, 5, 9, 2, 1, 8, 7, 5, 9, 6, 4 };

            IEnumerable<int> queryParell = from num in ArrayMostra.Where(x => x % 2 == 0) select num;

            int[] ArrayParell = queryParell.ToArray();

            foreach (int i in ArrayParell)
            {
                Console.WriteLine(i);
            }

            //Fase 2
            Console.WriteLine("Nota Mitjana:");
            Console.WriteLine(ArrayMostra.Average());
            Console.WriteLine();
            Console.WriteLine("Nota Màxima:");
            Console.WriteLine(ArrayMostra.Max());
            Console.WriteLine();
            Console.WriteLine("Nota Mínima:");
            Console.WriteLine(ArrayMostra.Min());

            //Fase 3
            Console.WriteLine();
            Console.WriteLine("Mostrem números majors a 5 dins l'array:");
            IEnumerable<int> queryMes5 = from num in ArrayMostra.Where(x => x > 5) select num;
            int[] ArrayMes5 = queryMes5.ToArray();
            foreach (int i in ArrayMes5)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();
            Console.WriteLine("Mostrem números menors a 5 dins l'array:");
            IEnumerable<int> queryMenys5 = from num in ArrayMostra.Where(x => x < 5) select num;
            int[] ArrayMenys5 = queryMenys5.ToArray();
            foreach (int i in ArrayMenys5)
            {
                Console.WriteLine(i);
            }
            //Fase 4
            string[] ArrayNoms = new string[7] {"David", "Sergio", "Maria", "Laura", "Oscar", "Julia", "Oriol"};
            Console.WriteLine("Tenim aquest llistat de noms:");
            foreach (string i in ArrayNoms)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("Llistarem els noms que comencin per lletra 'O':");
            string[] ArrayNomsO = (from nom1 in ArrayNoms.Where(x => x.StartsWith("O")) select nom1).ToArray();
            foreach (string i in ArrayNomsO)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();
            Console.WriteLine("Llistarem els noms que tinguin més de 5 lletres:");
            string[] ArrayNoms5 = (from nom2 in ArrayNoms.Where(x => x.Length > 5 ) select nom2).ToArray();
            foreach (string i in ArrayNoms5)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();
            Console.WriteLine("Llistarem els noms en ordre descendent:");
            string[] ArrayNomsD = (from nom3 in ArrayNoms orderby nom3 descending select nom3).ToArray();
            foreach (string i in ArrayNomsD)
            {
                Console.WriteLine(i);
            }
        }
    }
}
