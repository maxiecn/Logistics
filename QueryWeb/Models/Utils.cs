using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using LogisticsAPI.Models;
using LogisticsClient.AppUtils;
using Model.DefaultModels;
using XMLHandler;
using System.Web;

namespace Utils
{
    public class WebCall
    {
        public static string BaseUrl = "http://localhost:8111/";
        public static string BaseApiUrl = "http://localhost:8111/api/";
        //public static string BaseUrl = "http://localhost:12390/";
        //public static string BaseApiUrl = "http://localhost:12390/api/";
        //public static string BaseUrl = "http://192.168.1.19:8011/";
        //public static string BaseApiUrl = "http://192.168.1.19:8011/api/";
        public static T GetMethod<T>(string methodName, List<KeyValuePair<string, string>> paramlist)
        {
            LoadUrl();
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
                    param.Append(paramlist[index].Value);
                }
            }
            using (var client = new HttpClient())
            {
                var result = client.GetAsync(new Uri(
                    BaseUrl + methodName + param,
                    UriKind.Absolute))
                    .Result.Content.ReadAsStringAsync()
                    .Result;
                var resultInfo = AppUtils.JsonDeserialize<T>(result);
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

        public static void LoadUrl()
        {
            using (var client = new HttpClient())
            {
                TXmlConfigHandler xml = new TXmlConfigHandler(HttpRuntime.AppDomainAppPath + "/ip.xml");
                String ipAddr = xml.ReadValue("IP");
                //using (var db = new LogisticsContext())
                //{
                    //T_IP ipInfo = db.T_IP.Where(a => a.ipkey.Equals("thaiyuda")).FirstOrDefault();
                    BaseUrl = string.Format("http://{0}:8011/", ipAddr);
                    BaseApiUrl = string.Format("http://{0}:8011/api/", ipAddr);
                //}
            }
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