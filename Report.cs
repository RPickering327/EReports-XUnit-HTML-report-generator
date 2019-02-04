using System.Xml;

namespace Ewart.UI.Tests.EwartReport
{
    public class Report
    {


        public string XmlReport { get; set; }

        public string post_title = "";

        public string post_status = "";





        public void GenerateReport()
        {
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load("D:\\Desktop\\Ewart.UI.Tests\\TestResults\\TestResults.xml");

            XmlNodeList nodeList = xmlDoc.GetElementsByTagName("collection");

            foreach (XmlNode node in nodeList)
            {
                post_title = node.ChildNodes[2].InnerText;
                post_status = node.ChildNodes[3].InnerText;
            }

        }






    }
}
