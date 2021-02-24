namespace DBTest
{
    partial class View
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
            this.txt_imagepath = new System.Windows.Forms.TextBox();
            this.btn_loadimage = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label9 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.btn_loaddata = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_search_filternames = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_age1 = new System.Windows.Forms.TextBox();
            this.txt_age2 = new System.Windows.Forms.TextBox();
            this.btn_age_filtering = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_imagepath
            // 
            this.txt_imagepath.Location = new System.Drawing.Point(133, 441);
            this.txt_imagepath.Name = "txt_imagepath";
            this.txt_imagepath.Size = new System.Drawing.Size(179, 20);
            this.txt_imagepath.TabIndex = 60;
            // 
            // btn_loadimage
            // 
            this.btn_loadimage.Location = new System.Drawing.Point(511, 467);
            this.btn_loadimage.Name = "btn_loadimage";
            this.btn_loadimage.Size = new System.Drawing.Size(75, 23);
            this.btn_loadimage.TabIndex = 59;
            this.btn_loadimage.Text = "Load Image";
            this.btn_loadimage.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(380, 296);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(288, 165);
            this.pictureBox1.TabIndex = 58;
            this.pictureBox1.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(49, 90);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 13);
            this.label9.TabIndex = 57;
            this.label9.Text = "Filter Names";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.comboBox2.Location = new System.Drawing.Point(26, 66);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 56;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(62, 35);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 13);
            this.label6.TabIndex = 49;
            this.label6.Text = "Search";
            // 
            // txt_search
            // 
            this.txt_search.Location = new System.Drawing.Point(26, 12);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(121, 20);
            this.txt_search.TabIndex = 48;
            this.txt_search.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_search_KeyUp);
            // 
            // btn_loaddata
            // 
            this.btn_loaddata.Location = new System.Drawing.Point(499, 211);
            this.btn_loaddata.Name = "btn_loaddata";
            this.btn_loaddata.Size = new System.Drawing.Size(75, 23);
            this.btn_loaddata.TabIndex = 47;
            this.btn_loaddata.Text = "Load Data";
            this.btn_loaddata.UseVisualStyleBackColor = true;
            this.btn_loaddata.Click += new System.EventHandler(this.btn_loaddata_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(288, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(483, 184);
            this.dataGridView1.TabIndex = 46;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.dataGridView1_KeyUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 141);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 62;
            this.label1.Text = "Search with Filter";
            // 
            // txt_search_filternames
            // 
            this.txt_search_filternames.Location = new System.Drawing.Point(26, 118);
            this.txt_search_filternames.Name = "txt_search_filternames";
            this.txt_search_filternames.Size = new System.Drawing.Size(121, 20);
            this.txt_search_filternames.TabIndex = 61;
            this.txt_search_filternames.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_search_filternames_KeyUp);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 438);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 63;
            this.button1.Text = "Reset";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(73, 338);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 65;
            this.label2.Text = "Age Filtering";
            // 
            // txt_age1
            // 
            this.txt_age1.Location = new System.Drawing.Point(26, 315);
            this.txt_age1.Name = "txt_age1";
            this.txt_age1.Size = new System.Drawing.Size(67, 20);
            this.txt_age1.TabIndex = 64;
            // 
            // txt_age2
            // 
            this.txt_age2.Location = new System.Drawing.Point(121, 315);
            this.txt_age2.Name = "txt_age2";
            this.txt_age2.Size = new System.Drawing.Size(70, 20);
            this.txt_age2.TabIndex = 66;
            // 
            // btn_age_filtering
            // 
            this.btn_age_filtering.Location = new System.Drawing.Point(65, 354);
            this.btn_age_filtering.Name = "btn_age_filtering";
            this.btn_age_filtering.Size = new System.Drawing.Size(75, 23);
            this.btn_age_filtering.TabIndex = 67;
            this.btn_age_filtering.Text = "Age";
            this.btn_age_filtering.UseVisualStyleBackColor = true;
            this.btn_age_filtering.Click += new System.EventHandler(this.btn_age_filtering_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Select ALL"});
            this.comboBox1.Location = new System.Drawing.Point(44, 266);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 68;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(87, 290);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 69;
            this.label3.Text = "Gender";
            // 
            // View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 516);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btn_age_filtering);
            this.Controls.Add(this.txt_age2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_age1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_search_filternames);
            this.Controls.Add(this.txt_imagepath);
            this.Controls.Add(this.btn_loadimage);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_search);
            this.Controls.Add(this.btn_loaddata);
            this.Controls.Add(this.dataGridView1);
            this.Name = "View";
            this.Text = "View";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_imagepath;
        private System.Windows.Forms.Button btn_loadimage;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.Button btn_loaddata;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_search_filternames;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_age1;
        private System.Windows.Forms.TextBox txt_age2;
        private System.Windows.Forms.Button btn_age_filtering;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label3;
    }
}