
namespace mimari_proje
{
    partial class FormRezervasyonİptal
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.otoButton = new System.Windows.Forms.RadioButton();
            this.ucakButton = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.otelButton = new System.Windows.Forms.RadioButton();
            this.cadirButton = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(122, 196);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(120, 22);
            this.textBox1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(295, 192);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 31);
            this.button1.TabIndex = 1;
            this.button1.Text = "İptal Et";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 196);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "TC Numaranız:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.otoButton);
            this.groupBox1.Controls.Add(this.ucakButton);
            this.groupBox1.Location = new System.Drawing.Point(16, 48);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ulaşım Hizmeti";
            // 
            // otoButton
            // 
            this.otoButton.AutoSize = true;
            this.otoButton.Location = new System.Drawing.Point(7, 59);
            this.otoButton.Name = "otoButton";
            this.otoButton.Size = new System.Drawing.Size(75, 21);
            this.otoButton.TabIndex = 7;
            this.otoButton.TabStop = true;
            this.otoButton.Text = "Otobüs";
            this.otoButton.UseVisualStyleBackColor = true;
            // 
            // ucakButton
            // 
            this.ucakButton.AutoSize = true;
            this.ucakButton.Location = new System.Drawing.Point(6, 32);
            this.ucakButton.Name = "ucakButton";
            this.ucakButton.Size = new System.Drawing.Size(61, 21);
            this.ucakButton.TabIndex = 6;
            this.ucakButton.TabStop = true;
            this.ucakButton.Text = "Uçak";
            this.ucakButton.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.otelButton);
            this.groupBox2.Controls.Add(this.cadirButton);
            this.groupBox2.Location = new System.Drawing.Point(222, 48);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 100);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Konaklama Hizmeti";
            // 
            // otelButton
            // 
            this.otelButton.AutoSize = true;
            this.otelButton.Location = new System.Drawing.Point(7, 59);
            this.otelButton.Name = "otelButton";
            this.otelButton.Size = new System.Drawing.Size(55, 21);
            this.otelButton.TabIndex = 9;
            this.otelButton.TabStop = true;
            this.otelButton.Text = "Otel";
            this.otelButton.UseVisualStyleBackColor = true;
            // 
            // cadirButton
            // 
            this.cadirButton.AutoSize = true;
            this.cadirButton.Location = new System.Drawing.Point(6, 32);
            this.cadirButton.Name = "cadirButton";
            this.cadirButton.Size = new System.Drawing.Size(62, 21);
            this.cadirButton.TabIndex = 8;
            this.cadirButton.TabStop = true;
            this.cadirButton.Text = "Çadır";
            this.cadirButton.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "İptal Etmek İstediğiniz..";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(331, 244);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(106, 36);
            this.button2.TabIndex = 6;
            this.button2.Text = "Ana Menü";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // FormRezervasyonİptal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 292);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Name = "FormRezervasyonİptal";
            this.Text = "Form2";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton otoButton;
        private System.Windows.Forms.RadioButton ucakButton;
        private System.Windows.Forms.RadioButton otelButton;
        private System.Windows.Forms.RadioButton cadirButton;
        private System.Windows.Forms.Button button2;
    }
}