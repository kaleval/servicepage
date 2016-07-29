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
using System.IO;



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
            XFont font = new XFont("Verdana", 14, XFontStyle.Bold);
            XFont font2 = new XFont("Verdana", 14, XFontStyle.Regular);
            XFont font3 = new XFont("Verdana", 12, XFontStyle.Regular);
            XPen pen = new XPen(XColor.FromKnownColor(XKnownColor.Black), 1);
            PdfSharp.Drawing.Layout.XTextFormatter tf = new PdfSharp.Drawing.Layout.XTextFormatter(gfx);


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
            Rectangle hiba = new Rectangle(5, 95, 585, 30);
            Rectangle hibali = new Rectangle(5, 125, 585, 150);
            Rectangle hibalim = new Rectangle(8, 125, 585, 150);
            Rectangle munka = new Rectangle(5, 275, 585, 30);
            Rectangle munkali = new Rectangle(5, 305, 585, 150);
            Rectangle munkalim = new Rectangle(8, 305, 585, 150);
            Rectangle alkat = new Rectangle(5, 455, 585, 30);
            Rectangle alkatli = new Rectangle(5, 485, 585, 150);
            Rectangle alkatlim = new Rectangle(8, 485, 585, 150);
            Rectangle szer = new Rectangle(5, 645, 130, 30);
            Rectangle szerv = new Rectangle(5, 675, 130, 30);
            Rectangle al = new Rectangle(5, 787, 330, 30);
            Rectangle kelt = new Rectangle(5, 817, 230, 30);
            Rectangle al2 = new Rectangle(305, 787, 330, 30);



            if (File.Exists("kami.png"))
            {
                gfx.DrawImage(XImage.FromFile("kami.png"), log);
            }
            
           
                gfx.DrawRectangle(pen, log);
            // gfx.DrawRectangle(pen, cegnev);
            // gfx.DrawRectangle(pen, teleph);
            // gfx.DrawRectangle(pen, nyit);
            gfx.DrawRectangle(pen, ceg);
            gfx.DrawString(label1.Text, font, XBrushes.Black, cegnev, XStringFormat.Center);
            gfx.DrawString(label2.Text, font, XBrushes.Black, teleph, XStringFormat.Center);
            gfx.DrawString(label3.Text, font, XBrushes.Black, nyit, XStringFormat.Center);
            gfx.DrawRectangle(pen, ugyf);
            gfx.DrawString(textBox1.Text, font, XBrushes.Black, ugyf, XStringFormat.Center);
            gfx.DrawRectangle(pen, rendsz);
            gfx.DrawString(textBox2.Text, font, XBrushes.Black, rendsz, XStringFormat.Center);
            gfx.DrawRectangle(pen, km);
            gfx.DrawString(textBox3.Text, font, XBrushes.Black, km, XStringFormat.Center);
            gfx.DrawRectangle(pen, hiba);
            gfx.DrawRectangle(pen, hibali);
            tf.DrawString(textBox4.Text, font3, XBrushes.Black, hibalim, XStringFormat.TopLeft);
            gfx.DrawString(label4.Text, font, XBrushes.Black, hiba, XStringFormat.Center);
            gfx.DrawRectangle(pen, munka);
            gfx.DrawRectangle(pen, munkali);
            tf.DrawString(textBox5.Text, font3, XBrushes.Black, munkalim, XStringFormat.TopLeft);
            gfx.DrawString(label5.Text, font, XBrushes.Black, munka, XStringFormat.Center);
            gfx.DrawRectangle(pen, alkat);
            gfx.DrawRectangle(pen, alkatli);
            tf.DrawString(textBox6.Text, font3, XBrushes.Black, alkatlim, XStringFormat.TopLeft);
            gfx.DrawString(label6.Text, font, XBrushes.Black, alkat, XStringFormat.Center);
            gfx.DrawString(label7.Text, font2, XBrushes.Black, szer, XStringFormat.Center);
            gfx.DrawString("  "+textBox7.Text, font2, XBrushes.Black, szerv, XStringFormat.TopLeft);
            gfx.DrawString(" Aláírás:...................................", font2, XBrushes.Black, al, XStringFormat.TopLeft);
            gfx.DrawString(" Kelt:"+label8.Text, font2, XBrushes.Black, kelt, XStringFormat.TopLeft);
            gfx.DrawString(" Ügyfél aláírás:...............................", font2, XBrushes.Black, al2, XStringFormat.TopLeft);

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

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.Equals(Keys.Enter))
            {
                textBox4.Text = textBox4.Text + "\r\n";
            }
        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.Equals(Keys.Enter))
            {
                textBox5.Text = textBox5.Text + "\r\n";
            }
        }

        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.Equals(Keys.Enter))
            {
                textBox6.Text = textBox6.Text + "\r\n";
            }
        }
    }
}
