using Logger.Interfaces;
using Logger.Models.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Logger.Models.LoggerModels
{
    public class Logger : ILogger
    {
        private readonly IList<IAppender> appenders;

        public Logger(params IAppender[] appenders)
        {
            this.appenders = new List<IAppender> (appenders);
        }

        public IList<IAppender> GetAppenders()
        {
            return this.appenders; 
        }

        public void Critical(string date, string message)
        {
            this.Append(ReportLevel.CRITICAL, date, message);
        }

        public void Error(string date, string message)
        {
            this.Append(ReportLevel.ERROR, date, message);
        }

        public void Fatal(string date, string message)
        {
            this.Append(ReportLevel.FATAL, date, message);
        }

        public void Info(string date, string message)
        {
            this.Append(ReportLevel.INFO, date, message);
        }

        public void Warn(string date, string message)
        {
            this.Append(ReportLevel.WARNING, date, message);
        }

        private void Append(ReportLevel reportLevel, string date, string message)
        {
            foreach (var appender in this.appenders)
            {
                appender.Append(reportLevel, date, message); 
            }
        }
    }
}
