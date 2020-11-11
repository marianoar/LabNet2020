using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Errores
{
    public class SaveLogsException : Exception
    {
        public SaveLogsException(string message, Exception innerException):base(message, innerException)
        {
            string txt = Txt;
            SaveLogs.Save(true, txt);
        }
        public SaveLogsException(string message) : base (message)
        {
            string txt = Txt;
            SaveLogs.Save(true, txt);
        }
        public SaveLogsException() : base()
        {
            string txt = Txt;
            SaveLogs.Save(true, txt);
        }
        public string Txt
        {
            get
            {
                StringBuilder sb = new StringBuilder();
                sb.Append(this.Message);
                sb.Append(" el ");
                sb.AppendLine(DateTime.Now.ToString() + " - ");
                Exception innerException = this.InnerException;
                while (innerException != null)
                {
                    sb.AppendLine(innerException.Message);
                    innerException = innerException.InnerException;
                }
                return sb.ToString();
            }
        }
    }
}
