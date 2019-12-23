using System;
using System.Collections.Generic;

namespace _4.GenericSwapMethodIntegers
{
    public class Program
    {
        static void Main(string[] args)
        {

            int numberofLines = int.Parse(Console.ReadLine());

            var boxes = new List<Box<int>>();

            for (int i = 0; i < numberofLines; i++)
            {
                var box = new Box<int>(int.Parse(Console.ReadLine()));
                boxes.Add(box);
            }

            string[] swapIndexes = Console.ReadLine().Split();
            int firstIndex = int.Parse(swapIndexes[0]);
            int secondIndex = int.Parse(swapIndexes[1]);

            SwapIndexes(boxes, firstIndex, secondIndex);

            Console.WriteLine(String.Join(Environment.NewLine, boxes));
        }

        private static void SwapIndexes<T>(List<Box<T>> boxes, int firstIndex, int secondIndex)
        {
            Box<T> firstBox = boxes[firstIndex];
            boxes[firstIndex] = boxes[secondIndex];
            boxes[secondIndex] = firstBox;
        }




    }
}

