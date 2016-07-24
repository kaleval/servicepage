using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace TAMunkalap
{
    public partial class CreateCompany : Form
    {
        public CreateCompany()
        {
            InitializeComponent();
            button3.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != String.Empty && textBox2.Text != String.Empty && textBox3.Text != String.Empty)
            {
                string xml = @"<?xml version='1.0' encoding='utf-8' ?>
                           <companydetails>
                                <company name='" + textBox1.Text + "' address='" + textBox2.Text + "' telephone='" + textBox3.Text + "' email='" + textBox4.Text + "' webpage='" + textBox5.Text + "' logo='nologo' />  </companydetails>";
               
                XmlDocument output = new XmlDocument();
                output.LoadXml(xml);
                output.Save("company.xml");
                
                this.Close();
            }
            else
            {   MessageBoxButtons buttons = MessageBoxButtons.OK;
                 MessageBox.Show("Nincs elég adat", "A mentés nem sikerült", buttons);
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CreateCompany_Load(object sender, EventArgs e)
        {

        }
    }
}
