using System;

namespace _11.Threeuple
{
    class Program
    {
        public static void Main(string[] args)
        {
            string[] firstLastAdress = Console.ReadLine().Split();
            string firstName = firstLastAdress[0];
            string lastName = firstLastAdress[1];
            string address = firstLastAdress[2];
            string town = firstLastAdress[3];
            string name = firstName + " " + lastName;

            var firstTuple = new Threeuple<string, string, string>(name, address, town);
            Console.WriteLine(firstTuple);


            string[] secondLine = Console.ReadLine().Split();
            string nameSecondLine = secondLine[0];
            int amountOfBeer = int.Parse(secondLine[1]);
            string drunkOrNot = secondLine[2];

            bool isDrunk = drunkOrNot == "drunk";

            var secondTuple = new Threeuple<string, int, bool>(nameSecondLine, amountOfBeer, isDrunk);
            Console.WriteLine(secondTuple);

            string[] thirdLine = Console.ReadLine().Split();
            string nameThirdLine = thirdLine[0];
            double accountBalance = double.Parse(thirdLine[1]);
            string bank = thirdLine[2];

            var thirdTuple = new Threeuple<string, double, string>(nameThirdLine, accountBalance, bank);
            Console.WriteLine(thirdTuple);
        }
    }
}
