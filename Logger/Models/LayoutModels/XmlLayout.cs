using Logger.Interfaces;
using Logger.Models.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Logger.Models.LayoutModels
{
    public class XmlLayout : ILayout
    {
        public string Formatting(ReportLevel reportlevel, string date, string message)
        {
            var sb = new StringBuilder();
            sb.AppendLine("<log>");
            sb.AppendLine($"    <date>{date}</date>");
            sb.AppendLine($"    <level>{reportlevel.ToString().ToUpper()}</level>");
            sb.AppendLine($"    <message>{message}</message>");
            sb.AppendLine("</log>");

            return sb.ToString().Trim();
        }
    }
}
