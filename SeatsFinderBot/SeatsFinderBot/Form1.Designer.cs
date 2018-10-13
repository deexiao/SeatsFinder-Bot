namespace SeatsFinderBot
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
            this.subjectText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numberText = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.sectionText = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.userText = new System.Windows.Forms.TextBox();
            this.passwordText = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.reservedText = new System.Windows.Forms.TextBox();
            this.GUID = new System.Windows.Forms.Label();
            this.guidText = new System.Windows.Forms.TextBox();
            this.swapRadio = new System.Windows.Forms.RadioButton();
            this.addRadio = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // subjectText
            // 
            this.subjectText.Location = new System.Drawing.Point(689, 165);
            this.subjectText.Name = "subjectText";
            this.subjectText.Size = new System.Drawing.Size(236, 35);
            this.subjectText.TabIndex = 0;
            this.subjectText.TextChanged += new System.EventHandler(this.subjectText_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(547, 168);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Subject";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(547, 249);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Number";
            // 
            // numberText
            // 
            this.numberText.Location = new System.Drawing.Point(689, 246);
            this.numberText.Name = "numberText";
            this.numberText.Size = new System.Drawing.Size(236, 35);
            this.numberText.TabIndex = 3;
            this.numberText.TextChanged += new System.EventHandler(this.numberText_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(547, 331);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "Section";
            // 
            // sectionText
            // 
            this.sectionText.Location = new System.Drawing.Point(689, 328);
            this.sectionText.Name = "sectionText";
            this.sectionText.Size = new System.Drawing.Size(236, 35);
            this.sectionText.TabIndex = 5;
            this.sectionText.TextChanged += new System.EventHandler(this.sectionText_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(551, 1152);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(374, 69);
            this.button1.TabIndex = 6;
            this.button1.Text = "Start";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(547, 574);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 24);
            this.label4.TabIndex = 7;
            this.label4.Text = "User Name";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(547, 658);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 24);
            this.label5.TabIndex = 8;
            this.label5.Text = "Password";
            // 
            // userText
            // 
            this.userText.Location = new System.Drawing.Point(689, 571);
            this.userText.Name = "userText";
            this.userText.Size = new System.Drawing.Size(236, 35);
            this.userText.TabIndex = 9;
            // 
            // passwordText
            // 
            this.passwordText.Location = new System.Drawing.Point(689, 655);
            this.passwordText.Name = "passwordText";
            this.passwordText.Size = new System.Drawing.Size(236, 35);
            this.passwordText.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(551, 416);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 24);
            this.label6.TabIndex = 11;
            this.label6.Text = "Reserved";
            // 
            // reservedText
            // 
            this.reservedText.Location = new System.Drawing.Point(689, 413);
            this.reservedText.Name = "reservedText";
            this.reservedText.Size = new System.Drawing.Size(236, 35);
            this.reservedText.TabIndex = 12;
            // 
            // GUID
            // 
            this.GUID.AutoSize = true;
            this.GUID.Location = new System.Drawing.Point(551, 815);
            this.GUID.Name = "GUID";
            this.GUID.Size = new System.Drawing.Size(58, 24);
            this.GUID.TabIndex = 13;
            this.GUID.Text = "GUID";
            // 
            // guidText
            // 
            this.guidText.Location = new System.Drawing.Point(689, 812);
            this.guidText.Name = "guidText";
            this.guidText.Size = new System.Drawing.Size(236, 35);
            this.guidText.TabIndex = 14;
            // 
            // swapRadio
            // 
            this.swapRadio.AutoSize = true;
            this.swapRadio.Location = new System.Drawing.Point(555, 972);
            this.swapRadio.Name = "swapRadio";
            this.swapRadio.Size = new System.Drawing.Size(89, 28);
            this.swapRadio.TabIndex = 15;
            this.swapRadio.TabStop = true;
            this.swapRadio.Text = "Swap";
            this.swapRadio.UseVisualStyleBackColor = true;
            this.swapRadio.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // addRadio
            // 
            this.addRadio.AutoSize = true;
            this.addRadio.Location = new System.Drawing.Point(848, 972);
            this.addRadio.Name = "addRadio";
            this.addRadio.Size = new System.Drawing.Size(77, 28);
            this.addRadio.TabIndex = 16;
            this.addRadio.TabStop = true;
            this.addRadio.Text = "Add";
            this.addRadio.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1528, 1502);
            this.Controls.Add(this.addRadio);
            this.Controls.Add(this.swapRadio);
            this.Controls.Add(this.guidText);
            this.Controls.Add(this.GUID);
            this.Controls.Add(this.reservedText);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.passwordText);
            this.Controls.Add(this.userText);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.sectionText);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numberText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.subjectText);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox subjectText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox numberText;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox sectionText;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox userText;
        private System.Windows.Forms.TextBox passwordText;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox reservedText;
        private System.Windows.Forms.Label GUID;
        private System.Windows.Forms.TextBox guidText;
        private System.Windows.Forms.RadioButton swapRadio;
        private System.Windows.Forms.RadioButton addRadio;
    }
}

