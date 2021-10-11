using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace postnumre_csv
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] linesInCsv = File.ReadAllLines("danske-postnumre-byer-ny.csv");

            var cities = new List<City>();

  
           for(int i = 1; i < linesInCsv.Length; i++)
           {
               City city = new City(linesInCsv[i]);
               cities.Add(city);

           }

            do
            {

                Console.Write("Indtast dit postnummer: ");
                string input = Console.ReadLine();

                var match = cities.FirstOrDefault(c => c.Postnummer == input);
     
                if (match == null)
                {
                    Console.WriteLine("Intet fundet...");
                    
                }
                else
                {
                    Console.WriteLine(match);
                }

            } while (Console.ReadKey().KeyChar != 'x');

        }
    }
}
