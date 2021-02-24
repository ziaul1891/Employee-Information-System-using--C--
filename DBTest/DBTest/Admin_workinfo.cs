using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace EM
{
    public partial class Admin_workinfo : Form
    {
        public Admin_workinfo()
        {
            InitializeComponent();
            load_table();
            AutoCompleteText();

            timer1.Start();
            
        }

        void load_table()
        {
            string constring = "Server= (local)\\SQLEXPRESS; Database= Connection;User ID=sa;Password=p@ssword13";
            SqlConnection conDatabase = new SqlConnection(constring);

            SqlCommand cmdDatabase = new SqlCommand("Select Eid,E_fname,E_lname,E_department,E_profession,E_salary from e_info ;", conDatabase);

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
                eid_txt.Text = row.Cells["Eid"].Value.ToString();
                edepartment_txt.Text = row.Cells["E_department"].Value.ToString();
                eprofession_txt.Text = row.Cells["E_profession"].Value.ToString();
                esalary_txt.Text = row.Cells["E_salary"].Value.ToString();
                label4.Text = row.Cells["Eid"].Value.ToString();
                label6.Text = row.Cells["E_fname"].Value.ToString() + " " + row.Cells["E_lname"].Value.ToString();
               


            }
        }

     
       

        private void btn_update_Click(object sender, EventArgs e)
        {
            string constring = "Server= (local)\\SQLEXPRESS; Database= Connection;User ID=sa;Password=p@ssword13";
                    string Query = "UPDATE  e_info set E_department='" + this.edepartment_txt.Text + "',E_profession='" + this.eprofession_txt.Text + "',E_salary='" + this.esalary_txt.Text + "' where Eid='" + this.eid_txt.Text + "'";

                    SqlConnection conDatabase = new SqlConnection(constring);
                    SqlCommand cmdDatabase = new SqlCommand(Query, conDatabase);
                    SqlDataReader myReader;
                    try
                    {
                        conDatabase.Open();
                     

                        myReader = cmdDatabase.ExecuteReader();

                        MessageBox.Show("Updated!!!");
                        edepartment_txt.Text = "";
                        eprofession_txt.Text = "";
                        esalary_txt.Text = "";
                        label4.Text = "ID";
                        label6.Text = "Full Name";
                    

                        while (myReader.Read())
                        {

                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    load_table();
                    
                
        }

        private void dataGridView1_KeyUp(object sender, KeyEventArgs e)
        {
            eid_txt.Text = dataGridView1.CurrentRow.Cells["Eid"].Value.ToString();
            edepartment_txt.Text = dataGridView1.CurrentRow.Cells["E_department"].Value.ToString();
            eprofession_txt.Text = dataGridView1.CurrentRow.Cells["E_profession"].Value.ToString();
            esalary_txt.Text = dataGridView1.CurrentRow.Cells["E_salary"].Value.ToString();
            label4.Text = dataGridView1.CurrentRow.Cells["Eid"].Value.ToString();
            label6.Text = dataGridView1.CurrentRow.Cells["E_fname"].Value.ToString() + " " + dataGridView1.CurrentRow.Cells["E_lname"].Value.ToString();
               

        }

        private void btn_gobacktogeneralinfo_Click(object sender, EventArgs e)
        {
            this.Hide();
            Admin_generalinfo f2 = new Admin_generalinfo();
            f2.ShowDialog();
            this.Close();
        }

        private void button_clear_Click(object sender, EventArgs e)
        {
            eid_txt.Text = "";
            edepartment_txt.Text = "";
            eprofession_txt.Text = "";
            esalary_txt.Text = "";
            load_table();
        }

        private void button_logout_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainMenu f1 = new MainMenu();
            f1.ShowDialog();
            this.Close();
        }

        

        private void btn_loaddata_Click(object sender, EventArgs e)
        {
            load_table();
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

        private void txt_search_KeyUp(object sender, KeyEventArgs e)
        {
            string constring = "Server= (local)\\SQLEXPRESS; Database= Connection;User ID=sa;Password=p@ssword13";
            SqlConnection conDatabase = new SqlConnection(constring);

            //MySqlCommand cmdDatabase = new MySqlCommand("Select *from login.e_info;" , conDatabase);
            SqlCommand cmdDatabase = new SqlCommand("Select Eid,E_fname,E_lname,E_department,E_profession,E_salary from e_info where E_fname LIKE '" + txt_search.Text + "%' OR E_lname LIKE '" + txt_search.Text + "%';", conDatabase);

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

        private void timer1_Tick(object sender, EventArgs e)
        {
         
            this.time_label.Text = DateTime.Today.Day.ToString();
            //this.time2_label.Text = "30";
            int x = Int32.Parse(time_label.Text);
            if (x >= 28 && x <= 30)
            {
                esalary_txt.Enabled = true;
            }
            else
                esalary_txt.Enabled = false;

        }

       
     
      
           

            

            

        }
    }

