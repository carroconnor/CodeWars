using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListFiltering
{
    class Program
    {
        static void Main(string[] args)
        {
            List<object> listOfItems = new List<object>() { 1, 2, "a", "b" };
            List<object> list2 = new List<object>() { 1, 2, "a", "b", 0, 15 };
            List<object> list3 = new List<object>() { 1, 2, "a", "b", "aasf", "1", "123", 231 };

            GetIntegersFromList(listOfItems);
            Console.ReadLine();
        }

        public static IEnumerable<int> GetIntegersFromList(List<object> listOfItems)
        {
            var newListOfItems = listOfItems.OfType<int>().ToList();

            foreach (var item in newListOfItems)
            {
                Console.WriteLine(item);
            }
            return newListOfItems;
        }
    }
}
