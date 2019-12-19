using Logger.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Logger.Models.LoggerModels
{
    public class Logger : ILogger
    {
        public void Critical(string date, string message)
        {
            throw new NotImplementedException();
        }

        public void Error(string date, string message)
        {
            throw new NotImplementedException();
        }

        public void Fatal(string date, string message)
        {
            throw new NotImplementedException();
        }

        public void Info(string date, string message)
        {
            throw new NotImplementedException();
        }

        public void Warn(string date, string message)
        {
            throw new NotImplementedException();
        }
    }
}
