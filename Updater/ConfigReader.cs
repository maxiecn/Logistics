using System;

using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Reflection;

namespace AppBase
{
    public class ConfigReader
    {
        public static string oper = "";
        public static string OperID()
        {
            return oper;
        }

        public static string MobileID()
        {
            XMLHandler.TXmlConfigHandler config = new XMLHandler.TXmlConfigHandler(Path.GetDirectoryName(Assembly.GetExecutingAssembly().GetName().CodeBase) + @"\Config.xml");
            return config.ReadValue("EquipID");
        }
    }
}
