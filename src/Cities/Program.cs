using System;
using System.Collections.Generic;
using Cities.Comparers;

namespace Cities
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<City> cities = CityDataImporter.LoadData();

            // TODO Swap out comparers as desired
            IComparer<City> comparerName = new NameComparer();
            IComparer<City> comparerState = new StateComparer();
            IComparer<City> comparerPopulation = new PopulationComparer();
            IComparer<City> comparerArea = new AreaComparer();

            cities.Sort(comparerName);
            PrintCities(cities);
            Console.ReadLine();

            Console.Clear();
            cities.Sort(comparerState);
            PrintCities(cities);
            Console.ReadLine();

            Console.Clear();
            cities.Sort(comparerPopulation);
            PrintCities(cities);
            Console.ReadLine();

            Console.Clear();
            cities.Sort(comparerArea);
            PrintCities(cities);
            Console.ReadLine();

            

            CompoundComparer comparer = new CompoundComparer();            
            comparer.Comparers.Add(new StateComparer());
            comparer.Comparers.Add(new NameComparer());
            //comparer.Comparers.Add(new PopulationComparer());
            comparer.Comparers.Add(new AreaComparer());

            Console.Clear();
            cities.Sort(comparer);
            PrintCities(cities);
            Console.ReadLine();





        }

        private static void PrintCities(List<City> cities)
        {
            Console.WriteLine(City.GetTableHeader());

            foreach (var city in cities)
            {
                Console.WriteLine(city);
            }

        }
    }
}
