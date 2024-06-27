using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace TestTask.Logs
{
    public static class LogControl
    {
        private static string LogPath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + "\\" + "log.txt";
        public static void WriteLog(string logMessage)
        {
            try
            {
                FileInfo logFileInfo = new FileInfo(LogPath);
                DirectoryInfo logDirInfo = new DirectoryInfo(logFileInfo.DirectoryName);
                if (!logDirInfo.Exists)
                    logDirInfo.Create();
                using (FileStream fileStream = new FileStream(LogPath, FileMode.Append))
                {
                    using (StreamWriter log = new StreamWriter(fileStream))
                    {
                        log.WriteLine(logMessage);
                    }
                }
            }
            catch (Exception ex)
            {
            }
        }
    }
}
