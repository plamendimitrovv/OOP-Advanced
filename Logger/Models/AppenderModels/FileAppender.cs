using Logger.Interfaces;
using Logger.Models.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Logger.Models.AppenderModels
{
    public class FileAppender : IAppender
    {
        private readonly ILayout layout;
        private LogFile logfile; 
        public ReportLevel LevelOfThreshold { get; set; }

        public void Append(ReportLevel reportLevel, string date, string message)
        {
           
        }
    }
}
