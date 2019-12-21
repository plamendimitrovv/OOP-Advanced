using _Logger.Engine;
using _Logger.Factories;
using _Logger.Interfaces;
using _Logger.RWModels;
using System;

namespace _Logger
{
    public class Program
    {
        static void Main(string[] args)
        {

            var factoryAppender = new FactoryAppender();
            var factoryLayout = new FactoryLayout();

            IWriter consoleWriter = new ConsoleWriter();
            IReader consoleReader = new ConsoleReader();


            var controller = new Controller(factoryAppender, factoryLayout, consoleWriter, consoleReader);

            controller.Run();
        }
    }
}
