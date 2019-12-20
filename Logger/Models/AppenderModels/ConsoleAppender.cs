using Logger.Interfaces;
using Logger.Models.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Logger.Models.AppenderModels
{
    public class ConsoleAppender : IAppender
    {

        private ILayout layout;
        private int messageCount;
        private IWriter writer;

        public ConsoleAppender(ILayout layout, IWriter writer)
        {
            this.layout = layout;
            this.writer = writer;
        }

        public ReportLevel LevelOfThreshold { get; set; }

        public void Append(ReportLevel reportLevel, string date, string message)
        {
            if (this.LevelOfThreshold <= reportLevel)
            {
                var formattedMessage = this.layout.Formatting(reportLevel, date, message);
                writer.WriteLine(formattedMessage); 
                this.messageCount++;
            }
        }

        public override string ToString()
        {
            return $"Appender type: {this.GetType().Name}, Layout type: {this.layout.GetType().Name}, Report level: {this.LevelOfThreshold}, Messages appended: {this.messageCount}";
        }
    }
}
