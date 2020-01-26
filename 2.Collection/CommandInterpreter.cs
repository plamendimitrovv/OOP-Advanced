using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _2.Collection
{
    public class CommandInterpreter
    {
        private bool isRunning;
        private ListyIterator<string> listyIterator;

        public CommandInterpreter()
        {
            this.isRunning = true;

        }

        public void Run()
        {
            while (isRunning)
            {
                var lineArgs = Console.ReadLine().Split();
                var command = lineArgs[0];

                try
                {
                    ExecuteCommand(lineArgs, command);
                }
                catch (Exception ex)
                {

                    Console.WriteLine(ex.Message);
                }
            }

        }


        private void ExecuteCommand(string[] lineArgs, string command)
        {
            switch (command)
            {
                case "Create":
                    this.listyIterator = new ListyIterator<string>(lineArgs.Skip(1).ToArray());
                    break;
                case "Move":
                    Console.WriteLine(this.listyIterator.Move());
                    break;
                case "HasNext":
                    Console.WriteLine(this.listyIterator.HasNext());
                    break;
                case "Print":
                    this.listyIterator.Print();
                    break;

                case "PrintAll":
                    this.listyIterator.PrintAll();
                    break;

                case "END":
                    this.isRunning = false;
                    break;

                
            }

        }
    }
}
