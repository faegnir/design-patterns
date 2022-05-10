
namespace mimari_proje
{
    partial class Form1
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
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.UlasimGidisDate = new System.Windows.Forms.DateTimePicker();
            this.UlasimDonusDate = new System.Windows.Forms.DateTimePicker();
            this.KonakStartDate = new System.Windows.Forms.DateTimePicker();
            this.KonakEndDate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Uçak = new System.Windows.Forms.RadioButton();
            this.otobus = new System.Windows.Forms.RadioButton();
            this.cadir = new System.Windows.Forms.RadioButton();
            this.otel = new System.Windows.Forms.RadioButton();
            this.adTxt = new System.Windows.Forms.TextBox();
            this.soyadTxt = new System.Windows.Forms.TextBox();
            this.tcNoTxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(786, 163);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 38);
            this.button1.TabIndex = 0;
            this.button1.Text = "Rezervasyon";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.otobus);
            this.groupBox1.Controls.Add(this.Uçak);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ulasim";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.otel);
            this.groupBox2.Controls.Add(this.cadir);
            this.groupBox2.Location = new System.Drawing.Point(12, 127);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 100);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Konaklama";
            // 
            // UlasimGidisDate
            // 
            this.UlasimGidisDate.Location = new System.Drawing.Point(284, 60);
            this.UlasimGidisDate.Name = "UlasimGidisDate";
            this.UlasimGidisDate.Size = new System.Drawing.Size(200, 22);
            this.UlasimGidisDate.TabIndex = 3;
            // 
            // UlasimDonusDate
            // 
            this.UlasimDonusDate.Location = new System.Drawing.Point(541, 60);
            this.UlasimDonusDate.Name = "UlasimDonusDate";
            this.UlasimDonusDate.Size = new System.Drawing.Size(200, 22);
            this.UlasimDonusDate.TabIndex = 4;
            // 
            // KonakStartDate
            // 
            this.KonakStartDate.Location = new System.Drawing.Point(284, 177);
            this.KonakStartDate.Name = "KonakStartDate";
            this.KonakStartDate.Size = new System.Drawing.Size(200, 22);
            this.KonakStartDate.TabIndex = 5;
            // 
            // KonakEndDate
            // 
            this.KonakEndDate.Location = new System.Drawing.Point(541, 177);
            this.KonakEndDate.Name = "KonakEndDate";
            this.KonakEndDate.Size = new System.Drawing.Size(200, 22);
            this.KonakEndDate.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 282);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Ad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 327);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Soyad";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 373);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "TC NO";
            // 
            // Uçak
            // 
            this.Uçak.AutoSize = true;
            this.Uçak.Location = new System.Drawing.Point(6, 34);
            this.Uçak.Name = "Uçak";
            this.Uçak.Size = new System.Drawing.Size(61, 21);
            this.Uçak.TabIndex = 10;
            this.Uçak.TabStop = true;
            this.Uçak.Text = "Ucak";
            this.Uçak.UseVisualStyleBackColor = true;
            // 
            // otobus
            // 
            this.otobus.AutoSize = true;
            this.otobus.Location = new System.Drawing.Point(6, 61);
            this.otobus.Name = "otobus";
            this.otobus.Size = new System.Drawing.Size(75, 21);
            this.otobus.TabIndex = 11;
            this.otobus.TabStop = true;
            this.otobus.Text = "Otobüs";
            this.otobus.UseVisualStyleBackColor = true;
            // 
            // cadir
            // 
            this.cadir.AutoSize = true;
            this.cadir.Location = new System.Drawing.Point(0, 21);
            this.cadir.Name = "cadir";
            this.cadir.Size = new System.Drawing.Size(62, 21);
            this.cadir.TabIndex = 12;
            this.cadir.TabStop = true;
            this.cadir.Text = "Cadir";
            this.cadir.UseVisualStyleBackColor = true;
            // 
            // otel
            // 
            this.otel.AutoSize = true;
            this.otel.Location = new System.Drawing.Point(0, 53);
            this.otel.Name = "otel";
            this.otel.Size = new System.Drawing.Size(55, 21);
            this.otel.TabIndex = 13;
            this.otel.TabStop = true;
            this.otel.Text = "Otel";
            this.otel.UseVisualStyleBackColor = true;
            // 
            // adTxt
            // 
            this.adTxt.Location = new System.Drawing.Point(86, 279);
            this.adTxt.Name = "adTxt";
            this.adTxt.Size = new System.Drawing.Size(100, 22);
            this.adTxt.TabIndex = 10;
            // 
            // soyadTxt
            // 
            this.soyadTxt.Location = new System.Drawing.Point(86, 324);
            this.soyadTxt.Name = "soyadTxt";
            this.soyadTxt.Size = new System.Drawing.Size(100, 22);
            this.soyadTxt.TabIndex = 11;
            // 
            // tcNoTxt
            // 
            this.tcNoTxt.Location = new System.Drawing.Point(86, 370);
            this.tcNoTxt.Name = "tcNoTxt";
            this.tcNoTxt.Size = new System.Drawing.Size(100, 22);
            this.tcNoTxt.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(281, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 17);
            this.label4.TabIndex = 13;
            this.label4.Text = "Gidiş";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(538, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 17);
            this.label5.TabIndex = 14;
            this.label5.Text = "Dönüş";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(281, 148);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 17);
            this.label6.TabIndex = 15;
            this.label6.Text = "Başlangıç";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(538, 148);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 17);
            this.label7.TabIndex = 16;
            this.label7.Text = "Bitiş";
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(296, 224);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(559, 319);
            this.webBrowser1.TabIndex = 17;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(945, 547);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tcNoTxt);
            this.Controls.Add(this.soyadTxt);
            this.Controls.Add(this.adTxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.KonakEndDate);
            this.Controls.Add(this.KonakStartDate);
            this.Controls.Add(this.UlasimDonusDate);
            this.Controls.Add(this.UlasimGidisDate);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton otobus;
        private System.Windows.Forms.RadioButton Uçak;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton otel;
        private System.Windows.Forms.RadioButton cadir;
        private System.Windows.Forms.DateTimePicker UlasimGidisDate;
        private System.Windows.Forms.DateTimePicker UlasimDonusDate;
        private System.Windows.Forms.DateTimePicker KonakStartDate;
        private System.Windows.Forms.DateTimePicker KonakEndDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox adTxt;
        private System.Windows.Forms.TextBox soyadTxt;
        private System.Windows.Forms.TextBox tcNoTxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.WebBrowser webBrowser1;
    }
}

