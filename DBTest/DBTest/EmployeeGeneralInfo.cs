using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Security.Cryptography;
using System.IO;
using System.Data.SqlClient;


namespace EM
{
    public partial class EmployeeGeneralInfo : Form
    {
        public EmployeeGeneralInfo()
        {
           
            InitializeComponent();
            AutoCompleteText();
            
          Fillcombo();
           
            load_table();
        }

        DataTable dbdataset;
       
        void load_table()
        {
            string constring = "Server= (local)\\SQLEXPRESS; Database= Connection;User ID=sa;Password=p@ssword13";
            SqlConnection conDatabase = new SqlConnection(constring);

            SqlCommand cmdDatabase = new SqlCommand("Select Eid,E_fname,E_lname,E_age,E_gender,E_dob,E_phone,E_image from e_info;", conDatabase);

            try
            {
                SqlDataAdapter sda = new SqlDataAdapter();
                sda.SelectCommand = cmdDatabase;
                DataTable dbdataset = new DataTable();
                sda.Fill(dbdataset);
                BindingSource bSource = new BindingSource();
                bSource.DataSource = dbdataset;
                dataGridView1.DataSource = bSource;
                sda.Update(dbdataset);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        


        private void btn_loaddata_Click(object sender, EventArgs e)
        {
            load_table();
        }













        private void txt_search_KeyUp(object sender, KeyEventArgs e)
        {
            string constring = "Server= (local)\\SQLEXPRESS; Database= Connection;User ID=sa;Password=p@ssword13";
            SqlConnection conDatabase = new SqlConnection(constring);

            //MySqlCommand cmdDatabase = new MySqlCommand("Select *from login.e_info;" , conDatabase);
            SqlCommand cmdDatabase = new SqlCommand("Select Eid,E_fname,E_lname,E_age,E_gender,E_dob,E_phone,E_image from e_info where E_fname LIKE '" + txt_search.Text + "%' OR E_lname LIKE '" + txt_search.Text + "%';", conDatabase);

            try
            {
                SqlDataAdapter sda = new SqlDataAdapter();
                sda.SelectCommand = cmdDatabase;
                dbdataset = new DataTable();
                sda.Fill(dbdataset);
                BindingSource bSource = new BindingSource();
                bSource.DataSource = dbdataset;
                dataGridView1.DataSource = bSource;
                sda.Update(dbdataset);
                txt_search1.Text = "";
                comboBox2.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        

        private void eage_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        void AutoCompleteText()
        {
            txt_search.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txt_search.AutoCompleteSource = AutoCompleteSource.CustomSource;
            AutoCompleteStringCollection coll = new AutoCompleteStringCollection();

            string constring = "Server= (local)\\SQLEXPRESS; Database= Connection;User ID=sa;Password=p@ssword13";
            string Query = "select *from e_info";
            SqlConnection conDatabase = new SqlConnection(constring);
            SqlCommand cmdDatabase = new SqlCommand(Query, conDatabase);
            SqlDataReader myReader;
            try
            {
                conDatabase.Open();
                myReader = cmdDatabase.ExecuteReader();


                while (myReader.Read())
                {

                    string sName = myReader.GetString(1);
                    string sName2 = myReader.GetString(2);
                    coll.Add(sName);
                    coll.Add(sName2);



                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            txt_search.AutoCompleteCustomSource = coll;

        }



        
        private void btn_loadimage_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "JPG Files(*.jpg)|*jpg|PNG Files(*.png)|*png|All Files(*.*)|*.*";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                string picpath = dlg.FileName.ToString();



 

                pictureBox1.ImageLocation = picpath;

            }
        }

       
        private void btn_workinformation_Click(object sender, EventArgs e)
        {
            this.Hide();
            Admin_workinfo f4 = new Admin_workinfo();
            f4.ShowDialog();
            this.Close();
        }



        private void txt_search1_KeyUp(object sender, KeyEventArgs e)
        {
            string constring = "Server= (local)\\SQLEXPRESS; Database= Connection;User ID=sa;Password=p@ssword13";
            SqlConnection conDatabase = new SqlConnection(constring);

            //MySqlCommand cmdDatabase = new MySqlCommand("Select *from login.e_info;" , conDatabase);
            SqlCommand cmdDatabase = new SqlCommand("Select Eid,E_fname,E_lname,E_age,E_gender,E_dob,E_phone,E_image from e_info where Eid LIKE '" + txt_search1.Text + "%';", conDatabase);

            try
            {
                SqlDataAdapter sda = new SqlDataAdapter();
                sda.SelectCommand = cmdDatabase;
                dbdataset = new DataTable();
                sda.Fill(dbdataset);
                BindingSource bSource = new BindingSource();
                bSource.DataSource = dbdataset;
                dataGridView1.DataSource = bSource;
                sda.Update(dbdataset);
                txt_search.Text = "";
                comboBox2.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        void clearall()
        {
           
           
            pictureBox1.Image = null;
           
            comboBox2.Text = "";
            txt_search.Text = "";
            txt_search1.Text = "";
          
            load_table();
        }

        private void button_clear_Click(object sender, EventArgs e)
        {
            clearall();
        }

        private void button_logout_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainMenu f1 = new MainMenu();
            f1.ShowDialog();
            this.Close();
        }

        private void ephone_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void comboBox2_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            string constring = "Server= (local)\\SQLEXPRESS; Database= Connection;User ID=sa;Password=p@ssword13";
            string Query = "select *from e_info where E_fname='" + comboBox2.Text + "';";
            SqlConnection conDatabase = new SqlConnection(constring);
            SqlCommand cmdDatabase = new SqlCommand(Query, conDatabase);
            SqlDataReader myReader;
            try
            {
                conDatabase.Open();
                myReader = cmdDatabase.ExecuteReader();

               









                string constring2 = "Server= (local)\\SQLEXPRESS; Database= Connection;User ID=sa;Password=p@ssword13";
                SqlConnection conDatabase2 = new SqlConnection(constring2);

                SqlCommand cmdDatabase2 = new SqlCommand("select Eid,E_fname,E_lname,E_age,E_gender,E_dob,E_phone,E_image from e_info where E_fname='" + comboBox2.Text + "';", conDatabase2);


                SqlDataAdapter sda = new SqlDataAdapter();
                sda.SelectCommand = cmdDatabase2;
                dbdataset = new DataTable();
                sda.Fill(dbdataset);
                BindingSource bSource = new BindingSource();
                bSource.DataSource = dbdataset;
                dataGridView1.DataSource = bSource;
                sda.Update(dbdataset);
                txt_search.Text = "";
                txt_search1.Text = "";
                while (myReader.Read())
                {

                    string sEid = myReader.GetInt32(0).ToString();
                    string sEfname = myReader.GetString(1);
                    string sElname = myReader.GetString(2);
                    string sEage = myReader.GetInt32(3).ToString();
                    string sEgender = myReader.GetString(4).ToString();
                    string sEdob = myReader.GetDateTime(5).ToString();
                    string sEphone = myReader.GetString(6).ToString();
                    //dateTimePicker1.Text = row.Cells["E_dob"].Value.ToString();


                  


                    try
                    {

                        byte[] img = (byte[])(myReader["E_image"]);

                        if (img != null)
                        {
                            MemoryStream mstream = new MemoryStream(img);
                            pictureBox1.Image = System.Drawing.Image.FromStream(mstream);

                        }

                        else
                        {
                            pictureBox1.Image = null;


                        }
                    }
                    catch (Exception)
                    {
                        // pictureBox1.Image = Image.FromFile(@"Resources\white.jpg");
                        pictureBox1.Image = null;
                        MessageBox.Show("This person doesn't have any image on the database");
                    }




                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }




        void Fillcombo()
        {
            string constring = "Server= (local)\\SQLEXPRESS; Database= Connection;User ID=sa;Password=p@ssword13";
            string Query = "select *from e_info";
            SqlConnection conDatabase = new SqlConnection(constring);
            SqlCommand cmdDatabase = new SqlCommand(Query, conDatabase);
            SqlDataReader myReader;
            try
            {
                conDatabase.Open();
                myReader = cmdDatabase.ExecuteReader();


                while (myReader.Read())
                {
                    string sName = myReader.GetString(1);
                    comboBox2.Items.Add(sName);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
              
                try
                {
                    var data = (Byte[])(row.Cells["E_image"].Value);


                    var stream = new MemoryStream(data);
                    pictureBox1.Image = Image.FromStream(stream);
                }
                catch (Exception)
                {
                    pictureBox1.Image = null;



                    MessageBox.Show("No Picture in the database");





                }



            }

        }

        private void dataGridView1_KeyUp(object sender, KeyEventArgs e)
        {

            //DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
          
            try
            {
                var data = (Byte[])(dataGridView1.CurrentRow.Cells["E_image"].Value);


                var stream = new MemoryStream(data);
                pictureBox1.Image = Image.FromStream(stream);
            }
            catch (Exception)
            {
                pictureBox1.Image = null;
                MessageBox.Show("No Picture in the database");
            }



        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu_after_viewer f1 = new Menu_after_viewer();
            f1.ShowDialog();
            this.Close();
        }













        /*
        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            load_table();
            string constring = "datasource=localhost;port=3306;username=root;password=1891";
            MySqlConnection conDatabase = new MySqlConnection(constring);
           
            DataView dv = new DataView(dbdataset);
            dv.RowFilter=string.Format("E_fname LIKE'%{0}%'",txt_search.Text);
            dataGridView1.DataSource = dv;
        }
        */
    }
}
