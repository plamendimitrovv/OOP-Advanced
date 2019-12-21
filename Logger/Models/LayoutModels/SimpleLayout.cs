using _Logger.Interfaces;
using _Logger.Models.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace _Logger.Models.LayoutModels
{
    public class SimpleLayout : ILayout
    {
        public string Formatting(ReportLevel reportlevel, string date, string message)
        {
            return $"{date} - {reportlevel.ToString().ToUpper()} - {message}";
        }
    }
}
