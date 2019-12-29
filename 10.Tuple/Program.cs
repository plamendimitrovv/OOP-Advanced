using System;

namespace _10.Tuple
{
    public class Program
    {
        static void Main(string[] args)
        {

            string[] firstLastAdress = Console.ReadLine().Split();
            string firstName = firstLastAdress[0];
            string lastName = firstLastAdress[1];
            string address = firstLastAdress[2];
            string name = firstName + " " + lastName;

            var firstTuple = new Tuple<string, string>(name, address);
            Console.WriteLine(firstTuple);


            string[] secondLine = Console.ReadLine().Split();
            string nameSecondLine = secondLine[0];
            int amountOfBeer = int.Parse(secondLine[1]);

            var secondTuple = new Tuple<string, int>(nameSecondLine, amountOfBeer);
            Console.WriteLine(secondTuple);

            string[] thirdLine = Console.ReadLine().Split();
            int intThirdLine = int.Parse(thirdLine[0]);
            double doubleThirdLine = double.Parse(thirdLine[1]);

            var thirdTuple = new Tuple<int, double>(intThirdLine, doubleThirdLine);
            Console.WriteLine(thirdTuple);

        }
    }
}

