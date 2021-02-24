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

namespace EM
{
    public partial class ChangePassword : Form
    {
        
        public ChangePassword()
        {
           
            InitializeComponent();
           
        }

        private void confirm_btn_Click(object sender, EventArgs e)
        {
            try
            {
                string myConnection = "Server= (local)\\SQLEXPRESS; Database= Connection;User ID=sa;Password=p@ssword13";
                SqlConnection myConn = new SqlConnection(myConnection);
                SqlCommand SelectCommand = new SqlCommand("Select *from login where BINARY Username ='" + this.oldname_txt.Text + "'and Pass='" + this.oldpass_txt.Text + "';", myConn);
                SqlDataReader myReader, myReader2;
                myConn.Open();
                myReader = SelectCommand.ExecuteReader();
                int count = 0;
                while (myReader.Read())
                {
                    count = count + 1;
                }
                if (count == 1)
                {
                    string sEfname = myReader.GetString(2);
                    if (newpass_txt.Text == sEfname)
                    {
                        MessageBox.Show("Current Password and New Password Matched. Try another");
                    }
                    else
                    {

                        string Query = "UPDATE  login set Username='" + this.oldname_txt.Text + "',Pass='" + this.newpass_txt.Text + "' where Username='" + this.oldname_txt.Text + "'";

                        SqlConnection conDatabase2 = new SqlConnection(myConnection);
                        SqlCommand cmdDatabase2 = new SqlCommand(Query, conDatabase2);


                        try
                        {
                            conDatabase2.Open();
                            myReader2 = cmdDatabase2.ExecuteReader();
                            MessageBox.Show("Password updated successfully!!!");

                            while (myReader2.Read())
                            {

                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }
                }

                else
                    MessageBox.Show("Your previous username or password is not correct");
               
               
                myConn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_backtologin_Click(object sender, EventArgs e)
        {
            this.Hide();
            Admin_login f1 = new Admin_login();
            f1.ShowDialog();
            this.Close();
        }
    }
}
