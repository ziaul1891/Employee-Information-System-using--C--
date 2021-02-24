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

namespace DBTest
{
    public partial class FormforSalary : Form
    {
        public FormforSalary()
        {
            InitializeComponent();
            AutoCompleteText();
            
            Fillcombo();
            fill_listbox();
            load_table();
            //textBox1.Visible = false;
        }

        DataTable dbdataset;
       
        void load_table()
        {
            string constring = "Server= (local)\\SQLEXPRESS; Database= Connection;User ID=sa;Password=p@ssword13";
            SqlConnection conDatabase = new SqlConnection(constring);

            SqlCommand cmdDatabase = new SqlCommand("Select *from salary;", conDatabase);

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

        void fill_listbox()
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

                efname_txt.Text = "";
                elname_txt.Text = "";
                esalary_txt.Text = "";
                eid_txt.Text = "";
                while (myReader.Read())
                {
                    string sName = myReader.GetString(1);
                    listBox1.Items.Add(sName);
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
                    comboBox1.Items.Add(sName);
                    comboBox2.Items.Add(sName);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }




        private void btn_save_Click(object sender, EventArgs e)
        {
           
           

                string constring = "Server= (local)\\SQLEXPRESS; Database= Connection;User ID=sa;Password=p@ssword13";
                string Query = "INSERT INTO salary(E_fname,E_lname,E_salary,E_absent) values ('" + this.efname_txt.Text + "','" + this.elname_txt.Text + "','" + this.esalary_txt.Text + "','" + this.textBox1.Text + "');";
                SqlConnection conDatabase = new SqlConnection(constring);
                SqlCommand cmdDatabase = new SqlCommand(Query, conDatabase);
                SqlDataReader myReader;
                try
                {
                    conDatabase.Open();

                    // cmdDatabase.Parameters.Add(new MySqlParameter("@IMG", imageBt));

                    myReader = cmdDatabase.ExecuteReader();
                    MessageBox.Show("Saved!");
                    efname_txt.Text = "";
                    elname_txt.Text = "";
                    esalary_txt.Text = "";


                    while (myReader.Read())
                    {

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                load_table();
                comboBox1.Items.Clear();
                comboBox2.Items.Clear();
                listBox1.Items.Clear();

                Fillcombo();
                fill_listbox();
                AutoCompleteText();
            
        }




        private void btn_update_Click(object sender, EventArgs e)
        {





            

            if (this.txt_imagepath.Text == "")
            {




                if (eid_txt.Text == "" || efname_txt.Text == "" || elname_txt.Text == "" || esalary_txt.Text == "")
                {
                    MessageBox.Show("Please fill up the necessary fields");
                }

                else
                {
                    string constring = "Server= (local)\\SQLEXPRESS; Database= Connection;User ID=sa;Password=p@ssword13";
                    string Query = "UPDATE  e_info set Eid='" + this.eid_txt.Text + "',E_fname='" + this.efname_txt.Text + "',E_lname='" + this.elname_txt.Text + "',E_age='" + this.esalary_txt.Text + "',E_absent='" + this.eabsent_txt.Text + "' where Eid='" + this.eid_txt.Text + "'";

                    SqlConnection conDatabase = new SqlConnection(constring);
                    SqlCommand cmdDatabase = new SqlCommand(Query, conDatabase);
                    SqlDataReader myReader;
                    try
                    {
                        conDatabase.Open();
                        // cmdDatabase.Parameters.Add(new MySqlParameter("@IMG", imageBt));

                        myReader = cmdDatabase.ExecuteReader();

                        MessageBox.Show("Updated!!!");



                        efname_txt.Text = "";
                        elname_txt.Text = "";
                        esalary_txt.Text = "";
                        eid_txt.Text = "";
                        txt_imagepath.Text = "";

                        while (myReader.Read())
                        {

                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    load_table();
                 
                    comboBox1.Items.Clear();
                    listBox1.Items.Clear();
                    Fillcombo();
                    fill_listbox();

                }
            }


          
        }




        private void btn_delete_Click(object sender, EventArgs e)
        {
            string constring = "Server= (local)\\SQLEXPRESS; Database= Connection;User ID=sa;Password=p@ssword13";
            string Query = "delete from e_info where Eid='" + this.eid_txt.Text + "';";
            SqlConnection conDatabase = new SqlConnection(constring);
            SqlCommand cmdDatabase = new SqlCommand(Query, conDatabase);
            SqlDataReader myReader;
            try
            {
                conDatabase.Open();
                myReader = cmdDatabase.ExecuteReader();
                MessageBox.Show("Deleted!!!");
                efname_txt.Text = "";
                elname_txt.Text = "";
                esalary_txt.Text = "";
                eid_txt.Text = "";
                txt_imagepath.Text = "";
                  while (myReader.Read())
                {

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            load_table();
           comboBox1.Items.Clear();
            listBox1.Items.Clear();
            Fillcombo();
            fill_listbox();

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            string constring = "Server= (local)\\SQLEXPRESS; Database= Connection;User ID=sa;Password=p@ssword13";
            string Query = "select *from e_info where E_fname='" + comboBox1.Text + "';";
            SqlConnection conDatabase = new SqlConnection(constring);
            SqlCommand cmdDatabase = new SqlCommand(Query, conDatabase);
            SqlDataReader myReader;
            try
            {
                conDatabase.Open();
                myReader = cmdDatabase.ExecuteReader();

                efname_txt.Text = "";
                elname_txt.Text = "";
                esalary_txt.Text = "";
                eid_txt.Text = "";
                while (myReader.Read())
                {
                    string sEid = myReader.GetInt32(0).ToString();
                    string sEfname = myReader.GetString(1);
                    string sElname = myReader.GetString(2);
                    string sEage = myReader.GetInt32(3).ToString();
                    string sEgender = myReader.GetString(4).ToString();
                    string sEdob = myReader.GetDateTime(5).ToString();

                    //dateTimePicker1.Text = row.Cells["E_dob"].Value.ToString();


                    eid_txt.Text = sEid;
                    efname_txt.Text = sEfname;
                    elname_txt.Text = sElname;
                    esalary_txt.Text = sEage;
                 
                    try
                    {

                        byte[] img = (byte[])(myReader["E_image"]);

                        if (img != null)
                        {
                            MemoryStream mstream = new MemoryStream(img);
                         
                        }

                        else
                        {
                          

                        }
                    }
                    catch (Exception)
                    {
                        // pictureBox1.Image = Image.FromFile(@"Resources\white.jpg");
                          MessageBox.Show("This person doesn't have any image on the database");
                    }



                   



                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            string constring = "Server= (local)\\SQLEXPRESS; Database= Connection;User ID=sa;Password=p@ssword13";
            string Query = "select *from e_info where E_fname='" + listBox1.Text + "';";
            SqlConnection conDatabase = new SqlConnection(constring);
            SqlCommand cmdDatabase = new SqlCommand(Query, conDatabase);
            SqlDataReader myReader;
            try
            {
                conDatabase.Open();
                myReader = cmdDatabase.ExecuteReader();


                while (myReader.Read())
                {
                    string sEid = myReader.GetInt32(0).ToString();
                    string sEfname = myReader.GetString(1);
                    string sElname = myReader.GetString(2);
                    string sEage = myReader.GetInt32(3).ToString();

                    eid_txt.Text = sEid;
                    efname_txt.Text = sEfname;
                    elname_txt.Text = sElname;
                    esalary_txt.Text = sEage;







                    

                  
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_loaddata_Click(object sender, EventArgs e)
        {
            string constring = "Server= (local)\\SQLEXPRESS; Database= Connection;User ID=sa;Password=p@ssword13";
            SqlConnection conDatabase = new SqlConnection(constring);

            SqlCommand cmdDatabase = new SqlCommand("Select *from e_info;", conDatabase);

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











        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                eid_txt.Text = row.Cells["Eid"].Value.ToString();
                efname_txt.Text = row.Cells["E_fname"].Value.ToString();
                elname_txt.Text = row.Cells["E_lname"].Value.ToString();
                esalary_txt.Text = row.Cells["E_salary"].Value.ToString();
              
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

                efname_txt.Text = "";
                elname_txt.Text = "";
                esalary_txt.Text = "";
                eid_txt.Text = "";


                string constring2 = "Server= (local)\\SQLEXPRESS; Database= Connection;User ID=sa;Password=p@ssword13";
                SqlConnection conDatabase2 = new SqlConnection(constring2);

                SqlCommand cmdDatabase2 = new SqlCommand("select *from e_info where E_fname='" + comboBox2.Text + "';", conDatabase2);


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

        private void btn_loadimage_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "JPG Files(*.jpg)|*jpg|PNG Files(*.png)|*png|All Files(*.*)|*.*";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                string picpath = dlg.FileName.ToString();



                txt_imagepath.Text = picpath;


               
            }
        }

        private void dataGridView1_KeyUp(object sender, KeyEventArgs e)
        {

            //DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
            eid_txt.Text = dataGridView1.CurrentRow.Cells["Eid"].Value.ToString();
            efname_txt.Text = dataGridView1.CurrentRow.Cells["E_fname"].Value.ToString();
            elname_txt.Text = dataGridView1.CurrentRow.Cells["E_lname"].Value.ToString();
            esalary_txt.Text = dataGridView1.CurrentRow.Cells["E_age"].Value.ToString();
           
        }

        

        private void eabsent_txt_KeyUp(object sender, KeyEventArgs e)
        {/*
            try
            {
                double qty;
                double price;
                double amt = 0;
                if (!String.IsNullOrEmpty(esalary_txt.Text) && !String.IsNullOrEmpty(eabsent_txt.Text))
                {
                    qty = Convert.ToDouble(esalary_txt.Text);
                    price = Convert.ToDouble(eabsent_txt.Text);
                    amt = qty - (price*1000);
                    esalary_txt.Text = amt.ToString();
                   
                    textBox1.Text = eabsent_txt.Text;
                    eabsent_txt.Text = "";
                   
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }  
          */ 
            
            
        }

        private void btn_calc_Click(object sender, EventArgs e)
        {
           try
            {
                double qty;
                double price;
                double amt = 0;
                if (!String.IsNullOrEmpty(esalary_txt.Text) && !String.IsNullOrEmpty(eabsent_txt.Text))
                {
                    qty = Convert.ToDouble(esalary_txt.Text);
                    price = Convert.ToDouble(eabsent_txt.Text);
                    if (price > 10 )
                    {
                        amt = qty - (qty * 30 / 100);
                        esalary_txt.Text = amt.ToString();
                    }
                    if (price > 6 && price <=10)
                    {
                        amt = qty - (qty * 25 / 100);
                        esalary_txt.Text = amt.ToString();
                    }
                    if (price > 3 && price <=6)
                    {
                        amt = qty - (qty * 10/100);
                        esalary_txt.Text = amt.ToString();
                    }
                   
                   
                        textBox1.Text = eabsent_txt.Text;
                        eabsent_txt.Text = "";
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }  

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
