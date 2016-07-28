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
    public partial class NewWorkSheet : Form
    {
        public NewWorkSheet()
        {
            InitializeComponent();
        }
        public NewWorkSheet(string cegNev, string cegCim, string cegElerhetoseg, string ugyfelNev, string ugyfelCim, string ugyfelRendszam, string ugyfelTipus, string hibaLeiras, string javitasLeiras, string alkatreszLista)
        {
                
            InitializeComponent();
            // kapott paraméterekkel feltöltjük a formot

        }
        private void XMLSave()
        {

            
             if (true) // Cég / ügyfélnév / rendszám / km nem üres!
            {
                // ID label _ > Ha létezik akkor upgrade - ha nem létezik akkor új generálás ? 
                try
                {
                    XElement xElement = XElement.Parse("worksheets.xml");
                    int NextID = xElement.Descendants("worksheet").Count();

                    XmlDocument forras = new XmlDocument();
                    forras.Load("worksheets.xml");
                    XmlNode worksheets = forras.SelectSingleNode("worksheets");
                    XmlNode worksheet = forras.CreateNode(XmlNodeType.Element, "worksheet", null);
                    XmlAttribute sorszam = forras.CreateAttribute("id");
                    XmlAttribute ugyfelRendszam = forras.CreateAttribute("carplate");
                    XmlAttribute ugyfelNev = forras.CreateAttribute("name");
                    XmlAttribute cegNev = forras.CreateAttribute("service");
                    XmlAttribute cegTel = forras.CreateAttribute("servicephone");
                    XmlAttribute ugyfelKM = forras.CreateAttribute("carkm");
                    XmlAttribute hiba = forras.CreateAttribute("error");
                    XmlAttribute javitas = forras.CreateAttribute("repair");
                    XmlAttribute alkatreszek = forras.CreateAttribute("carparts");
                    XmlAttribute status = forras.CreateAttribute("status");

                    //nev.Value = textBox1.Text.ToString();
                    //cim.Value = textBox2.Text.ToString();
                    //tel.Value = textBox3.Text.ToString();
                    //rendszam.Value = textBox4.Text.ToString();
                    //tipus.Value = textBox5.Text.ToString();
                    //costumer.Attributes.Append(nev);
                    //costumer.Attributes.Append(cim);
                    //costumer.Attributes.Append(tel);
                    //costumer.Attributes.Append(rendszam);
                    //costumer.Attributes.Append(tipus);
                    //costumers.AppendChild(costumer);
                    //forras.Save("costumers.xml");
                    //this.Close();

                }
                catch { }
                finally { }
            }
            else
            {
                string message = "Kevés adatot adtál meg, tölts ki minden mezőt!";
                string caption = "Adminstrációs hiba!";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result = MessageBox.Show(message, caption, buttons);
            }       
        }
        private void XMLPrint()
        { 
           // nyomtatás PDF-be / nyomtatóval
        }

        private void NewWorkSheet_Load(object sender, EventArgs e)
        {
            String sDate = DateTime.Now.ToString();
            DateTime datevalue = (Convert.ToDateTime(sDate.ToString()));

            String dy = datevalue.Day.ToString();
            String mn = datevalue.Month.ToString();
            String yy = datevalue.Year.ToString();
            label12.Text = yy+"-"+mn+"-"+dy ;
            try
            {
                XDocument readCompany = XDocument.Load("company.xml");
                var q = from d in readCompany.Descendants("company")
                        select new { nev = d.Attribute("name"), cim = d.Attribute("address"), tel = d.Attribute("telephone"), mail = d.Attribute("email"), web = d.Attribute("webpage") };
                foreach (var ceg in q)
                {
                    label1.Text = ((string)ceg.nev.Value);
                    label2.Text = ((string)ceg.cim.Value);
                    label3.Text = ((string)ceg.tel.Value + " - " + (string)ceg.mail.Value);
                    label4.Text = ((string)ceg.web.Value);
                    
                }
            }
            catch { }
            finally { }
        }
    }
}
