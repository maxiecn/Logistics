using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace LogisticsClient.AppUtils
{
    public class Configure
    {
        public static int UserID = 1;
        public static string UserName = "测试账号";
        public static List<string> Functions = new List<string>();

        public static int StoreID = -1;

        private static Configure m_configure;
        private Configure()
        {
        }

        public static Configure configure()
        {
            if (m_configure==null)
            {
                m_configure = new Configure();
                if (!File.Exists(Environment.CurrentDirectory  + @"\config"))
                {
                    FileStream fs = File.Create(Environment.CurrentDirectory + @"\config");
                    fs.Close();
                }
            }
            return m_configure;
        }

        public void save(string key,string value)
        {
            StringBuilder sb = new StringBuilder();
            using (StreamReader sr = new StreamReader(Environment.CurrentDirectory + @"\config",
                Encoding.Default))
            {
                String line;
                bool haskey = false;
                while ((line = sr.ReadLine()) != null)
                {
                    string[] kv = line.Split(new string[] {" = "}, StringSplitOptions.None);
                    if (kv[0].Equals(key))
                    {
                        sb.AppendLine(kv[0] + " = " + value);
                        haskey = true;
                    }
                    else
                    {
                        sb.AppendLine(line);
                    }
                }
                if (!haskey)
                    sb.AppendLine(key + " = " + value);
                sr.Close();
            }
            using (FileStream fs = new FileStream(Environment.CurrentDirectory + @"\config", FileMode.OpenOrCreate))
            {
                StreamWriter sw = new StreamWriter(fs);
                //开始写入
                sw.Write(sb.ToString());
                //清空缓冲区
                sw.Flush();
                //关闭流
                sw.Close();
                fs.Close();
            }
        }

        public string load(string key)
        {
            StreamReader sr = new StreamReader(Environment.CurrentDirectory + @"\config",
                    Encoding.Default);
            String line;
            while ((line = sr.ReadLine()) != null)
            {
                string[] kv = line.Split(new string[] { " = " }, StringSplitOptions.None);
                if (kv[0].Equals(key))
                    return kv[1];
            }
            sr.Close();
            return string.Empty;
        }
    }
}
