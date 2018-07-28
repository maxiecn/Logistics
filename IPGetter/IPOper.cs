using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;

namespace IPGetter
{
    public class IPOper
    {
        public static string GetIP()
        {
            String direction = "";
            WebRequest request = WebRequest.Create("http://1212.ip138.com/ic.asp");
            request.ContentType = "text/html; charset=gb2312";
            using (WebResponse response = request.GetResponse())
            using (StreamReader stream = new StreamReader(response.GetResponseStream()))
            {
                direction = stream.ReadToEnd();
            }

            int first = direction.IndexOf("[") + 1;
            int last = direction.IndexOf("]");
            string ip = direction.Substring(first, last - first);

            return ip;
              
        }

        public static void WriteToServer()
        {

            string Url = string.Format("http://www.thaiyuda.com:114/IP/set?ip={0}", GetIP());
            string postDataStr = string.Empty;
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(Url + (postDataStr == "" ? "" : "?") + postDataStr);
            request.Method = "GET";
            request.ContentType = "text/html;charset=UTF-8";

            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            Stream myResponseStream = response.GetResponseStream();
            StreamReader myStreamReader = new StreamReader(myResponseStream, Encoding.GetEncoding("utf-8"));
            string retString = myStreamReader.ReadToEnd();
            myStreamReader.Close();
            myResponseStream.Close();

            Console.WriteLine(retString);

        }
    }
}
