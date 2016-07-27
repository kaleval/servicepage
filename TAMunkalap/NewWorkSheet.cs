using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            // aktuális állapot mentése        
        }
        private void XMLPrint()
        { 
           // nyomtatás PDF-be / nyomtatóval
        }
    }
}
