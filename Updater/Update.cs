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
                Console.WriteLine("�����ļ�δ�ҵ�:" + fileName);
                return;
            }
            try
            {
                XmlDocument xd = new XmlDocument();
                xd.Load(functions.path() + @"\UpdateXML.xml");XmlElement FilesNode = xd.DocumentElement;  //�������ڵ�

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
                                

                                //���������û����ļ� �Ͳ���
                                if (NewVersion.Equals("0"))
                                {
                                    Warning("�������Ҳ����ļ�:" + dllChildNode.Name);
                                    continue;
                                }

                                if (!NewVersion.Equals(dllChildNode.FirstChild.Value.Trim()))
                                {
                                    string serverUrl = string.Format("http://{0}:{1}/update/{2}",serverAddress,port,dllChildNode.Name);
                                    UpdateDll(@".\" + dllChildNode.Name, serverUrl);
                                    dllChildNode.FirstChild.InnerText = NewVersion;
                                    xd.Save(@".\UpdateXML.xml");
                                    Warning("����" + dllChildNode.Name + "���汾" + NewVersion);
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

        //_serverUrlΪhttp://xxx.xx/xx.dll��ʽ
        //_localFileΪ\\Program File\xx.dll��ʽ PS:�ն�·��
        private void UpdateDll(string _localFile, string _serverUrl)
        {
            File.Delete(_localFile);
            //�½��ļ�
            System.IO.FileStream fs = new System.IO.FileStream(_localFile, System.IO.FileMode.Create);
            //����������
            try
            {
                Console.WriteLine(_serverUrl);
                System.Net.HttpWebRequest request = (System.Net.HttpWebRequest)System.Net.HttpWebRequest.Create(_serverUrl);

                //����������󣬻�÷�������Ӧ������                
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
                //�������
            }
            catch (Exception ex)
            {
                fs.Close();
                Console.WriteLine("����[" + _localFile + "]����:" + ex.Message);
                Console.WriteLine("�����ַ:" + _serverUrl);
                //�׳�����
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
    /// ������BaseDevice��� ��Ϊ������ �����Ϳ���֧��BaseDevice�������� O(��_��)O~~
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
