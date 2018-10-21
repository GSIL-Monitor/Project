using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.IO;

namespace HydraMoniter
{
   public class Log
    {

        /// <summary>
        /// 写入日志
        /// </summary>
        /// <param name="s"></param>
       public static void Write(string s)
        {
            try
            {
                string folder = ConfigurationManager.AppSettings["log"];
                if (!System.IO.Directory.Exists(folder) && null == System.IO.Directory.CreateDirectory(folder))
                    return;
                string fileName = string.Format("{0}.log", DateTime.Today.ToString("yyyy_MM_dd"));
                string filePath = System.IO.Path.Combine(folder, fileName);
                FileStream fileStream = new FileStream(filePath, FileMode.Append, FileAccess.Write);
                StreamWriter streamWriter = new StreamWriter(fileStream);
                streamWriter.WriteLine(string.Format("{0} -- {1}", DateTime.Now.ToString("HH:mm:ss"), s));
                streamWriter.Close();
                fileStream.Close();
            }
            catch { }
        }

    }
}
