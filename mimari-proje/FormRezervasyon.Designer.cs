
namespace mimari_proje
{
    partial class FormRezervasyon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRezervasyon));
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.otobus = new System.Windows.Forms.RadioButton();
            this.Uçak = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.otel = new System.Windows.Forms.RadioButton();
            this.cadir = new System.Windows.Forms.RadioButton();
            this.UlasimGidisDate = new System.Windows.Forms.DateTimePicker();
            this.UlasimDonusDate = new System.Windows.Forms.DateTimePicker();
            this.KonakStartDate = new System.Windows.Forms.DateTimePicker();
            this.KonakEndDate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.adTxt = new System.Windows.Forms.TextBox();
            this.soyadTxt = new System.Windows.Forms.TextBox();
            this.tcNoTxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.neredenTxt = new System.Windows.Forms.TextBox();
            this.nereyeTxt = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(242, 350);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(132, 41);
            this.button1.TabIndex = 0;
            this.button1.Text = "Rezervasyon Yap";
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
            this.groupBox1.Text = "Ulaşım";
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
            // Uçak
            // 
            this.Uçak.AutoSize = true;
            this.Uçak.Location = new System.Drawing.Point(6, 34);
            this.Uçak.Name = "Uçak";
            this.Uçak.Size = new System.Drawing.Size(61, 21);
            this.Uçak.TabIndex = 10;
            this.Uçak.TabStop = true;
            this.Uçak.Text = "Uçak";
            this.Uçak.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.otel);
            this.groupBox2.Controls.Add(this.cadir);
            this.groupBox2.Location = new System.Drawing.Point(12, 135);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 100);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Konaklama";
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
            // cadir
            // 
            this.cadir.AutoSize = true;
            this.cadir.Location = new System.Drawing.Point(0, 21);
            this.cadir.Name = "cadir";
            this.cadir.Size = new System.Drawing.Size(62, 21);
            this.cadir.TabIndex = 12;
            this.cadir.TabStop = true;
            this.cadir.Text = "Çadır";
            this.cadir.UseVisualStyleBackColor = true;
            // 
            // UlasimGidisDate
            // 
            this.UlasimGidisDate.Location = new System.Drawing.Point(242, 30);
            this.UlasimGidisDate.Name = "UlasimGidisDate";
            this.UlasimGidisDate.Size = new System.Drawing.Size(200, 22);
            this.UlasimGidisDate.TabIndex = 3;
            // 
            // UlasimDonusDate
            // 
            this.UlasimDonusDate.Location = new System.Drawing.Point(242, 88);
            this.UlasimDonusDate.Name = "UlasimDonusDate";
            this.UlasimDonusDate.Size = new System.Drawing.Size(200, 22);
            this.UlasimDonusDate.TabIndex = 4;
            // 
            // KonakStartDate
            // 
            this.KonakStartDate.Location = new System.Drawing.Point(242, 175);
            this.KonakStartDate.Name = "KonakStartDate";
            this.KonakStartDate.Size = new System.Drawing.Size(200, 22);
            this.KonakStartDate.TabIndex = 5;
            // 
            // KonakEndDate
            // 
            this.KonakEndDate.Location = new System.Drawing.Point(539, 175);
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
            this.tcNoTxt.MaxLength = 11;
            this.tcNoTxt.Name = "tcNoTxt";
            this.tcNoTxt.Size = new System.Drawing.Size(100, 22);
            this.tcNoTxt.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(239, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 17);
            this.label4.TabIndex = 13;
            this.label4.Text = "Gidiş";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(239, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 17);
            this.label5.TabIndex = 14;
            this.label5.Text = "Dönüş";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(239, 155);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 17);
            this.label6.TabIndex = 15;
            this.label6.Text = "Başlangıç";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(520, 155);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 17);
            this.label7.TabIndex = 16;
            this.label7.Text = "Bitiş";
            // 
            // neredenTxt
            // 
            this.neredenTxt.Location = new System.Drawing.Point(539, 31);
            this.neredenTxt.Name = "neredenTxt";
            this.neredenTxt.Size = new System.Drawing.Size(100, 22);
            this.neredenTxt.TabIndex = 18;
            // 
            // nereyeTxt
            // 
            this.nereyeTxt.Location = new System.Drawing.Point(539, 89);
            this.nereyeTxt.Name = "nereyeTxt";
            this.nereyeTxt.Size = new System.Drawing.Size(100, 22);
            this.nereyeTxt.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(536, 11);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 17);
            this.label8.TabIndex = 20;
            this.label8.Text = "Nereden";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(536, 69);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 17);
            this.label9.TabIndex = 21;
            this.label9.Text = "Nereye";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Balaban Seyahat",
            "Kardeşler Seyahat",
            "Balcı Seyahat"});
            this.comboBox1.Location = new System.Drawing.Point(664, 61);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(116, 24);
            this.comboBox1.TabIndex = 22;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(20, 40);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(147, 41);
            this.button2.TabIndex = 23;
            this.button2.Text = "Rezervasyon İptal";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(661, 43);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(43, 17);
            this.label10.TabIndex = 24;
            this.label10.Text = "Firma";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label11.Location = new System.Drawing.Point(-9, 115);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(1103, 17);
            this.label11.TabIndex = 25;
            this.label11.Text = resources.GetString("label11.Text");
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label12.Location = new System.Drawing.Point(-9, 238);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(1103, 17);
            this.label12.TabIndex = 26;
            this.label12.Text = resources.GetString("label12.Text");
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button2);
            this.groupBox3.Location = new System.Drawing.Point(596, 310);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(206, 96);
            this.groupBox3.TabIndex = 28;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Mevcut rezervasyonunuz için";
            // 
            // FormRezervasyon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 418);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.nereyeTxt);
            this.Controls.Add(this.neredenTxt);
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
            this.Name = "FormRezervasyon";
            this.Text = "Rezervasyon";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
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
        private System.Windows.Forms.TextBox neredenTxt;
        private System.Windows.Forms.TextBox nereyeTxt;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}

