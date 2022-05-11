
namespace mimari_proje
{
    partial class Form3
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
            this.htmlButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.xmlButton = new System.Windows.Forms.Button();
            this.jsonButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // htmlButton
            // 
            this.htmlButton.Location = new System.Drawing.Point(53, 41);
            this.htmlButton.Name = "htmlButton";
            this.htmlButton.Size = new System.Drawing.Size(75, 35);
            this.htmlButton.TabIndex = 0;
            this.htmlButton.Text = "HTML";
            this.htmlButton.UseVisualStyleBackColor = true;
            this.htmlButton.Click += new System.EventHandler(this.htmlButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.jsonButton);
            this.groupBox1.Controls.Add(this.xmlButton);
            this.groupBox1.Controls.Add(this.htmlButton);
            this.groupBox1.Location = new System.Drawing.Point(27, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 220);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Raporunuzun Formatı";
            // 
            // xmlButton
            // 
            this.xmlButton.Location = new System.Drawing.Point(53, 95);
            this.xmlButton.Name = "xmlButton";
            this.xmlButton.Size = new System.Drawing.Size(75, 35);
            this.xmlButton.TabIndex = 3;
            this.xmlButton.Text = "XML";
            this.xmlButton.UseVisualStyleBackColor = true;
            this.xmlButton.Click += new System.EventHandler(this.xmlButton_Click);
            // 
            // jsonButton
            // 
            this.jsonButton.Location = new System.Drawing.Point(53, 149);
            this.jsonButton.Name = "jsonButton";
            this.jsonButton.Size = new System.Drawing.Size(75, 35);
            this.jsonButton.TabIndex = 4;
            this.jsonButton.Text = "JSON";
            this.jsonButton.UseVisualStyleBackColor = true;
            this.jsonButton.Click += new System.EventHandler(this.jsonButton_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(256, 279);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button htmlButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button jsonButton;
        private System.Windows.Forms.Button xmlButton;
    }
}