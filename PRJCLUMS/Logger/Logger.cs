using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace PRJCLUMS.Logger
{
    public static class Logger
    {
        public static string CurrentUser;

        public static void Log(string message) 
        {
            string LogPath = AppDomain.CurrentDomain.BaseDirectory;
            
            try
            {
                using (StreamWriter writer = new StreamWriter(LogPath + "\\log.txt", true, Encoding.ASCII))
                {
                    writer.WriteLine(string.Format("{0} -> {1}",DateTime.Now.ToString(),message));
                }
            }
            catch { }
        }
    }
}
