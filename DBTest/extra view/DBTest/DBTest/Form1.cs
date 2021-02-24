using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data.SqlClient;

namespace DBTest
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
            password_txt.PasswordChar='*';
            password_txt.MaxLength = 15;
           
        }

       
        private void btn_passwordchange_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 f3 = new Form3();
            f3.ShowDialog();
            this.Close();
        }

        private void password_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Return))
            {
                try
                {
                    string myConnection = "Server= (local)\\SQLEXPRESS; Database= Connection;User ID=sa;Password=p@ssword13";
                   
           
                    SqlConnection myConn = new SqlConnection(myConnection);

                    SqlCommand SelectCommand = new SqlCommand("Select *from login where Username COLLATE Latin1_General_CS_AS ='" + this.username_txt.Text + "'and Pass COLLATE Latin1_General_CS_AS='" + this.password_txt.Text + "';", myConn);
                    SqlDataReader myReader;
                    myConn.Open();
                    myReader = SelectCommand.ExecuteReader();
                    int count = 0;
                    while (myReader.Read())
                    {
                        count = count + 1;
                    }
                    if (count == 1)
                    {
                        MessageBox.Show("Username and Password are correct");
                        this.Hide();
                        Form2 f2 = new Form2("Welcome :"+username_txt.Text);
                        f2.ShowDialog();
                        this.Close();
                    }

                    else
                        MessageBox.Show("Username and password are not correct");
                    myConn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btn_forgotpassword_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form4 f4 = new Form4();
            f4.ShowDialog();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string myConnection = "Server= (local)\\SQLEXPRESS; Database= Connection;User ID=sa;Password=p@ssword13";
                SqlConnection myConn = new SqlConnection(myConnection);

                SqlCommand SelectCommand = new SqlCommand("Select *from login where Username COLLATE Latin1_General_CS_AS ='" + this.username_txt.Text + "' and Pass COLLATE Latin1_General_CS_AS= '" + this.password_txt.Text + "';", myConn);
                SqlDataReader myReader;
                myConn.Open();
                myReader = SelectCommand.ExecuteReader();
                int count = 0;
                while (myReader.Read())
                {
                    count = count + 1;
                }
                if (count == 1)
                {
                    MessageBox.Show("Username and Password are correct");
                    this.Hide();
                    Form2 f2 = new Form2("Welcome :" + username_txt.Text);
                    f2.ShowDialog();
                    this.Close();
                }

                else
                    MessageBox.Show("Username and password are not correct");
                myConn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

      
      
       

       
      

        }

       
        }

        

       
      

      
