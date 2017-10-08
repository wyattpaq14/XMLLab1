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






        private void btnReadXMLFile_Click(object sender, EventArgs e)
        {
            // make life easy for now, put this file in the debug directory
            StringBuilder results = new StringBuilder();
            string sStartupPath = Application.StartupPath + "\\ContactsManager.xml";
            if (File.Exists(sStartupPath))
            {
                XmlTextReader textReader = new XmlTextReader(sStartupPath);
                textReader.Read();
                // Check to see that you have a valid node
                while (textReader.Read())
                {
                    // Move to fist element
                    textReader.MoveToElement();
                    Console.WriteLine("XmlTextReader Properties Test");
                    results.AppendLine("XmlTextReader Properties Test");
                    Console.WriteLine("===================");
                    results.AppendLine("===================");
                    Console.WriteLine("===================");
                    results.AppendLine("===================");

                    // Read this element's properties and display them on console

                    System.Console.WriteLine("Name:" + textReader.Name);
                    results.AppendLine("Name:" + textReader.Name);

                    Console.WriteLine("Base URI:" + textReader.BaseURI);
                    results.AppendLine("Base URI:" + textReader.BaseURI);

                    Console.WriteLine("Local Name:" + textReader.LocalName);
                    results.AppendLine("Local Name:" + textReader.LocalName);

                    Console.WriteLine("Attribute Count:" + textReader.AttributeCount.ToString());
                    results.AppendLine("Attribute Count:" + textReader.AttributeCount.ToString());

                    Console.WriteLine("Depth:" + textReader.Depth.ToString());
                    results.AppendLine("Depth:" + textReader.Depth.ToString());

                    Console.WriteLine("Line Number:" + textReader.LineNumber.ToString());
                    results.AppendLine("Line Number:" + textReader.LineNumber.ToString());

                    Console.WriteLine("Node Type:" + textReader.NodeType.ToString());
                    results.AppendLine("Node Type:" + textReader.NodeType.ToString());

                    Console.WriteLine("Attribute Count:" + textReader.Value.ToString());
                    results.AppendLine("Attribute Count:" + textReader.Value.ToString());

                }
                txtResults.Text = results.ToString();
            }
            else
                Console.Write("File does not exist");
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

        private void btnInnerText_Click(object sender, EventArgs e)
        {
            string strFilename = Application.StartupPath + "\\ContactsManager.xml";
            XmlDocument xmlDoc = new XmlDocument();
            StringBuilder results = new StringBuilder();

            if (File.Exists(strFilename))
            {
                xmlDoc.Load(strFilename);
                XmlElement elm = xmlDoc.DocumentElement;
                Console.WriteLine("{0}", elm.InnerText);
                results.AppendLine(elm.InnerText);
                Console.WriteLine("{0}", elm.OuterXml);
                results.AppendLine(elm.OuterXml);
                Console.WriteLine("{0}", elm.InnerXml);
                results.AppendLine(elm.InnerXml);
            }
            else
                Console.WriteLine("The file {0} could not be located",
                                  strFilename);
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

        private void btnGetPotato(object sender, EventArgs e)
        {
            string strFilename = Application.StartupPath + "\\ContactsManager.xml";
            StringBuilder results = new StringBuilder();
            XmlDocument xmlDoc = new XmlDocument();


            xmlDoc.Load(strFilename);
            XmlElement elm = xmlDoc.DocumentElement;
            XmlNodeList stocks = xmlDoc.GetElementsByTagName("RevisionDate");

            // Now you can check each node of the list
            foreach (XmlNode node in stocks)
            {
                Console.WriteLine(node.InnerText);
                results.AppendLine(node.InnerText);
            }
            txtResults.Text = results.ToString();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
