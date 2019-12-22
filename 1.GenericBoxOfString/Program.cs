using System;

namespace _1.GenericBoxOfString
{
    public class Program
    {
        static void Main(string[] args)
        {
            int numberofLines = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberofLines; i++)
            {
                var box = new Box<string>(Console.ReadLine());
                Console.WriteLine(box);
            }
        }
    }
}
