using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.DBSource
{
     public class Logger
    {
        public static void WriteLog(Exception ex)
        {
            string path = "D:\\Log\\log.txt";
            System.IO.File.AppendAllText(path, ex.ToString()
                + System.Environment.NewLine + System.Environment.NewLine);
        }
    }
}
