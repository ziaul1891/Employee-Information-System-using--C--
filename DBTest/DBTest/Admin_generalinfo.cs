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
    public partial class Admin_generalinfo : Form
    {
        public Admin_generalinfo()
        {
            InitializeComponent();
            AutoCompleteText();
            dateTimePicker1.ResetText();
            Fillcombo();
            fill_listbox();
            load_table();
        }

        DataTable dbdataset;
        string Gender;
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
                eage_txt.Text = "";
                eid_txt.Text = "";
                while (myReader.Read())
                {
                    string sName = myReader.GetString(1);
                    //listBox1.Items.Add(sName);
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




        private void button1_Click(object sender, EventArgs e)
        {
            if (efname_txt.Text == "" || elname_txt.Text == "" || eage_txt.Text == "" || ephone_txt.Text == "")
            {
                MessageBox.Show("Please fill up the necessary fields");
            }

            else
            {

                byte[] imageBt = null;
                if (this.txt_imagepath.Text == "")
                {

                    string constring = "Server= (local)\\SQLEXPRESS; Database= Connection;User ID=sa;Password=p@ssword13";
                    string Query = "INSERT INTO e_info(E_fname,E_lname,E_age,E_gender,E_dob,E_phone) values ('" + this.efname_txt.Text + "','" + this.elname_txt.Text + "','" + this.eage_txt.Text + "','" + Gender + "','" + this.dateTimePicker1.Text + "','" + this.ephone_txt.Text + "');";
                    SqlConnection conDatabase = new SqlConnection(constring);
                    SqlCommand cmdDatabase = new SqlCommand(Query, conDatabase);
                    SqlDataReader myReader;
                    try
                    {
                        conDatabase.Open();

                        // cmdDatabase.Parameters.Add(new MySqlParameter("@IMG", imageBt));

                        myReader = cmdDatabase.ExecuteReader();
                        MessageBox.Show("Saved without an Image!!! You can update the image later!");
                        efname_txt.Text = "";
                        elname_txt.Text = "";
                        eage_txt.Text = "";
                        txt_imagepath.Text = "";
                        ephone_txt.Text = "";
                        dateTimePicker1.ResetText();
                        pictureBox1.Image = null;
                        while (myReader.Read())
                        {

                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    load_table();
                    radiobtn_male.Checked = false;
                    radiobtn_female.Checked = false;
                    comboBox2.Items.Clear();
                    //listBox1.Items.Clear();

                    Fillcombo();
                    fill_listbox();
                    AutoCompleteText();
                }
                else
                {


                    FileStream fstream = new FileStream(this.txt_imagepath.Text, FileMode.Open, FileAccess.Read);

                    BinaryReader br = new BinaryReader(fstream);
                    imageBt = br.ReadBytes((int)fstream.Length);



                    string constring = "Server= (local)\\SQLEXPRESS; Database= Connection;User ID=sa;Password=p@ssword13";
                    string Query = "INSERT INTO e_info(E_fname,E_lname,E_age,E_gender,E_dob,E_phone,E_image) values ('" + this.efname_txt.Text + "','" + this.elname_txt.Text + "','" + this.eage_txt.Text + "','" + Gender + "','" + this.dateTimePicker1.Text + "','" + this.ephone_txt.Text + "',@IMG);";
                    SqlConnection conDatabase = new SqlConnection(constring);
                    SqlCommand cmdDatabase = new SqlCommand(Query, conDatabase);
                    SqlDataReader myReader;
                    try
                    {
                        conDatabase.Open();

                        cmdDatabase.Parameters.Add(new SqlParameter("@IMG", imageBt));

                        myReader = cmdDatabase.ExecuteReader();
                        MessageBox.Show("Saved!!!");
                        efname_txt.Text = "";
                        elname_txt.Text = "";
                        eage_txt.Text = "";
                        txt_imagepath.Text = "";
                        ephone_txt.Text = "";
                        pictureBox1.Image = null;
                        dateTimePicker1.ResetText();
                        while (myReader.Read())
                        {

                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    load_table();
                    radiobtn_male.Checked = false;
                    radiobtn_female.Checked = false;
                    comboBox2.Items.Clear();
                    //listBox1.Items.Clear();

                    Fillcombo();
                    fill_listbox();
                    AutoCompleteText();

                }
            }
        }




        private void btn_update_Click(object sender, EventArgs e)
        {

           
           
            
            
            byte[] imageBt=null;

            if (this.txt_imagepath.Text == "")
            {




                if (efname_txt.Text == "" || elname_txt.Text == "" || eage_txt.Text == "" ||ephone_txt.Text== "")
                {
                    MessageBox.Show("Please fill up the necessary fields");
                }

                else
                {
                    string constring = "Server= (local)\\SQLEXPRESS; Database= Connection;User ID=sa;Password=p@ssword13";
                    string Query = "UPDATE  e_info set E_fname='" + this.efname_txt.Text + "',E_lname='" + this.elname_txt.Text + "',E_age='" + this.eage_txt.Text + "',E_gender='" + Gender + "',E_dob='" + this.dateTimePicker1.Text + "',E_phone='"+this.ephone_txt.Text+"' where Eid='" + this.eid_txt.Text + "'";

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
                        eage_txt.Text = "";
                        eid_txt.Text = "";
                        pictureBox1.Image = null;
                        txt_imagepath.Text = "";
                        ephone_txt.Text = "";
                        dateTimePicker1.ResetText();

                        while (myReader.Read())
                        {

                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    load_table();
                    radiobtn_male.Checked = false;
                    radiobtn_female.Checked = false;
                    comboBox2.Items.Clear();
                      //listBox1.Items.Clear();
                    Fillcombo();
                    fill_listbox();

                }
            }


            else
            {


                FileStream fstream = new FileStream(this.txt_imagepath.Text, FileMode.Open, FileAccess.Read);

                BinaryReader br = new BinaryReader(fstream);
                imageBt = br.ReadBytes((int)fstream.Length);




                if (efname_txt.Text == "" || elname_txt.Text == "" || eage_txt.Text == "")
                {
                    MessageBox.Show("Please fill up the necessary fields");
                }

                else
                {
                    string constring = "Server= (local)\\SQLEXPRESS; Database= Connection;User ID=sa;Password=p@ssword13";
                    string Query = "UPDATE  e_info set E_fname='" + this.efname_txt.Text + "',E_lname='" + this.elname_txt.Text + "',E_age='" + this.eage_txt.Text + "',E_gender='" + Gender + "',E_dob='" + this.dateTimePicker1.Text + "',E_phone='"+this.ephone_txt.Text+"',E_image=@IMG where Eid='" + this.eid_txt.Text + "'";

                    SqlConnection conDatabase = new SqlConnection(constring);
                    SqlCommand cmdDatabase = new SqlCommand(Query, conDatabase);
                    SqlDataReader myReader;
                    try
                    {
                        conDatabase.Open();
                        cmdDatabase.Parameters.Add(new SqlParameter("@IMG", imageBt));

                        myReader = cmdDatabase.ExecuteReader();
                        MessageBox.Show("Updated!!!");
                        efname_txt.Text = "";
                        elname_txt.Text = "";
                        eage_txt.Text = "";
                        eid_txt.Text = "";
                        ephone_txt.Text = "";
                        pictureBox1.Image = null;
                        txt_imagepath.Text = "";
                        dateTimePicker1.ResetText();

                        while (myReader.Read())
                        {

                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    load_table();
                    radiobtn_male.Checked = false;
                    radiobtn_female.Checked = false;

                     //listBox1.Items.Clear();
                    Fillcombo();
                    fill_listbox();

                }
            }
        }




        private void btn_delete_Click(object sender, EventArgs e)
        {

            if (efname_txt.Text == "" || elname_txt.Text == "" || eage_txt.Text == "" || ephone_txt.Text == "")
            {
                MessageBox.Show("Please fill up the necessary fields");
            }
            else
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
                    eage_txt.Text = "";
                    eid_txt.Text = "";
                    txt_imagepath.Text = "";
                    pictureBox1.Image = null;
                    dateTimePicker1.ResetText();
                    while (myReader.Read())
                    {

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                load_table();
                radiobtn_male.Checked = false;
                radiobtn_female.Checked = false;
                //listBox1.Items.Clear();
                Fillcombo();
                fill_listbox();
            }
           
        }

       

        /*
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            string constring = "Server= (local)\\SQLEXPRESS; Database= Connection;User ID=sa;Password=p@ssword13";
           // string Query = "select Eid,E_fname,E_lname,E_age,E_gender,E_dob,E_phone,E_image e_info where E_fname='" + listBox1.Text + "';";
            SqlConnection conDatabase = new SqlConnection(constring);
           // SqlCommand cmdDatabase = new SqlCommand(Query, conDatabase);
            SqlDataReader myReader;
            try
            {
                conDatabase.Open();
               // myReader = cmdDatabase.ExecuteReader();




                string constring2 = "Server= (local)\\SQLEXPRESS; Database= Connection;User ID=sa;Password=p@ssword13";
                SqlConnection conDatabase2 = new SqlConnection(constring2);

                //SqlCommand cmdDatabase2 = new SqlCommand("select *from e_info where E_fname='" + listBox1.Text + "';", conDatabase2);


                SqlDataAdapter sda = new SqlDataAdapter();
               // sda.SelectCommand = cmdDatabase2;
                dbdataset = new DataTable();
                sda.Fill(dbdataset);
                BindingSource bSource = new BindingSource();
                bSource.DataSource = dbdataset;
                dataGridView1.DataSource = bSource;
                sda.Update(dbdataset);

               
                while (myReader.Read())
                {
                    string sEid = myReader.GetInt32(0).ToString();
                    string sEfname = myReader.GetString(1);
                    string sElname = myReader.GetString(2);
                    string sEage = myReader.GetInt32(3).ToString();
                    string sEdob = myReader.GetDateTime(5).ToString();
                    eid_txt.Text = sEid;
                    efname_txt.Text = sEfname;
                    elname_txt.Text = sElname;
                    eage_txt.Text = sEage;
                    dateTimePicker1.Text = sEdob;




                    byte[] img = (byte[])(myReader["E_image"]);
                    if (img == null)
                        pictureBox1.Image = null;
                    else
                    {
                        MemoryStream mstream = new MemoryStream(img);
                        pictureBox1.Image = System.Drawing.Image.FromStream(mstream);
                    }



                    
                    string sEgender = myReader.GetString(4).ToString();
                    if (sEgender == "Male")
                    {
                        radiobtn_male.Checked = true;
                        radiobtn_male.Enabled = true;
                       }
                    else if (sEgender == "Female")
                    {
                        radiobtn_female.Checked = true;
                        radiobtn_female.Enabled = true;
                     }
                    else
                    {
                        radiobtn_male.Enabled = true;
                         radiobtn_female.Enabled = true;
                    }

                 
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
         */ 
       
        private void btn_loaddata_Click(object sender, EventArgs e)
        {
            load_table();
        }


        






        

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
                if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                eid_txt.Text = row.Cells["Eid"].Value.ToString();
                efname_txt.Text = row.Cells["E_fname"].Value.ToString();
                elname_txt.Text = row.Cells["E_lname"].Value.ToString();
                eage_txt.Text = row.Cells["E_age"].Value.ToString();
                ephone_txt.Text = row.Cells["E_phone"].Value.ToString();
                dateTimePicker1.Text = row.Cells["E_dob"].Value.ToString();

                if (row.Cells["E_gender"].Value.ToString() == "Male")
                {
                    radiobtn_male.Checked = true;
                    radiobtn_male.Enabled = true;
                }
                else if (row.Cells["E_gender"].Value.ToString() == "Female")
                {
                    radiobtn_female.Checked = true;
                    radiobtn_female.Enabled = true;
                }
                else
                {
                    radiobtn_male.Enabled = true;
                    radiobtn_female.Enabled = true;
                }

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
                comboBox2.Text = "";
                txt_search1.Text = "";
                sda.Update(dbdataset);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void radiobtn_male_CheckedChanged(object sender, EventArgs e)
        {
            Gender = "Male";
        }

        private void radiobtn_female_CheckedChanged(object sender, EventArgs e)
        {
            Gender = "Female";
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
                 eage_txt.Text = "";
                 eid_txt.Text = "";

               









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
                txt_search1.Text = "";
                txt_search.Text = "";

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


                     eid_txt.Text = sEid;
                     efname_txt.Text = sEfname;
                     elname_txt.Text = sElname;
                     eage_txt.Text = sEage;
                     dateTimePicker1.Text = sEdob;

                     if (sEgender == "Male")
                     {
                         radiobtn_male.Checked = true;
                         radiobtn_male.Enabled = true;

                     }
                     else if (sEgender == "Female")
                     {
                         radiobtn_female.Checked = true;
                         radiobtn_female.Enabled = true;
                     }
                     else
                     {
                         radiobtn_male.Enabled = true;
                         radiobtn_female.Enabled = true;
                     }



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

         private void btn_loadimage_Click(object sender, EventArgs e)
         {
             OpenFileDialog dlg = new OpenFileDialog();
             dlg.Filter="JPG Files(*.jpg)|*jpg|PNG Files(*.png)|*png|All Files(*.*)|*.*";
             if (dlg.ShowDialog() == DialogResult.OK)
             {
                 string picpath = dlg.FileName.ToString();
                 
                 

                     txt_imagepath.Text = picpath;
                    
                    
                         pictureBox1.ImageLocation = picpath;
                        
             }
         }

         private void dataGridView1_KeyUp(object sender, KeyEventArgs e)
         {
            
                 //DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                 eid_txt.Text =dataGridView1.CurrentRow.Cells["Eid"].Value.ToString();
                 efname_txt.Text = dataGridView1.CurrentRow.Cells["E_fname"].Value.ToString();
                 elname_txt.Text = dataGridView1.CurrentRow.Cells["E_lname"].Value.ToString();
                 eage_txt.Text = dataGridView1.CurrentRow.Cells["E_age"].Value.ToString();
                 ephone_txt.Text = dataGridView1.CurrentRow.Cells["E_phone"].Value.ToString();             
                 dateTimePicker1.Text = dataGridView1.CurrentRow.Cells["E_dob"].Value.ToString();
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



                 if (dataGridView1.CurrentRow.Cells["E_gender"].Value.ToString() == "Male")
                 {
                     radiobtn_male.Checked = true;
                     radiobtn_male.Enabled = true;
            
                 }
                 else if (dataGridView1.CurrentRow.Cells["E_gender"].Value.ToString() == "Female")
                 {
                     radiobtn_female.Checked = true;
                     radiobtn_female.Enabled = true;
                  }
                 else
                 {
                     radiobtn_male.Enabled = true;
                     radiobtn_female.Enabled = true;
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
                 comboBox2.Text = "";
                 txt_search.Text = "";
             }
             catch (Exception ex)
             {
                 MessageBox.Show(ex.Message);
             }
         }

         void clearall()
         {
             efname_txt.Text = "";
             elname_txt.Text = "";
             eage_txt.Text = "";
             txt_imagepath.Text = "";
             dateTimePicker1.ResetText();
             pictureBox1.Image = null;
             radiobtn_male.Checked = false;
             radiobtn_female.Checked = false;
             comboBox2.Text = "";
             txt_search.Text = "";
             txt_search1.Text = "";
             eid_txt.Text = "";
             ephone_txt.Text = "";
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
