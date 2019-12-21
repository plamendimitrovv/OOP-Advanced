using _Logger.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace _Logger.RWModels
{
    public class ConsoleReader : IReader
    {
        public string Readline()
        {
            return Console.ReadLine();
        }
    }
}
