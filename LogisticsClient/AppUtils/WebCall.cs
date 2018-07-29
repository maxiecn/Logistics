using Model;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;

namespace LogisticsClient.AppUtils
{
    public class WebCall
    {
        public static string BaseUrl = "http://localhost:8011/";
        public static string BaseApiUrl = "http://localhost:8011/api/";
        //public static string BaseUrl = "http://localhost:12390/";
        //public static string BaseApiUrl = "http://localhost:12390/api/";
        //public static string BaseUrl = "http://www.thaiyuda.com:114/";
        //public static string BaseApiUrl = "http://www.thaiyuda.com:114/api/";
        public static T GetMethod<T>(string methodName, List<KeyValuePair<string, string>> paramlist)
        {
            var param = new StringBuilder();
            if (null != paramlist)
            {
                for (var index = 0; index < paramlist.Count; index++)
                {
                    if (index == 0)
                    {
                        param.Append("?");
                    }
                    else
                    {
                        param.Append("&");
                    }
                    param.Append(paramlist[index].Key);
                    param.Append("=");
                    param.Append(paramlist[index].Value);}
            }
            using (var client = new HttpClient())
            {
                var result = client.GetAsync(new Uri(
                    BaseUrl + methodName + param,
                    UriKind.Absolute))
                    .Result.Content.ReadAsStringAsync()
                    .Result;var resultInfo = AppUtils.JsonDeserialize<T>(result);
                return resultInfo;
            }
        }
        public static string PostMethod<T>(string methodName, T param)
        {
            var requestJson = AppUtils.JsonSerializer(param);
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(BaseUrl);
                HttpContent httpContent =
                    new StringContent(requestJson);
                httpContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");
                var result =
                    client.PostAsync(methodName, httpContent).Result.Content.ReadAsStringAsync().Result;
                return result;
            }
        }

        public static string UploadFile(string fileName)
        {
            WebClient myWebClient = new WebClient();
            byte[] buffer = myWebClient.UploadFile(WebCall.BaseUrl + "File/Upload", "POST", fileName);
            var msg = Encoding.UTF8.GetString(buffer);
            return msg;
        }

        public static void LoadUrl()
        {
            //Configuration config = System.Configuration.ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            //string ip = config.AppSettings.Settings["url"].Value;
            //BaseUrl = string.Format("http://{0}:8011/", ip);
            //BaseApiUrl = string.Format("http://{0}:8011/api/", ip);
        }

        public static Stream GetPic(string url)
        {
            Stream mStream;
            try
            {
                Uri mUri = new Uri(WebCall.BaseUrl + SystemConst.PIC_PATH + url);
                HttpWebRequest mRequest = (HttpWebRequest)WebRequest.Create(mUri);
                mRequest.Method = "GET";
                mRequest.Timeout = 200;
                mRequest.ContentType = "text/html;charset=utf-8";
                HttpWebResponse mResponse = (HttpWebResponse)mRequest.GetResponse();
                mStream = mResponse.GetResponseStream();
            }
            catch
            {
                return null;
            }
            return mStream;
        }
    }

    public class IP
    {
        public string IPAddr
        {
            get;
            set;
        }
    }
}