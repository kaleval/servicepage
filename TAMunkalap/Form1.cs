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
    public partial class Form1 : Form
    {
        public static NewCustomer create_customer = new NewCustomer();
        public Form1()
        {
            InitializeComponent();
            if (!File.Exists("company.xml")) 
            {
                 string message = "Nincs cég regisztrálva!";
                    string caption = "Hiba, a program nem indítható!";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result;
                result = MessageBox.Show(message,caption,buttons);
                if(result == DialogResult.OK) { this.Close();}
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try {
                    XDocument readCompany = XDocument.Load("company.xml");
                    var q = from d in readCompany.Descendants("company")
                            select new { nev = d.Attribute("name"), cim = d.Attribute("address"), tel = d.Attribute("telephone"), mail = d.Attribute("email"), web = d.Attribute("webpage") };
                    foreach (var ceg in q)
                    {
                        listBox1.Items.Add((string)ceg.nev.Value);
                        listBox1.Items.Add((string)ceg.cim.Value);
                        listBox1.Items.Add((string)ceg.tel.Value + " - " + (string)ceg.mail.Value);
                        listBox1.Items.Add((string)ceg.web.Value);
                    }
            }
            catch { }
            finally { }
            ReadCostumers();
            
        }
        private void ReadCostumers()
        {
            listBox2.Items.Clear();
            try
            {
               

                if (File.Exists("costumers.xml"))
                {
                    XDocument readCostumers = XDocument.Load("costumers.xml");
                    var p = from d in readCostumers.Descendants("costumer")
                            select new { nev = d.Attribute("name"), cim = d.Attribute("address"), tel = d.Attribute("telephone"), rendszam = d.Attribute("id"), tipus = d.Attribute("type") };
                    foreach (var ugyfel in p)
                    {
                        listBox2.Items.Add((string)ugyfel.nev.Value + " - " + (string)ugyfel.rendszam.Value);
                    }
                }
            }
            catch { }
            finally { }
        }

        private void button2_Click(object sender, EventArgs e)
        {


            create_customer.ShowDialog();
        }

        private void kilépésToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ReadCostumers();
        }

        private void listBox2_DoubleClick(object sender, EventArgs e)
        {
            try
            {

                XDocument readCompany = XDocument.Load("company.xml");
                var q = from d in readCompany.Descendants("company")
                        select new { nev = d.Attribute("name"), cim = d.Attribute("address"), tel = d.Attribute("telephone"), mail = d.Attribute("email"), web = d.Attribute("webpage") };
                foreach (var ceg in q)
                {
                    //paraméterek beolvasása változóba
                   

                    if (File.Exists("costumers.xml"))
                    {
                        XDocument readCostumers = XDocument.Load("costumers.xml");
                        var p = from d in readCostumers.Descendants("costumer")
                                select new { nev = d.Attribute("name"), cim = d.Attribute("address"), tel = d.Attribute("telephone"), rendszam = d.Attribute("id"), tipus = d.Attribute("type") };
                        foreach (var ugyfel in p)
                        {
                            //paranlterek beolvasása változóba
                        }
                    }
                }
                //munkalap sorszám generálás

                //munkalap form meghívása felparaméterezve

            }
            catch { }
            finally { }
        }
        private void NewWorkSheet()
        {
           


        }

        private void button6_Click(object sender, EventArgs e)
        {
            WindowsFormsApplication1.Form1 ablak = new WindowsFormsApplication1.Form1((string)listBox1.Items[0], (string)listBox1.Items[1], (string)listBox1.Items[2], (string)listBox1.Items[3]);
            ablak.Show();
            //NewWorkSheet worksheet = new NewWorkSheet();
            //worksheet.Show();
        }
      
    }
}
