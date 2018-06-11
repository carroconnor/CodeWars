using System;
using System.Collections.Generic;
using System.Linq;

namespace Museum
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();
            for (int i = 0; i < 10; i++)
            {
                numbers.Add(i + 1);
            }

            RemoveSmallest(numbers);
            Console.ReadLine();
        }

        public static List<int> RemoveSmallest(List<int> numbers)
        {
            var indexNumber = new int();
            var lowestNumber = new int();
            var newList = new List<int>();
            var currentNumber = new int();

            for (int i = 0; i < numbers.Count; i++)
            {
                currentNumber = numbers.ElementAt(i);

                if (currentNumber < lowestNumber && currentNumber != lowestNumber)
                {
                    lowestNumber = currentNumber;
                    indexNumber = i;
                }
            }

            numbers.Remove(lowestNumber);
            foreach (var item in numbers)
            {
                Console.WriteLine(item);
            }

            return numbers;
        }
    }
}

