namespace XMLHandler
{
    using System;
    using System.Xml;

    public class TXmlConfigHandler
    {
        private string m_filepath;
        private XmlDocument xmldoc;

        public TXmlConfigHandler(string filepath)
        {
            this.m_filepath = filepath;
            this.xmldoc = new XmlDocument();
            this.xmldoc.Load(filepath);
        }

        public string ReadValue(string key)
        {
            string innerText;
            try
            {
                if (this.xmldoc == null)
                {
                    throw new Exception("Read system config file error!");
                }
                innerText = this.xmldoc.SelectSingleNode("//Item[@Key='" + key + "']").InnerText;
            }
            catch (Exception exception)
            {
                throw new Exception("Error009" + exception.Message);
            }
            return innerText;
        }

        public bool WriteValue(string key, string value)
        {
            bool flag;
            try
            {
                if (this.xmldoc != null)
                {
                    this.xmldoc.SelectSingleNode("//Item[@Key='" + key + "']").InnerText = value;
                    this.xmldoc.Save(this.FilePath);
                    return true;
                }
                flag = false;
            }
            catch (Exception exception)
            {
                throw exception;
            }
            return flag;
        }

        public string FilePath
        {
            get
            {
                return this.m_filepath;
            }
        }
    }
}

