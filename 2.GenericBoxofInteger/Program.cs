
using _2.GenericBoxOfInteger;
using System;

namespace _2.GenericBoxofInteger
{
   public class Program
    {
        static void Main(string[] args)
        {

            int numberofLines = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberofLines; i++)
            {
                var box = new Box<int>(int.Parse(Console.ReadLine()));
                Console.WriteLine(box);
            }

        }
    }
}
