using _Logger.Interfaces;
using _Logger.Models.AppenderModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace _Logger.Factories
{
    public class FactoryAppender
    {
        public IAppender Create(string type, ILayout layout, IWriter writer)
        {
            if (type == "ConsoleAppender")
            {
                return new ConsoleAppender(layout, writer);
            }

            else if (type == "FileAppender")
            {
                return new FileAppender(layout); 
            }

            throw new ArgumentException("Invalid type of Appender!"); 
        }
    }
}
