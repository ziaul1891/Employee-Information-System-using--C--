namespace EM
{
    partial class MainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_viewer_mainmenu = new System.Windows.Forms.Button();
            this.btn_admin_mainmenu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(61, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(428, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Employee Management System";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(137, 216);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Admin";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(387, 216);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Viewer";
            // 
            // btn_viewer_mainmenu
            // 
            this.btn_viewer_mainmenu.Image = ((System.Drawing.Image)(resources.GetObject("btn_viewer_mainmenu.Image")));
            this.btn_viewer_mainmenu.Location = new System.Drawing.Point(314, 82);
            this.btn_viewer_mainmenu.Name = "btn_viewer_mainmenu";
            this.btn_viewer_mainmenu.Size = new System.Drawing.Size(175, 124);
            this.btn_viewer_mainmenu.TabIndex = 2;
            this.btn_viewer_mainmenu.UseVisualStyleBackColor = true;
            this.btn_viewer_mainmenu.Click += new System.EventHandler(this.btn_viewer_mainmenu_Click);
            // 
            // btn_admin_mainmenu
            // 
            this.btn_admin_mainmenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_admin_mainmenu.Image = ((System.Drawing.Image)(resources.GetObject("btn_admin_mainmenu.Image")));
            this.btn_admin_mainmenu.Location = new System.Drawing.Point(67, 82);
            this.btn_admin_mainmenu.Name = "btn_admin_mainmenu";
            this.btn_admin_mainmenu.Size = new System.Drawing.Size(175, 124);
            this.btn_admin_mainmenu.TabIndex = 1;
            this.btn_admin_mainmenu.UseVisualStyleBackColor = true;
            this.btn_admin_mainmenu.Click += new System.EventHandler(this.btn_admin_mainmenu_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 285);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_viewer_mainmenu);
            this.Controls.Add(this.btn_admin_mainmenu);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Employee Management System";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_admin_mainmenu;
        private System.Windows.Forms.Button btn_viewer_mainmenu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}