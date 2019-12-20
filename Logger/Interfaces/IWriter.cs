using System;
using System.Collections.Generic;
using System.Text;

namespace Logger.Interfaces
{
    public interface IWriter
    {
        void WriteLine(string message);
        void Write(string message);
    }
}
