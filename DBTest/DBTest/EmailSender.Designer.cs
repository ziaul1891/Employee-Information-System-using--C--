namespace EM
{
    partial class EmailSender
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_from = new System.Windows.Forms.TextBox();
            this.txt_to = new System.Windows.Forms.TextBox();
            this.txt_subject = new System.Windows.Forms.TextBox();
            this.txt_SMTP = new System.Windows.Forms.TextBox();
            this.body = new System.Windows.Forms.RichTextBox();
            this.btn_send = new System.Windows.Forms.Button();
            this.txt_pass = new System.Windows.Forms.TextBox();
            this.Password = new System.Windows.Forms.Label();
            this.btn_gmail = new System.Windows.Forms.Button();
            this.btn_yahoo = new System.Windows.Forms.Button();
            this.txt_port = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_clear = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_attachment1 = new System.Windows.Forms.TextBox();
            this.txt_attachment2 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_attachment3 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.button_logout = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(301, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "From";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(301, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "To";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(301, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Subject";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(301, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Provider";
            // 
            // txt_from
            // 
            this.txt_from.Location = new System.Drawing.Point(362, 95);
            this.txt_from.Name = "txt_from";
            this.txt_from.Size = new System.Drawing.Size(150, 20);
            this.txt_from.TabIndex = 6;
            // 
            // txt_to
            // 
            this.txt_to.Location = new System.Drawing.Point(362, 131);
            this.txt_to.Name = "txt_to";
            this.txt_to.Size = new System.Drawing.Size(150, 20);
            this.txt_to.TabIndex = 7;
            // 
            // txt_subject
            // 
            this.txt_subject.Location = new System.Drawing.Point(362, 172);
            this.txt_subject.Name = "txt_subject";
            this.txt_subject.Size = new System.Drawing.Size(150, 20);
            this.txt_subject.TabIndex = 8;
            // 
            // txt_SMTP
            // 
            this.txt_SMTP.Location = new System.Drawing.Point(362, 62);
            this.txt_SMTP.Name = "txt_SMTP";
            this.txt_SMTP.Size = new System.Drawing.Size(107, 20);
            this.txt_SMTP.TabIndex = 9;
            this.txt_SMTP.Visible = false;
            // 
            // body
            // 
            this.body.Location = new System.Drawing.Point(28, 62);
            this.body.Name = "body";
            this.body.Size = new System.Drawing.Size(216, 163);
            this.body.TabIndex = 12;
            this.body.Text = "";
            // 
            // btn_send
            // 
            this.btn_send.Location = new System.Drawing.Point(362, 285);
            this.btn_send.Name = "btn_send";
            this.btn_send.Size = new System.Drawing.Size(75, 23);
            this.btn_send.TabIndex = 13;
            this.btn_send.Text = "Send";
            this.btn_send.UseVisualStyleBackColor = true;
            this.btn_send.Click += new System.EventHandler(this.btn_send_Click);
            // 
            // txt_pass
            // 
            this.txt_pass.Location = new System.Drawing.Point(362, 208);
            this.txt_pass.Name = "txt_pass";
            this.txt_pass.PasswordChar = '*';
            this.txt_pass.Size = new System.Drawing.Size(150, 20);
            this.txt_pass.TabIndex = 15;
            // 
            // Password
            // 
            this.Password.AutoSize = true;
            this.Password.Location = new System.Drawing.Point(301, 211);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(53, 13);
            this.Password.TabIndex = 14;
            this.Password.Text = "Password";
            // 
            // btn_gmail
            // 
            this.btn_gmail.Location = new System.Drawing.Point(362, 59);
            this.btn_gmail.Name = "btn_gmail";
            this.btn_gmail.Size = new System.Drawing.Size(75, 23);
            this.btn_gmail.TabIndex = 16;
            this.btn_gmail.Text = "Gmail";
            this.btn_gmail.UseVisualStyleBackColor = true;
            this.btn_gmail.Click += new System.EventHandler(this.btn_gmail_Click);
            // 
            // btn_yahoo
            // 
            this.btn_yahoo.Location = new System.Drawing.Point(443, 59);
            this.btn_yahoo.Name = "btn_yahoo";
            this.btn_yahoo.Size = new System.Drawing.Size(75, 23);
            this.btn_yahoo.TabIndex = 17;
            this.btn_yahoo.Text = "Yahoo";
            this.btn_yahoo.UseVisualStyleBackColor = true;
            this.btn_yahoo.Click += new System.EventHandler(this.btn_yahoo_Click);
            // 
            // txt_port
            // 
            this.txt_port.Location = new System.Drawing.Point(475, 62);
            this.txt_port.Name = "txt_port";
            this.txt_port.Size = new System.Drawing.Size(37, 20);
            this.txt_port.TabIndex = 18;
            this.txt_port.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(90, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Write your mail here";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(205, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(149, 33);
            this.label6.TabIndex = 20;
            this.label6.Text = "Send E-Mail";
            // 
            // btn_clear
            // 
            this.btn_clear.Location = new System.Drawing.Point(443, 285);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(69, 23);
            this.btn_clear.TabIndex = 21;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(25, 248);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 13);
            this.label7.TabIndex = 22;
            this.label7.Text = "Attachment #1";
            // 
            // txt_attachment1
            // 
            this.txt_attachment1.Location = new System.Drawing.Point(108, 245);
            this.txt_attachment1.Name = "txt_attachment1";
            this.txt_attachment1.Size = new System.Drawing.Size(136, 20);
            this.txt_attachment1.TabIndex = 23;
            this.txt_attachment1.Click += new System.EventHandler(this.txt_attachment_Click);
            // 
            // txt_attachment2
            // 
            this.txt_attachment2.Location = new System.Drawing.Point(108, 272);
            this.txt_attachment2.Name = "txt_attachment2";
            this.txt_attachment2.Size = new System.Drawing.Size(136, 20);
            this.txt_attachment2.TabIndex = 25;
            this.txt_attachment2.Click += new System.EventHandler(this.txt_attachment2_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(25, 275);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 13);
            this.label8.TabIndex = 24;
            this.label8.Text = "Attachment #2";
            // 
            // txt_attachment3
            // 
            this.txt_attachment3.Location = new System.Drawing.Point(108, 298);
            this.txt_attachment3.Name = "txt_attachment3";
            this.txt_attachment3.Size = new System.Drawing.Size(136, 20);
            this.txt_attachment3.TabIndex = 27;
            this.txt_attachment3.Click += new System.EventHandler(this.txt_attachment3_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(24, 301);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 13);
            this.label9.TabIndex = 26;
            this.label9.Text = "Attachment #3";
            // 
            // button_logout
            // 
            this.button_logout.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_logout.Location = new System.Drawing.Point(515, 9);
            this.button_logout.Name = "button_logout";
            this.button_logout.Size = new System.Drawing.Size(82, 23);
            this.button_logout.TabIndex = 55;
            this.button_logout.Text = "Admin Menu";
            this.button_logout.UseVisualStyleBackColor = true;
            this.button_logout.Click += new System.EventHandler(this.button_logout_Click);
            // 
            // EmailSender
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 342);
            this.Controls.Add(this.button_logout);
            this.Controls.Add(this.txt_attachment3);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txt_attachment2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txt_attachment1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_port);
            this.Controls.Add(this.btn_yahoo);
            this.Controls.Add(this.btn_gmail);
            this.Controls.Add(this.txt_pass);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.btn_send);
            this.Controls.Add(this.body);
            this.Controls.Add(this.txt_SMTP);
            this.Controls.Add(this.txt_subject);
            this.Controls.Add(this.txt_to);
            this.Controls.Add(this.txt_from);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "EmailSender";
            this.Text = " ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_from;
        private System.Windows.Forms.TextBox txt_to;
        private System.Windows.Forms.TextBox txt_subject;
        private System.Windows.Forms.TextBox txt_SMTP;
        private System.Windows.Forms.RichTextBox body;
        private System.Windows.Forms.Button btn_send;
        private System.Windows.Forms.TextBox txt_pass;
        private System.Windows.Forms.Label Password;
        private System.Windows.Forms.Button btn_gmail;
        private System.Windows.Forms.Button btn_yahoo;
        private System.Windows.Forms.TextBox txt_port;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_attachment1;
        private System.Windows.Forms.TextBox txt_attachment2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_attachment3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button_logout;
    }
}