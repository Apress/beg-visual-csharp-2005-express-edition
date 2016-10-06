using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using System.Net;

namespace XMLLister
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void getXML_Click(object sender, EventArgs e)
        {
            xmlList.Items.Clear();
            
            string xml = new WebClient().DownloadString(
                "http://blogs.apress.com/wp-rss2.php");

            XmlDocument doc = new XmlDocument();
            doc.LoadXml(xml);

            ProcessNodes(doc.ChildNodes);
        }

        private void ProcessNodes(XmlNodeList nodes)
        {
            foreach (XmlNode node in nodes)
            {
                xmlList.Items.Add(string.Format("{0} - {1} - {2}",
                    node.GetType().Name, node.Name,node.Value));

                if (node.HasChildNodes)
                    ProcessNodes(node.ChildNodes);
            }
        }
    }
}