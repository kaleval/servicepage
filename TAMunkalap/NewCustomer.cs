using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Xml.Linq;
using System.Xml;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace TAMunkalap
{
    public partial class NewCustomer : Form
    {
        public NewCustomer()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // if exist? ha nincs létrehozza az üres filet! 
            if (!File.Exists("costumers.xml")) {
                string xml = @"<?xml version='1.0' encoding='utf-8' ?>
                           <costumers>
                           </costumers>";

                XmlDocument output = new XmlDocument();
                output.LoadXml(xml);
                output.Save("costumers.xml");
            }
            if (textBox1.Text != String.Empty && textBox2.Text != String.Empty && textBox3.Text != String.Empty && textBox4.Text != String.Empty && textBox5.Text != String.Empty)
            {
                try {
                    XDocument registrated = XDocument.Load("costumers.xml");
                    var q = from d in registrated.Descendants("costumers")
                            where (string)d.Attribute("id") == textBox4.Text.ToString()
                            select new { rendszam = d.Attribute("id") };
                    string van = string.Empty;
                    foreach (var bbb in q)
                    {
                        van = bbb.rendszam.Value;
                    }
                    if (van != string.Empty)
                    {
                        //throw new LetezoFelhasznalonevException();
                    }
                    XmlDocument forras = new XmlDocument();
                    forras.Load("costumers.xml");
                    XmlNode costumers = forras.SelectSingleNode("costumers");
                    XmlNode costumer = forras.CreateNode(XmlNodeType.Element, "costumer", null);
                    XmlAttribute nev = forras.CreateAttribute("name");
                    XmlAttribute cim = forras.CreateAttribute("address");
                    XmlAttribute tel = forras.CreateAttribute("telephone");
                    XmlAttribute rendszam = forras.CreateAttribute("id");
                    XmlAttribute tipus = forras.CreateAttribute("type");
                    nev.Value = textBox1.Text.ToString();
                    cim.Value = textBox2.Text.ToString();
                    tel.Value = textBox3.Text.ToString();
                    rendszam.Value = textBox4.Text.ToString();
                    tipus.Value = textBox5.Text.ToString();
                    costumer.Attributes.Append(nev);
                    costumer.Attributes.Append(cim);
                    costumer.Attributes.Append(tel);
                    costumer.Attributes.Append(rendszam);
                    costumer.Attributes.Append(tipus);
                    costumers.AppendChild(costumer);
                    forras.Save("costumers.xml");

                }
                catch { }
                finally { }
            }
        }
    }
}
