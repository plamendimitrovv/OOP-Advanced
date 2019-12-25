using _5.GenericCountMethodStrings;
using System;
using System.Collections.Generic;
using System.Linq;

namespace _5.GenericCountMethodStirngs
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberofLines = int.Parse(Console.ReadLine());

            var boxes = new List<Box<string>>();

            for (int i = 0; i < numberofLines; i++)
            {
                var box = new Box<string>(Console.ReadLine());
                boxes.Add(box);
            }

            var elementToCompare = Console.ReadLine();

            var count = GetCountOfGreaterElements(boxes, elementToCompare);
            Console.WriteLine(count);
            // Console.WriteLine(String.Join(Environment.NewLine, boxes));
        }

        private static int GetCountOfGreaterElements<T>(List<Box<T>> boxes, T elementToCompare)
            where T : IComparable<T>
        {
            var count = boxes.Count(el => el.Value.CompareTo(elementToCompare) > 0);

            return count;
        }
    }
}

