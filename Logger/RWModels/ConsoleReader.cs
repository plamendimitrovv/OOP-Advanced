using Logger.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Logger.RWModels
{
    public class ConsoleReader : IReader
    {
        public string Readline()
        {
            return Console.ReadLine();
        }
    }
}
