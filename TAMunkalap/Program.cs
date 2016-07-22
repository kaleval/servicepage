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
            Application.Run(new Form1());
            
        }
    }
}
