using System;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Xml;
using System.Windows.Forms;
using System.Net.Http;
using Newtonsoft.Json;

namespace UpdateFile
{
    public class TUpdate
    {
        string serverAddress = "";
        private string port = "8011";
        //private string port = "114";

        public TUpdate()
        {
            serverAddress = GetServerAddress();
        }

        private string GetServerAddress()
        {
            return HttpService.GetServerAddr();
            //return "www.thaiyuda.com";
        }

        public void UpdateFiles()
        {
            string fileName = @".\UpdateXML.xml";
            if (!File.Exists(fileName)){
                Console.WriteLine("升级文件未找到:" + fileName);
                return;
            }
            try
            {
                XmlDocument xd = new XmlDocument();
                xd.Load(functions.path() + @"\UpdateXML.xml");XmlElement FilesNode = xd.DocumentElement;  //创建根节点

                foreach (XmlNode fileNodeChild in FilesNode.ChildNodes)
                {
                    try
                    {
                        if (fileNodeChild.Name == "Files")
                        {
                            foreach (XmlNode dllChildNode in fileNodeChild.ChildNodes)
                            {
                                string NewVersion = "0";
                                using (var client = new HttpClient())
                                {
                                    var result = client.GetAsync(new Uri(
                                        string.Format("http://{0}:{1}/file/version?_filename={2}",this.serverAddress,port,dllChildNode.Name),
                                        UriKind.Absolute))
                                        .Result.Content.ReadAsStringAsync()
                                        .Result;
                                    NewVersion = result;}
                                

                                //如果网络上没这个文件 就不管
                                if (NewVersion.Equals("0"))
                                {
                                    Warning("服务器找不到文件:" + dllChildNode.Name);
                                    continue;
                                }

                                if (!NewVersion.Equals(dllChildNode.FirstChild.Value.Trim()))
                                {
                                    string serverUrl = string.Format("http://{0}:{1}/update/{2}",serverAddress,port,dllChildNode.Name);
                                    UpdateDll(@".\" + dllChildNode.Name, serverUrl);
                                    dllChildNode.FirstChild.InnerText = NewVersion;
                                    xd.Save(@".\UpdateXML.xml");
                                    Warning("更新" + dllChildNode.Name + "至版本" + NewVersion);
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        //_serverUrl为http://xxx.xx/xx.dll形式
        //_localFile为\\Program File\xx.dll形式 PS:终端路径
        private void UpdateDll(string _localFile, string _serverUrl)
        {
            File.Delete(_localFile);
            //新建文件
            System.IO.FileStream fs = new System.IO.FileStream(_localFile, System.IO.FileMode.Create);
            //打开网络连接
            try
            {
                Console.WriteLine(_serverUrl);
                System.Net.HttpWebRequest request = (System.Net.HttpWebRequest)System.Net.HttpWebRequest.Create(_serverUrl);

                //向服务器请求，获得服务器回应数据流                
                System.IO.Stream ns = request.GetResponse().GetResponseStream();
                byte[] nbytes = new byte[512];
                int ReadSize = 0;
                ReadSize = ns.Read(nbytes, 0, 512);
                while (ReadSize > 0)
                {
                    fs.Write(nbytes, 0, ReadSize);
                    ReadSize = ns.Read(nbytes, 0, 512);
                }
                fs.Close();
                ns.Close();
                //更新完成
            }
            catch (Exception ex)
            {
                fs.Close();
                Console.WriteLine("下载[" + _localFile + "]出错:" + ex.Message);
                Console.WriteLine("网络地址:" + _serverUrl);
                //抛出错误
            }
        }

        private void Warning(string warningStr)
        {
            Console.WriteLine(warningStr);
        }
        public void StartPro()
        {
            ProcessStartInfo startInfo = new ProcessStartInfo(functions.path() + @"\LogisticsClient.exe", "");
            Process.Start(startInfo);
            Application.Exit();
        }
    }

    /// <summary>
    /// 不能用BaseDevice里的 因为先升级 这样就可以支持BaseDevice的升级了 O(∩_∩)O~~
    /// </summary>
    internal class functions
    {
        public static string path()
        {
            string result = Path.GetDirectoryName( Assembly.GetExecutingAssembly().GetName().CodeBase );
            return result;}
    }

    public class HttpService 
    {
        public static string GetServerAddr()
        {
            //return "www.thaiyuda.com:114";
            using (var client = new HttpClient())
            {
                var result = client.GetAsync(new Uri(
                    "http://www.thaiyuda.com:114/IP/get",
                    UriKind.Absolute))
                    .Result.Content.ReadAsStringAsync()
                    .Result;
                //var resultInfo = JsonDeserialize<string>(result);
                return result;
            }
        }

        public static T JsonDeserialize<T>(string jsonString)
        {
            var list = (T)JsonConvert.DeserializeObject(jsonString, typeof(T));
            return list;
        }
    }

}
