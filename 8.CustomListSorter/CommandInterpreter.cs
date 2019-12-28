using System;

namespace _8.CustomListSorter
{
    public class CommandInterpreter
    {
        private CustomList<string> list = new CustomList<string>();

        public void ParseCommand(string input)
        {
            var tokens = input.Split();
            var command = tokens[0];

            switch (command)
            {
                case "Add":
                    var element = tokens[1];
                    list.Add(element);
                    break;
                case "Remove":
                    var index = int.Parse(tokens[1]);
                    list.Remove(index);
                    break;
                case "Contains":
                    element = tokens[1];
                    Console.WriteLine(list.Compare(element));
                    break;
                case "Swap":
                    var firstElement = int.Parse(tokens[1]);
                    var secondElement = int.Parse(tokens[2]);
                    list.Swap(firstElement, secondElement);
                    break;
                case "Greater":
                    element = tokens[1];
                    Console.WriteLine(list.CounterGreaterThan(element));
                    break;
                case "Max":
                    Console.WriteLine(list.Max());
                    break;
                case "Min":
                    Console.WriteLine(list.Min());
                    break;
                case "Print":
                    list.Print();
                    break;
                case "Sort":
                    list = Sorter<string>.Sort(list);
                    break;

                default:
                    break;
            }

        }
    }
}