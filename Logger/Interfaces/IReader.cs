using System;
using System.Collections.Generic;
using System.Text;

namespace Logger.Interfaces
{
    public interface IReader
    {
        string WriteLine(string message);
        string Write(string message);
    }
}
