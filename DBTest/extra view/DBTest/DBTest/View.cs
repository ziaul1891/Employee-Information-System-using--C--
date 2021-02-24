using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;

namespace DBTest
{
    public partial class View : Form
    {
        public View()
        {
            InitializeComponent();
            load_table();
           
            AutoCompleteText();
            
        }


        DataTable dbdataset;
       


        void load_table()
        {
            string constring = "Server= (local)\\SQLEXPRESS; Database= Connection;User ID=sa;Password=p@ssword13";
            SqlConnection conDatabase = new SqlConnection(constring);

            SqlCommand cmdDatabase = new SqlCommand("Select *from e_info;", conDatabase);

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


        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
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

                SqlCommand cmdDatabase2 = new SqlCommand("select *from e_info where E_gender='" + comboBox2.Text + "';", conDatabase2);


                SqlDataAdapter sda = new SqlDataAdapter();
                sda.SelectCommand = cmdDatabase2;
                dbdataset = new DataTable();
                sda.Fill(dbdataset);
                BindingSource bSource = new BindingSource();
                bSource.DataSource = dbdataset;
                dataGridView1.DataSource = bSource;
                sda.Update(dbdataset);
                while (myReader.Read())
                {




                }
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

        private void dataGridView1_KeyUp(object sender, KeyEventArgs e)
        {
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

        private void txt_search_KeyUp(object sender, KeyEventArgs e)
        {

            string constring = "Server= (local)\\SQLEXPRESS; Database= Connection;User ID=sa;Password=p@ssword13";
            SqlConnection conDatabase = new SqlConnection(constring);

            //MySqlCommand cmdDatabase = new MySqlCommand("Select *from login.e_info;" , conDatabase);
            SqlCommand cmdDatabase = new SqlCommand("Select * from e_info where E_fname LIKE '" + txt_search.Text + "%' OR E_lname LIKE '" + txt_search.Text + "%';", conDatabase);

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
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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

        private void txt_search_filternames_KeyUp(object sender, KeyEventArgs e)
        {
            if ((txt_search_filternames.Text == "" && comboBox2.Text == "Male"))
            {
                string constring = "Server= (local)\\SQLEXPRESS; Database= Connection;User ID=sa;Password=p@ssword13";
                SqlConnection conDatabase = new SqlConnection(constring);

                SqlCommand cmdDatabase = new SqlCommand("Select *from e_info where E_gender='Male';", conDatabase);

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
            else if ((txt_search_filternames.Text == "" && comboBox2.Text == "Female"))
            {
                string constring = "Server= (local)\\SQLEXPRESS; Database= Connection;User ID=sa;Password=p@ssword13";
                SqlConnection conDatabase = new SqlConnection(constring);

                SqlCommand cmdDatabase = new SqlCommand("Select *from e_info where E_gender='Female';", conDatabase);

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
            else if(comboBox2.Text=="Male")
            {

                string constring = "Server= (local)\\SQLEXPRESS; Database= Connection;User ID=sa;Password=p@ssword13";
                SqlConnection conDatabase = new SqlConnection(constring);

                //MySqlCommand cmdDatabase = new MySqlCommand("Select *from login.e_info;" , conDatabase);
                SqlCommand cmdDatabase = new SqlCommand("Select * from e_info where (E_fname LIKE '" + txt_search_filternames.Text + "%' OR E_lname LIKE '" + txt_search_filternames.Text + "%') and E_gender='Male' ;", conDatabase);

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
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else if (comboBox2.Text == "Female")
            {

                string constring = "Server= (local)\\SQLEXPRESS; Database= Connection;User ID=sa;Password=p@ssword13";
                SqlConnection conDatabase = new SqlConnection(constring);

                //MySqlCommand cmdDatabase = new MySqlCommand("Select *from login.e_info;" , conDatabase);
                SqlCommand cmdDatabase = new SqlCommand("Select * from e_info where (E_fname LIKE '" + txt_search_filternames.Text + "%' OR E_lname LIKE '" + txt_search_filternames.Text + "%') and E_gender='Female' ;", conDatabase);

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
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

           


        }

        private void button1_Click(object sender, EventArgs e)
        {
            comboBox2.ResetText();
            load_table();
            comboBox1.ResetText();
            txt_age1.ResetText();
            txt_age2.ResetText();
            txt_imagepath.ResetText();
            txt_search.ResetText();
            txt_search_filternames.ResetText();
            

            
        }

        private void btn_age_filtering_Click(object sender, EventArgs e)
        {
            if ((txt_age1.Text == "" || txt_age2.Text == "") && comboBox1.Text == "Male")
            {
                string constring = "Server= (local)\\SQLEXPRESS; Database= Connection;User ID=sa;Password=p@ssword13";
                SqlConnection conDatabase = new SqlConnection(constring);

                SqlCommand cmdDatabase = new SqlCommand("Select *from e_info where E_gender='Male';", conDatabase);

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
            if ((txt_age1.Text == "" || txt_age2.Text == "") && comboBox1.Text == "Female")
            {
                string constring = "Server= (local)\\SQLEXPRESS; Database= Connection;User ID=sa;Password=p@ssword13";
                SqlConnection conDatabase = new SqlConnection(constring);

                SqlCommand cmdDatabase = new SqlCommand("Select *from e_info where E_gender='Female';", conDatabase);

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

            if (comboBox1.Text == "Male")
            {
                string constring2 = "Server= (local)\\SQLEXPRESS; Database= Connection;User ID=sa;Password=p@ssword13";
                SqlConnection conDatabase2 = new SqlConnection(constring2);

                //MySqlCommand cmdDatabase = new MySqlCommand("Select *from login.e_info;" , conDatabase);
                SqlCommand cmdDatabase2 = new SqlCommand("Select * from e_info where (E_age between '" + txt_age1.Text + "' AND '" + txt_age2.Text + "') AND E_gender='Male' ;", conDatabase2);

                try
                {
                    SqlDataAdapter sda = new SqlDataAdapter();
                    sda.SelectCommand = cmdDatabase2;
                    dbdataset = new DataTable();
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

            if (comboBox1.Text == "Female")
            {
                string constring2 = "Server= (local)\\SQLEXPRESS; Database= Connection;User ID=sa;Password=p@ssword13";
                SqlConnection conDatabase2 = new SqlConnection(constring2);

                //MySqlCommand cmdDatabase = new MySqlCommand("Select *from login.e_info;" , conDatabase);
                SqlCommand cmdDatabase2 = new SqlCommand("Select * from e_info where (E_age between '" + txt_age1.Text + "' AND '" + txt_age2.Text + "') AND E_gender='Female' ;", conDatabase2);

                try
                {
                    SqlDataAdapter sda = new SqlDataAdapter();
                    sda.SelectCommand = cmdDatabase2;
                    dbdataset = new DataTable();
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

            if (comboBox1.Text == "Select ALL")
            {
                string constring2 = "Server= (local)\\SQLEXPRESS; Database= Connection;User ID=sa;Password=p@ssword13";
                SqlConnection conDatabase2 = new SqlConnection(constring2);

                //MySqlCommand cmdDatabase = new MySqlCommand("Select *from login.e_info;" , conDatabase);
                SqlCommand cmdDatabase2 = new SqlCommand("Select * from e_info where (E_age between '" + txt_age1.Text + "' AND '" + txt_age2.Text + "')  ;", conDatabase2);

                try
                {
                    SqlDataAdapter sda = new SqlDataAdapter();
                    sda.SelectCommand = cmdDatabase2;
                    dbdataset = new DataTable();
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

            if (comboBox1.Text == "")
            {
                string constring2 = "Server= (local)\\SQLEXPRESS; Database= Connection;User ID=sa;Password=p@ssword13";
                SqlConnection conDatabase2 = new SqlConnection(constring2);

                //MySqlCommand cmdDatabase = new MySqlCommand("Select *from login.e_info;" , conDatabase);
                SqlCommand cmdDatabase2 = new SqlCommand("Select * from e_info where (E_age between '" + txt_age1.Text + "' AND '" + txt_age2.Text + "')  ;", conDatabase2);

                try
                {
                    SqlDataAdapter sda = new SqlDataAdapter();
                    sda.SelectCommand = cmdDatabase2;
                    dbdataset = new DataTable();
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
        }

       

       
    }
}
