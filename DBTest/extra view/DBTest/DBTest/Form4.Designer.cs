namespace DBTest
{
    partial class Form4
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
            this.label3 = new System.Windows.Forms.Label();
            this.newpass_txt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.oldname_txt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_special = new System.Windows.Forms.TextBox();
            this.btn_backtologin = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.confirmpass_txt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(101, 197);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Confirm";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "New Password";
            // 
            // newpass_txt
            // 
            this.newpass_txt.Location = new System.Drawing.Point(144, 117);
            this.newpass_txt.Name = "newpass_txt";
            this.newpass_txt.PasswordChar = '*';
            this.newpass_txt.Size = new System.Drawing.Size(100, 20);
            this.newpass_txt.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Current Username";
            // 
            // oldname_txt
            // 
            this.oldname_txt.Location = new System.Drawing.Point(144, 41);
            this.oldname_txt.Name = "oldname_txt";
            this.oldname_txt.Size = new System.Drawing.Size(100, 20);
            this.oldname_txt.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Speical";
            // 
            // txt_special
            // 
            this.txt_special.Location = new System.Drawing.Point(144, 78);
            this.txt_special.Name = "txt_special";
            this.txt_special.PasswordChar = '*';
            this.txt_special.Size = new System.Drawing.Size(100, 20);
            this.txt_special.TabIndex = 15;
            // 
            // btn_backtologin
            // 
            this.btn_backtologin.Location = new System.Drawing.Point(183, 236);
            this.btn_backtologin.Name = "btn_backtologin";
            this.btn_backtologin.Size = new System.Drawing.Size(100, 23);
            this.btn_backtologin.TabIndex = 16;
            this.btn_backtologin.Text = "Back to Login";
            this.btn_backtologin.UseVisualStyleBackColor = true;
            this.btn_backtologin.Click += new System.EventHandler(this.btn_backtologin_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Confirm Password";
            // 
            // confirmpass_txt
            // 
            this.confirmpass_txt.Location = new System.Drawing.Point(144, 158);
            this.confirmpass_txt.Name = "confirmpass_txt";
            this.confirmpass_txt.PasswordChar = '*';
            this.confirmpass_txt.Size = new System.Drawing.Size(100, 20);
            this.confirmpass_txt.TabIndex = 18;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.confirmpass_txt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_backtologin);
            this.Controls.Add(this.txt_special);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.newpass_txt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.oldname_txt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "Form4";
            this.Text = "Form4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox newpass_txt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox oldname_txt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_special;
        private System.Windows.Forms.Button btn_backtologin;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox confirmpass_txt;
    }
}