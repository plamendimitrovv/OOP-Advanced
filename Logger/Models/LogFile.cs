using System;
using System.Collections.Generic;
using System.Text;

namespace Logger.Models
{
    public class LogFile
    {
        private StringBuilder sb;

        public LogFile()
        {
            this.sb = new StringBuilder();
        }

        public int Size { get; set; }


        public void Write(string formattedMessage)
        {
            this.sb.AppendLine(formattedMessage);

            foreach (var character in formattedMessage)
            {
                if (char.IsLetter(character))
                {
                    Size += character;
                }
            }

        }

    }
}
