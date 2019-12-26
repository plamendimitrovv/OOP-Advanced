using System;

namespace _7.CustomList
{
    public class Program
    {
        static void Main(string[] args)
        {
            var interpreter = new CommandInterpreter();
            string input;
            while ((input = Console.ReadLine()) != "END")
            {
                interpreter.ParseCommand(input);
            }

        }
    }
}
 