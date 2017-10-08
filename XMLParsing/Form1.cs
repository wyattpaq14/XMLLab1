using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using System.IO;

namespace XMLParsing
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }








        private void btnGetContacts(object sender, EventArgs e)
        {
            string strFilename = Application.StartupPath + "\\ContactsManager.xml";
            StringBuilder results = new StringBuilder();
            XmlDocument xmlDoc = new XmlDocument();


            xmlDoc.Load(strFilename);

            XmlElement xelRoot = xmlDoc.DocumentElement;
            XmlNodeList xnlNodes = xelRoot.SelectNodes("/ContactsManager/Contact");

            foreach (XmlNode xndNode in xnlNodes)
            {
                results.AppendLine("First Name: " + xndNode["FirstName"].InnerText);
                results.AppendLine("Last Name: " + xndNode["LastName"].InnerText);
                results.AppendLine("Phone: " + xndNode["Phone"].InnerText);
                results.AppendLine("Fax: " + xndNode["Fax"].InnerText);
                results.AppendLine("Email: " + xndNode["Email"].InnerText);
                results.AppendLine(" ");
            }

            txtResults.Text = results.ToString();

        }


        private void btnGetVersionInfo(object sender, EventArgs e)
        {
            string strFilename = Application.StartupPath + "\\ContactsManager.xml";
            StringBuilder results = new StringBuilder();
            XmlDocument xmlDoc = new XmlDocument();

            xmlDoc.Load(strFilename);

            XmlElement xelRoot = xmlDoc.DocumentElement;
            XmlNode xnlNodeVDate = xelRoot.SelectSingleNode("/ContactsManager/VersionDate");
            XmlNode xnlNodeVNum = xelRoot.SelectSingleNode("/ContactsManager/VersionNumber");


            results.AppendLine("Version Date: " + xnlNodeVDate.InnerText);

            results.AppendLine(" ");
            results.AppendLine("Version Number: " + xnlNodeVNum.InnerText);


            txtResults.Text = results.ToString();

        }



        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
