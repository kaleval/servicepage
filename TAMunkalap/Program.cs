using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;
using System.IO;
using System.Windows.Forms;
using System.Xml;

namespace TAMunkalap
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        public static CreateCompany create_company = new CreateCompany();
        [STAThread]
        static void Main()
        {
          

            Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(true);
            if (!File.Exists("company.xml")) create_company.ShowDialog();
            if (!File.Exists("worksheets.xml")) {
                try {
                    string xml = @"<?xml version='1.0' encoding='utf-8' ?>
                           <worksheets>
                           </worksheets>";

                    XmlDocument output = new XmlDocument();
                    output.LoadXml(xml);
                    output.Save("worksheets.xml");
                }
                catch { }
                finally { }
            }
            Application.Run(new Form1());
            
        }
    }
}
