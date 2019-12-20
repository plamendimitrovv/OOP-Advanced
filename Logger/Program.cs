using Logger.Engine;
using Logger.Factories;
using Logger.Interfaces;
using Logger.RWModels;
using System;

namespace Logger
{
    class Program
    {
        static void Main(string[] args)
        {

            var factoryAppender = new FactoryAppender();
            var factoryLayout = new FactoryLayout();

            IWriter consoleWriter = new ConsoleWriter();
            IReader consoleReader = new ConsoleReader();


            var controller = new Controller(factoryAppender, factoryLayout, consoleWriter, consoleReader);


        }
    }
}
