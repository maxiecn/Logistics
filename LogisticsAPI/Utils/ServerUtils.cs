using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Web;
using LogisticsAPI.Models;

namespace LogisticsAPI.Utils
{
    public class ServerUtils
    {
        //static string s = "0123456789abcdefghijklmnopqrstuvwxyz";
        private static string s = "0123456789";

        public static string MakePassword(){

            string password = "";

            long tick = DateTime.Now.Ticks;
            Random ra = new Random((int)(tick & 0xffffffffL) | (int)(tick >> 32));
            //for (int i = 0;i<4;i++){
            //    int position = ra.Next(s.Length - 1);
            //    password += s[position].ToString();
            //}
            password = ra.Next(9999).ToString();
            Thread.Sleep(1);
            return password;
        }

        public static string EncodeBill(Int32 billID)
        {
            int x = s.Length;
            string result = "";
            int leave = 0;
            while ((billID / x) != 0)
            {
                leave = billID % x;
                result = string.Format("{0}{1}", s[leave], result);
                billID = billID / x;
            }
            result = string.Format("{0}{1}", s[billID % x], result);
            return result;
        }

        public static Int32 DecodeBillID(string billID)
        {
            Int32 i = 0;
            for (int index = 0; index < billID.Length; index++)
            {
                int basecount = s.IndexOf(billID[index]);
                int sqr = (int)Math.Pow(36, (billID.Length - index - 1));
                Int32 resultNum = basecount * sqr;
                i += resultNum;
            }
            return i;
        }

        public static string SHA1Hash(string origin)
        {
            SHA1 sha1 = new SHA1CryptoServiceProvider();
            byte[] bytes_sha1_in = UTF8Encoding.Default.GetBytes(origin);
            byte[] bytes_sha1_out = sha1.ComputeHash(bytes_sha1_in);
            sha1.Clear();
            (sha1 as IDisposable).Dispose();
            return Convert.ToBase64String(bytes_sha1_out);
        }

        public static string getNewBillID(int stockID)
        {
            
            return "";
        }
    }
}