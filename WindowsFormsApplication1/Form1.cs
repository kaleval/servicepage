using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
        Rectangle hibalim = new Rectangle(10, 110, 585, 165);
        Rectangle munkalim = new Rectangle(10, 290, 585, 165);
        Rectangle alkatlim = new Rectangle(10, 470, 585, 165);
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
            label3.Text = cegTel + "\r\n" + cegMail;
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
            XFont font = new XFont("Microsoft Sans Serif", 12, XFontStyle.Bold);
            XFont font2 = new XFont("Microsoft Sans Serif", 9, XFontStyle.Regular);
            XFont font3 = new XFont("Microsoft Sans Serif", 8, XFontStyle.Regular);
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
            Rectangle cegnev = new Rectangle(145, 15, 220, 30);
            Rectangle teleph = new Rectangle(145, 35, 220, 30);
            Rectangle nyit = new Rectangle(145, 55, 220, 30);
            Rectangle ugyf = new Rectangle(355, 5, 235, 30);
            Rectangle rendsz = new Rectangle(355, 35, 235, 30);
            Rectangle km = new Rectangle(355, 65, 235, 30);
            Rectangle ugyf1 = new Rectangle(359, 10, 235, 30);
            Rectangle rendsz1 = new Rectangle(359, 40, 235, 30);
            Rectangle km1 = new Rectangle(359, 70, 235, 30);
            Rectangle ceg = new Rectangle(135, 5, 455, 90);
            
            Rectangle hiba = new Rectangle(5, 95, 585, 15);
            Rectangle munka = new Rectangle(5, 275, 585, 15);
            Rectangle alkat = new Rectangle(5, 455, 585, 15);

          


            Rectangle hibali = new Rectangle(5, 110, 585, 165);
          
            Rectangle munkali = new Rectangle(5, 290, 585, 165);
           

            Rectangle alkatli = new Rectangle(5, 470, 585, 165);
            


           
            
           
            
            Rectangle szer = new Rectangle(15, 645, 130, 30);
            Rectangle szerv = new Rectangle(15, 675, 130, 30);
            Rectangle al = new Rectangle(15, 787, 330, 30);
            Rectangle kelt = new Rectangle(15, 817, 230, 30);
            Rectangle al2 = new Rectangle(435, 787, 330, 30);



            if (File.Exists("kami.png"))
            {
                gfx.DrawImage(XImage.FromFile("kami.png"), log);
            }
            
           
                gfx.DrawRectangle(pen, log);
            // gfx.DrawRectangle(pen, cegnev);
            // gfx.DrawRectangle(pen, teleph);
            // gfx.DrawRectangle(pen, nyit);
            gfx.DrawRectangle(pen, ceg);
            gfx.DrawString(label1.Text, font, XBrushes.Black, cegnev, XStringFormat.TopLeft);
            gfx.DrawString(label2.Text, font2, XBrushes.Black, teleph, XStringFormat.TopLeft);
            tf.DrawString(label3.Text, font3, XBrushes.Black, nyit, XStringFormat.TopLeft);
            
            gfx.DrawRectangle(pen, ugyf);
            gfx.DrawString(textBox1.Text, font, XBrushes.Black, ugyf1, XStringFormat.TopLeft);
            gfx.DrawRectangle(pen, rendsz);
            gfx.DrawString(textBox2.Text, font2, XBrushes.Black, rendsz1, XStringFormat.TopLeft);
            gfx.DrawRectangle(pen, km);
            gfx.DrawString(textBox3.Text + " KM", font2, XBrushes.Black, km1, XStringFormat.TopLeft);
            gfx.DrawRectangle(pen, hiba);
            gfx.DrawRectangle(pen, hibali);
            tf.DrawString(TextWrapper(textBox4.Text,130), font3, XBrushes.Black, hibalim, XStringFormat.TopLeft);
            gfx.DrawString(label4.Text, font, XBrushes.Black, hiba, XStringFormat.TopLeft);
            gfx.DrawRectangle(pen, munka);
            gfx.DrawRectangle(pen, munkali);
            tf.DrawString(TextWrapper(textBox5.Text, 130), font3, XBrushes.Black, munkalim, XStringFormat.TopLeft);
            gfx.DrawString(label5.Text, font, XBrushes.Black, munka, XStringFormat.TopLeft);
            gfx.DrawRectangle(pen, alkat);
            gfx.DrawRectangle(pen, alkatli);
            tf.DrawString(TextWrapper(textBox6.Text, 130), font3, XBrushes.Black, alkatlim, XStringFormat.TopLeft);
            gfx.DrawString(label6.Text, font, XBrushes.Black, alkat, XStringFormat.TopLeft);
            gfx.DrawString(label7.Text, font2, XBrushes.Black, szer, XStringFormat.TopLeft);
            gfx.DrawString("  "+textBox7.Text, font2, XBrushes.Black, szerv, XStringFormat.TopLeft);
            gfx.DrawString(" Aláírás:...................................", font2, XBrushes.Black, al, XStringFormat.TopLeft);
            gfx.DrawString(" Kelt:"+label8.Text, font2, XBrushes.Black, kelt, XStringFormat.TopLeft);
            gfx.DrawString(" Ügyfél aláírás:...............................", font2, XBrushes.Black, al2, XStringFormat.TopLeft);

            gfx.DrawLine(pen, bfm, bam);
            gfx.DrawLine(pen, bam, jam);
            gfx.DrawLine(pen, jam, jfm);
            gfx.DrawLine(pen, jfm, bfm);



            doc.Save(PDFNameGenerator(textBox1.Text));
            MessageBox.Show("Mentés kész!");
        }
        private string PDFNameGenerator(String ugyfelNeve)
        {


            return Regex.Replace(ugyfelNeve, @"\s+", "")+DateTime.Now.ToString("yyyy-MM-ddTHH-mm") + ".pdf";        
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
            //valami
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            //if (textBox4.TextLength >= hibalim.Width - 1)
            //{
            //    textBox4.Text = textBox4.Text + "\r\n";
            //}
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            //if (textBox5.TextLength >= munkalim.Width - 1)
            //{
            //    textBox5.Text = textBox5.Text + "\r\n";
            //}
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
        //    if (textBox6.TextLength >= alkatlim.Width - 1)
        //    {
        //        textBox6.Text = textBox6.Text + "\r\n";
        //    }
        }
        private string TextWrapper(string input, int pdfBoxWidth)
        {
            char[] investigate = input.ToCharArray();
            int actualLengthOfLine = 0;
            string output = String.Empty;

            for (int i = 0; i < investigate.Length; i++)
            {
                if (actualLengthOfLine <= pdfBoxWidth - 2)
                {
                    actualLengthOfLine++ ;
                    output = output + investigate[i];
                }
                else
                {
                    actualLengthOfLine = 0;
                    if (investigate[i] != ' ' ) { output = output + "-\r\n" + investigate[i]; }
                    else {output = output + "\r\n" + investigate[i];}
                   
                    
                }
            }
                // MessageBox.Show(input.Length.ToString());
                return output;
        }

 
    }
}
