using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonClassLib
{
    public sealed class Logger:ILogger
    {

        private static readonly Lazy<Logger> log_ = new Lazy<Logger>(() => new Logger());

        public static Logger GetInstance
        {
            get
            {
                return log_.Value;
            }
        }

        public void Log(string message)
        {
            string fileName = string.Format("{0}_{1}.log", "Exception", DateTime.Now.ToString("dd-MMM-yyyy"));
            string logFilePath = string.Format(@"{0}\{1}",AppDomain.CurrentDomain.BaseDirectory,fileName);
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("-----------------------------------------");
            sb.AppendLine(DateTime.Now.ToString());
            sb.Append(message);
            using (StreamWriter wr = new StreamWriter(logFilePath, true))
            {
                wr.Write(sb.ToString());
                wr.Flush();
            }
        }
    } 
}
