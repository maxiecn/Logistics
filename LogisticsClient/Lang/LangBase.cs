using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace LogisticsClient.Lang
{
    public class LangBase
    {
        private static LangBase language;

        private Dictionary<string, string> stringResources;

        private LangBase(string resourceFile)
        {
            StreamReader sr = new StreamReader(Environment.CurrentDirectory + "\\Lang\\" + resourceFile,
                Encoding.Default);
            String line;
            stringResources = new Dictionary<string, string>();
            while ((line = sr.ReadLine()) != null)
            {
                string[] kv = line.Split(new string[] {" = "}, StringSplitOptions.None);
                stringResources.Add(kv[0], kv[1]);
            }
        }

        private static LangBase getResource()
        {
            if (language == null)
                language = new LangBase("zh-CN.txt");
            return language;
        }

        public static string GetString(string resourceName)
        {
            string value = string.Empty;
            if (getResource().stringResources.TryGetValue(resourceName,out value))
            {
                return value;
            }
            else
            {
                return string.Empty;
            }
        }
    }
}