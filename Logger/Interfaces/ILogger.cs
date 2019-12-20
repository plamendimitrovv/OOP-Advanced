﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Logger.Interfaces
{
    public interface ILogger
    {
        void Info(string date, string message);
        void Warn(string date, string message);
        void Error(string date, string message);
        void Critical(string date, string message);
        void Fatal(string date, string message);
    }
}
