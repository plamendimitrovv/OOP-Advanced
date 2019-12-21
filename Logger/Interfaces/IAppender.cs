using _Logger.Models.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace _Logger.Interfaces
{
   public interface IAppender
    {
        void Append(ReportLevel reportLevel, string date, string message);

        ReportLevel LevelOfThreshold { get; set; }
    }
}
