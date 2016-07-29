using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PdfSharp;
using PdfSharp.Pdf;
using PdfSharp.Drawing;


namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            label8.Text = System.DateTime.Today.ToShortDateString();
          
        }
        public Form1(string cegNev, string cegCim, string cegTel, string cegMail)
        {
            InitializeComponent();
            label1.Text = cegNev;
            label2.Text = cegCim;
            label3.Text = cegTel + " - " + cegMail;
            label8.Text = System.DateTime.Today.ToShortDateString();

        }
        public Form1(string cegNev, string cegCim, string cegTel, string cegMail, string ugyfelNev, string ugyfelTipus, string ugyfelRendszam)
        {
            InitializeComponent();
            label8.Text = System.DateTime.Today.ToShortDateString();

        }
       

        private void button1_Click(object sender, EventArgs e)
        {
            GeneratePdf();
            
        }

        void GeneratePdf()
        {
            PdfDocument doc = new PdfDocument();
            PdfPage page1 = doc.AddPage();
            XGraphics gfx = XGraphics.FromPdfPage(page1);
            XFont font = new XFont("Verdana", 20, XFontStyle.Bold);
            XPen pen = new XPen(XColor.FromKnownColor(XKnownColor.Black), 1);
            Point bf = new Point(0, 0);
            Point jf = new Point(595, 0);
            Point ba = new Point(0, 842);
            Point ja = new Point(595, 842);

            Point bfm = new Point(5, 5);
            Point jfm = new Point(590, 5);
            Point bam = new Point(5, 837);
            Point jam = new Point(590, 837);
            Rectangle log = new Rectangle(5, 5, 130, 90);
            Rectangle cegnev = new Rectangle(135, 5, 220, 30);
            Rectangle teleph = new Rectangle(135, 35, 220, 30);
            Rectangle nyit = new Rectangle(135, 65, 220, 30);
            Rectangle ugyf = new Rectangle(355, 5, 235, 30);
            Rectangle rendsz = new Rectangle(355, 35, 235, 30);
            Rectangle km = new Rectangle(355, 65, 235, 30);
            Rectangle ceg = new Rectangle(135, 5, 455, 90);




            //gfx.DrawImage(XImage.FromFile(@"C:\\Users\\havas\\Documents\\Visual Studio 2015\\Projects\\WindowsFormsApplication1\\WindowsFormsApplication1\\bin\\Debug\\Ok.PNG"), 10, 5, 90, 90);
            gfx.DrawRectangle(pen, log);
            // gfx.DrawRectangle(pen, cegnev);
            // gfx.DrawRectangle(pen, teleph);
            // gfx.DrawRectangle(pen, nyit);
            gfx.DrawRectangle(pen, ceg);
            gfx.DrawRectangle(pen, ugyf);
            gfx.DrawRectangle(pen, rendsz);
            gfx.DrawRectangle(pen, km);

            gfx.DrawLine(pen, bfm, bam);
            gfx.DrawLine(pen, bam, jam);
            gfx.DrawLine(pen, jam, jfm);
            gfx.DrawLine(pen, jfm, bfm);



            doc.Save("Teszt.pdf");
            MessageBox.Show("Mentés kész!");
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_MouseClick(object sender, MouseEventArgs e)
        {
            if (textBox1.Text == "Ügyfél név")
            {
                textBox1.Text = String.Empty;
            }
        }

        private void textBox2_MouseClick(object sender, MouseEventArgs e)
        {
            if (textBox2.Text == "Gépjármű - Rendszám")
            {
                textBox2.Text = String.Empty;
            }
        }

        private void textBox3_MouseClick(object sender, MouseEventArgs e)
        {
            if (textBox3.Text == "KM-óra állása")
            {
                textBox3.Text = String.Empty;
            }
        }
    }
}
