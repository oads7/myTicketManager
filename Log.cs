using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myTicketManager
{
    static class Log
    {
        private static StreamWriter output;

        public static void Init(string logFileName)
        {
            output = File.AppendText(logFileName);
        }

        public static void Write(string Message)
        {
            string token = "[" + DateTime.Now.ToString("dd/MM/yyyy - hh:mm:ss tt") + "] - " + Message;

            output.WriteLine(token);
            output.Flush();
            output.Flush();
        }

        public static void WriteException(Exception ex)
        {
            Write("Error - [" + ex.Source + "] " + ex.Message);
        }

        public static void Close()
        {
            output.Close();
        }
    }
}
