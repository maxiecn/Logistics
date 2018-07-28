using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Management;
using System.Net.NetworkInformation;
using System.Security.Cryptography;
using System.Text;
using EMS.DAL;

namespace LogisticsClient.AppUtils
{
    public class Crypt
    {
        private static string GetCpuId()
        {
            ManagementClass mc = new ManagementClass("Win32_Processor");
            ManagementObjectCollection moc = mc.GetInstances();
            string strCpuId = String.Empty;
            foreach (ManagementObject mo in moc)
            {
                strCpuId = mo.Properties["ProcessorId"].Value.ToString();
                break;
            }
            return strCpuId;
        }

        private static string GetMainHardDiskId()
        {
            string str = String.Empty;
            ManagementClass mcHD = new ManagementClass("win32_logicaldisk");
            ManagementObjectCollection mocHD = mcHD.GetInstances();
            foreach (ManagementObject m in mocHD)
            {
                if (m["DeviceID"].ToString() == "C:")
                {
                    str = m["VolumeSerialNumber"].ToString();
                    break;
                }
            }
            return str;
        }

        private static string GetNetWorkAdapterId()
        {
            string str = String.Empty;
            NetworkInterface[] adapters = NetworkInterface.GetAllNetworkInterfaces();
            if (adapters.Length > 0)
            {
                return adapters[0].GetPhysicalAddress().ToString();
            }
            else
            {
                return str;
            }
        }

        public static string GetRegInfo()
        {
            return GetCpuId() + GetMainHardDiskId() + GetNetWorkAdapterId();
        }

        public static bool HasRegister()
        {
            return CheckRegInfo(ConfigurationManager.AppSettings["pass"]);
        }

        public static bool SetRegInfo(string p)
        {
            if (CheckRegInfo(p))
            {
                //注册成功
                Configuration config =
                    System.Configuration.ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                config.AppSettings.Settings["pass"].Value = p;
                config.Save(ConfigurationSaveMode.Modified);
                return true;
            }
            else
            {
                return false;
            }
        }

        private static bool CheckRegInfo(string reg)
        {
            return CMD5Utility.MDString(CMD5Utility.MDString(GetRegInfo() + "HAN")).Equals(reg);
        }
    }
}
