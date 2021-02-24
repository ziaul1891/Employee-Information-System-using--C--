namespace EM
{
    partial class Admin_generalinfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin_generalinfo));
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.efname_txt = new System.Windows.Forms.TextBox();
            this.elname_txt = new System.Windows.Forms.TextBox();
            this.eage_txt = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_loaddata = new System.Windows.Forms.Button();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.radiobtn_male = new System.Windows.Forms.RadioButton();
            this.radiobtn_female = new System.Windows.Forms.RadioButton();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_imagepath = new System.Windows.Forms.TextBox();
            this.eid_txt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_workinformation = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_search1 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.button_logout = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.button_clear = new System.Windows.Forms.Button();
            this.btn_loadimage = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.ephone_txt = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "First Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Last Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 190);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Age";
            // 
            // efname_txt
            // 
            this.efname_txt.Location = new System.Drawing.Point(107, 115);
            this.efname_txt.Name = "efname_txt";
            this.efname_txt.Size = new System.Drawing.Size(100, 20);
            this.efname_txt.TabIndex = 5;
            // 
            // elname_txt
            // 
            this.elname_txt.Location = new System.Drawing.Point(107, 154);
            this.elname_txt.Name = "elname_txt";
            this.elname_txt.Size = new System.Drawing.Size(100, 20);
            this.elname_txt.TabIndex = 6;
            // 
            // eage_txt
            // 
            this.eage_txt.Location = new System.Drawing.Point(107, 187);
            this.eage_txt.Name = "eage_txt";
            this.eage_txt.Size = new System.Drawing.Size(100, 20);
            this.eage_txt.TabIndex = 7;
            this.eage_txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.eage_txt_KeyPress);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(411, 115);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(449, 184);
            this.dataGridView1.TabIndex = 16;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.dataGridView1_KeyUp);
            // 
            // btn_loaddata
            // 
            this.btn_loaddata.Location = new System.Drawing.Point(785, 310);
            this.btn_loaddata.Name = "btn_loaddata";
            this.btn_loaddata.Size = new System.Drawing.Size(75, 23);
            this.btn_loaddata.TabIndex = 17;
            this.btn_loaddata.Text = "Load Data";
            this.btn_loaddata.UseVisualStyleBackColor = true;
            this.btn_loaddata.Click += new System.EventHandler(this.btn_loaddata_Click);
            // 
            // txt_search
            // 
            this.txt_search.Location = new System.Drawing.Point(661, 310);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(100, 20);
            this.txt_search.TabIndex = 18;
            this.txt_search.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_search_KeyUp);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(670, 332);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "Search  (Name)";
            // 
            // radiobtn_male
            // 
            this.radiobtn_male.AutoSize = true;
            this.radiobtn_male.Location = new System.Drawing.Point(76, 230);
            this.radiobtn_male.Name = "radiobtn_male";
            this.radiobtn_male.Size = new System.Drawing.Size(48, 17);
            this.radiobtn_male.TabIndex = 20;
            this.radiobtn_male.TabStop = true;
            this.radiobtn_male.Text = "Male";
            this.radiobtn_male.UseVisualStyleBackColor = true;
            this.radiobtn_male.CheckedChanged += new System.EventHandler(this.radiobtn_male_CheckedChanged);
            // 
            // radiobtn_female
            // 
            this.radiobtn_female.AutoSize = true;
            this.radiobtn_female.Location = new System.Drawing.Point(148, 230);
            this.radiobtn_female.Name = "radiobtn_female";
            this.radiobtn_female.Size = new System.Drawing.Size(59, 17);
            this.radiobtn_female.TabIndex = 21;
            this.radiobtn_female.TabStop = true;
            this.radiobtn_female.Text = "Female";
            this.radiobtn_female.UseVisualStyleBackColor = true;
            this.radiobtn_female.CheckedChanged += new System.EventHandler(this.radiobtn_female_CheckedChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.CustomFormat = "yyyy-MM-dd";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(102, 303);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(100, 20);
            this.dateTimePicker1.TabIndex = 22;
            this.dateTimePicker1.Value = new System.DateTime(2014, 11, 3, 22, 16, 36, 0);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 232);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 13);
            this.label7.TabIndex = 23;
            this.label7.Text = "Gender :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 310);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 13);
            this.label8.TabIndex = 24;
            this.label8.Text = "Date of Birth :\r\n";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(413, 309);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(109, 21);
            this.comboBox2.TabIndex = 26;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(429, 333);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(93, 13);
            this.label9.TabIndex = 27;
            this.label9.Text = "Dropdown Search";
            // 
            // txt_imagepath
            // 
            this.txt_imagepath.Location = new System.Drawing.Point(227, 309);
            this.txt_imagepath.Name = "txt_imagepath";
            this.txt_imagepath.Size = new System.Drawing.Size(153, 20);
            this.txt_imagepath.TabIndex = 30;
            this.txt_imagepath.Visible = false;
            // 
            // eid_txt
            // 
            this.eid_txt.Location = new System.Drawing.Point(107, 57);
            this.eid_txt.Name = "eid_txt";
            this.eid_txt.Size = new System.Drawing.Size(100, 20);
            this.eid_txt.TabIndex = 31;
            this.eid_txt.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 32;
            this.label1.Text = "ID";
            this.label1.Visible = false;
            // 
            // btn_workinformation
            // 
            this.btn_workinformation.Location = new System.Drawing.Point(11, 457);
            this.btn_workinformation.Name = "btn_workinformation";
            this.btn_workinformation.Size = new System.Drawing.Size(102, 23);
            this.btn_workinformation.TabIndex = 33;
            this.btn_workinformation.Text = "Work Information";
            this.btn_workinformation.UseVisualStyleBackColor = true;
            this.btn_workinformation.Click += new System.EventHandler(this.btn_workinformation_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(560, 331);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(64, 13);
            this.label10.TabIndex = 35;
            this.label10.Text = "Search  (ID)";
            // 
            // txt_search1
            // 
            this.txt_search1.Location = new System.Drawing.Point(542, 309);
            this.txt_search1.Name = "txt_search1";
            this.txt_search1.Size = new System.Drawing.Size(100, 20);
            this.txt_search1.TabIndex = 34;
            this.txt_search1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_search1_KeyUp);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(241, 268);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(122, 13);
            this.label11.TabIndex = 36;
            this.label11.Text = "Photo must be 150 x150";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Monotype Corsiva", 27.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(236, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(291, 45);
            this.label5.TabIndex = 37;
            this.label5.Text = "General Information";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label12.Location = new System.Drawing.Point(573, 79);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(155, 24);
            this.label12.TabIndex = 38;
            this.label12.Text = "Information Table";
            this.label12.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // button_logout
            // 
            this.button_logout.Image = ((System.Drawing.Image)(resources.GetObject("button_logout.Image")));
            this.button_logout.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_logout.Location = new System.Drawing.Point(790, 12);
            this.button_logout.Name = "button_logout";
            this.button_logout.Size = new System.Drawing.Size(82, 23);
            this.button_logout.TabIndex = 43;
            this.button_logout.Text = "Log Out";
            this.button_logout.UseVisualStyleBackColor = true;
            this.button_logout.Click += new System.EventHandler(this.button_logout_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(730, 79);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(31, 30);
            this.pictureBox3.TabIndex = 42;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(542, 79);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(31, 30);
            this.pictureBox2.TabIndex = 41;
            this.pictureBox2.TabStop = false;
            // 
            // button_clear
            // 
            this.button_clear.Image = ((System.Drawing.Image)(resources.GetObject("button_clear.Image")));
            this.button_clear.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_clear.Location = new System.Drawing.Point(107, 395);
            this.button_clear.Name = "button_clear";
            this.button_clear.Size = new System.Drawing.Size(75, 27);
            this.button_clear.TabIndex = 39;
            this.button_clear.Text = "Clear";
            this.button_clear.UseVisualStyleBackColor = true;
            this.button_clear.Click += new System.EventHandler(this.button_clear_Click);
            // 
            // btn_loadimage
            // 
            this.btn_loadimage.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_loadimage.Image = ((System.Drawing.Image)(resources.GetObject("btn_loadimage.Image")));
            this.btn_loadimage.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_loadimage.Location = new System.Drawing.Point(270, 284);
            this.btn_loadimage.Name = "btn_loadimage";
            this.btn_loadimage.Size = new System.Drawing.Size(73, 23);
            this.btn_loadimage.TabIndex = 29;
            this.btn_loadimage.Text = "Photo";
            this.btn_loadimage.UseVisualStyleBackColor = true;
            this.btn_loadimage.Click += new System.EventHandler(this.btn_loadimage_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.ErrorImage")));
            this.pictureBox1.Location = new System.Drawing.Point(230, 115);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 150);
            this.pictureBox1.TabIndex = 28;
            this.pictureBox1.TabStop = false;
            // 
            // btn_delete
            // 
            this.btn_delete.Image = ((System.Drawing.Image)(resources.GetObject("btn_delete.Image")));
            this.btn_delete.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_delete.Location = new System.Drawing.Point(16, 395);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(75, 29);
            this.btn_delete.TabIndex = 12;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_update
            // 
            this.btn_update.Image = ((System.Drawing.Image)(resources.GetObject("btn_update.Image")));
            this.btn_update.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_update.Location = new System.Drawing.Point(107, 353);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(75, 28);
            this.btn_update.TabIndex = 9;
            this.btn_update.Text = "Update";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_save
            // 
            this.btn_save.Image = ((System.Drawing.Image)(resources.GetObject("btn_save.Image")));
            this.btn_save.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_save.Location = new System.Drawing.Point(16, 353);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(75, 27);
            this.btn_save.TabIndex = 8;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.button1_Click);
            // 
            // ephone_txt
            // 
            this.ephone_txt.Location = new System.Drawing.Point(107, 266);
            this.ephone_txt.Name = "ephone_txt";
            this.ephone_txt.Size = new System.Drawing.Size(100, 20);
            this.ephone_txt.TabIndex = 45;
            this.ephone_txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ephone_txt_KeyPress);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(18, 269);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(38, 13);
            this.label14.TabIndex = 44;
            this.label14.Text = "Phone";
            // 
            // Admin_generalinfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 498);
            this.Controls.Add(this.ephone_txt);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.button_logout);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.button_clear);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txt_search1);
            this.Controls.Add(this.btn_workinformation);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.eid_txt);
            this.Controls.Add(this.txt_imagepath);
            this.Controls.Add(this.btn_loadimage);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.radiobtn_female);
            this.Controls.Add(this.radiobtn_male);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_search);
            this.Controls.Add(this.btn_loaddata);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.eage_txt);
            this.Controls.Add(this.elname_txt);
            this.Controls.Add(this.efname_txt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Admin_generalinfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin - General Information";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox efname_txt;
        private System.Windows.Forms.TextBox elname_txt;
        private System.Windows.Forms.TextBox eage_txt;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_loaddata;
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton radiobtn_male;
        private System.Windows.Forms.RadioButton radiobtn_female;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_loadimage;
        private System.Windows.Forms.TextBox txt_imagepath;
        private System.Windows.Forms.TextBox eid_txt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_workinformation;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_search1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button button_clear;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button button_logout;
        private System.Windows.Forms.TextBox ephone_txt;
        private System.Windows.Forms.Label label14;
    }
}