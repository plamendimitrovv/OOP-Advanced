using Logger.Models.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Logger.Interfaces
{
    public interface ILayout
    {
        string Formatting(ReportLevel reportlevel, string date, string message);
    }
}
