namespace TAMunkalap
{
    partial class WorkSheet
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.UgyfelNevBox = new System.Windows.Forms.TextBox();
            this.UgyfelRendszamBox = new System.Windows.Forms.TextBox();
            this.UgyfelKMBox = new System.Windows.Forms.TextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.richTextBox3 = new System.Windows.Forms.RichTextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 38);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(153, 381);
            this.listBox1.TabIndex = 0;
            // 
            // UgyfelNevBox
            // 
            this.UgyfelNevBox.Location = new System.Drawing.Point(438, 38);
            this.UgyfelNevBox.Name = "UgyfelNevBox";
            this.UgyfelNevBox.Size = new System.Drawing.Size(469, 20);
            this.UgyfelNevBox.TabIndex = 1;
            // 
            // UgyfelRendszamBox
            // 
            this.UgyfelRendszamBox.Location = new System.Drawing.Point(438, 64);
            this.UgyfelRendszamBox.Name = "UgyfelRendszamBox";
            this.UgyfelRendszamBox.Size = new System.Drawing.Size(469, 20);
            this.UgyfelRendszamBox.TabIndex = 1;
            // 
            // UgyfelKMBox
            // 
            this.UgyfelKMBox.Location = new System.Drawing.Point(438, 90);
            this.UgyfelKMBox.Name = "UgyfelKMBox";
            this.UgyfelKMBox.Size = new System.Drawing.Size(469, 20);
            this.UgyfelKMBox.TabIndex = 1;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(438, 118);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(469, 96);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "";
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(438, 220);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(469, 96);
            this.richTextBox2.TabIndex = 2;
            this.richTextBox2.Text = "";
            // 
            // richTextBox3
            // 
            this.richTextBox3.Location = new System.Drawing.Point(438, 322);
            this.richTextBox3.Name = "richTextBox3";
            this.richTextBox3.Size = new System.Drawing.Size(469, 96);
            this.richTextBox3.TabIndex = 2;
            this.richTextBox3.Text = "";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(174, 64);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(238, 20);
            this.textBox4.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(174, 90);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Keresés";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(171, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(241, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Keresés: Név, Rendszám, Munkalapszám alapján";
            // 
            // WorkSheet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(919, 431);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.richTextBox3);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.UgyfelKMBox);
            this.Controls.Add(this.UgyfelRendszamBox);
            this.Controls.Add(this.UgyfelNevBox);
            this.Controls.Add(this.listBox1);
            this.Name = "WorkSheet";
            this.Text = "Munkalap Kereső";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox UgyfelNevBox;
        private System.Windows.Forms.TextBox UgyfelRendszamBox;
        private System.Windows.Forms.TextBox UgyfelKMBox;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.RichTextBox richTextBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
    }
}