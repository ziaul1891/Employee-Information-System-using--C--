namespace DBTest
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
            this.oldpass_txt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.confirm_btn = new System.Windows.Forms.Button();
            this.oldname_txt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.newpass_txt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_backtologin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // oldpass_txt
            // 
            this.oldpass_txt.Location = new System.Drawing.Point(147, 83);
            this.oldpass_txt.Name = "oldpass_txt";
            this.oldpass_txt.PasswordChar = '*';
            this.oldpass_txt.Size = new System.Drawing.Size(100, 20);
            this.oldpass_txt.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Current Password";
            // 
            // confirm_btn
            // 
            this.confirm_btn.Location = new System.Drawing.Point(103, 177);
            this.confirm_btn.Name = "confirm_btn";
            this.confirm_btn.Size = new System.Drawing.Size(68, 26);
            this.confirm_btn.TabIndex = 3;
            this.confirm_btn.Text = "Confirm";
            this.confirm_btn.UseVisualStyleBackColor = true;
            this.confirm_btn.Click += new System.EventHandler(this.confirm_btn_Click);
            // 
            // oldname_txt
            // 
            this.oldname_txt.Location = new System.Drawing.Point(147, 46);
            this.oldname_txt.Name = "oldname_txt";
            this.oldname_txt.Size = new System.Drawing.Size(100, 20);
            this.oldname_txt.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Current Username";
            // 
            // newpass_txt
            // 
            this.newpass_txt.Location = new System.Drawing.Point(147, 122);
            this.newpass_txt.Name = "newpass_txt";
            this.newpass_txt.PasswordChar = '*';
            this.newpass_txt.Size = new System.Drawing.Size(100, 20);
            this.newpass_txt.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "New Password";
            // 
            // btn_backtologin
            // 
            this.btn_backtologin.Location = new System.Drawing.Point(172, 226);
            this.btn_backtologin.Name = "btn_backtologin";
            this.btn_backtologin.Size = new System.Drawing.Size(100, 23);
            this.btn_backtologin.TabIndex = 8;
            this.btn_backtologin.Text = "Back to Login";
            this.btn_backtologin.UseVisualStyleBackColor = true;
            this.btn_backtologin.Click += new System.EventHandler(this.btn_backtologin_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btn_backtologin);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.newpass_txt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.oldname_txt);
            this.Controls.Add(this.confirm_btn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.oldpass_txt);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox oldpass_txt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button confirm_btn;
        private System.Windows.Forms.TextBox oldname_txt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox newpass_txt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_backtologin;
    }
}