using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Web;
using System.Net.Mail;

namespace EM
{
    public partial class EmailSender : Form
    {
        public EmailSender()
        {
            InitializeComponent();
            txt_from.Enabled = false;
          
           
        }

        private void btn_send_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_from.Text == "")
                {
                    MessageBox.Show("Please enter your email address");
                }

                if (txt_to.Text == "")
                {
                    MessageBox.Show("Please enter receiver email address");
                }

                if (txt_pass.Text == "")
                {
                    MessageBox.Show("Please enter your password");
                }
               
                if (txt_from.Text != "" && txt_to.Text != "" && txt_pass.Text != "")
                {
                    

                    MailMessage sendmsg = new MailMessage(txt_from.Text, txt_to.Text, txt_subject.Text, body.Text);
                    if (!string.IsNullOrEmpty(txt_attachment1.Text.ToString()))
                    sendmsg.Attachments.Add(new Attachment(txt_attachment1.Text.ToString()));
                    if (!string.IsNullOrEmpty(txt_attachment2.Text.ToString()))
                    sendmsg.Attachments.Add(new Attachment(txt_attachment2.Text.ToString()));
                    if (!string.IsNullOrEmpty(txt_attachment3.Text.ToString()))
                    sendmsg.Attachments.Add(new Attachment(txt_attachment3.Text.ToString()));

                  
                    SmtpClient client = new SmtpClient(txt_SMTP.Text);





                    client.Port = Convert.ToInt16(txt_port.Text);
                    client.Credentials = new System.Net.NetworkCredential(txt_from.Text, txt_pass.Text);
                    client.EnableSsl = true;

                    client.Send(sendmsg);
                    MessageBox.Show("Email sent!!!");
                    txt_from.Text = "";
                    txt_pass.Text = "";
                    txt_to.Text = "";
                    txt_subject.Text = "";
                    txt_port.Text = "";
                    txt_SMTP.Text = "";
                    txt_attachment1.Text = "";
                    txt_attachment2.Text = "";
                    txt_attachment3.Text = "";
                    btn_gmail.Enabled = true;
                    btn_yahoo.Enabled = true;
                    txt_from.Enabled = false;
                    txt_attachment1.Text = "";
                    
                }

            }
            catch (Exception)
            {
               // MessageBox.Show(x.Message);
                 MessageBox.Show("Maybe you have entered wrong password.Check again!!!");
            }
        }
      

        private void btn_gmail_Click(object sender, EventArgs e)
        {
            txt_from.Text = "@gmail.com";
            txt_from.Enabled = true;
            txt_SMTP.Text = "smtp.gmail.com";
            txt_port.Text = "587";
            btn_gmail.Enabled = false;
            btn_yahoo.Enabled = false;
        }

        private void btn_yahoo_Click(object sender, EventArgs e)
        {
            txt_from.Text = "@yahoo.com";
            txt_from.Enabled = true;
            txt_SMTP.Text = "smtp.yahoo.com";
            txt_port.Text = "465";
            btn_gmail.Enabled = false;
            btn_yahoo.Enabled = false;
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_from.Text = "";
            txt_pass.Text = "";
            txt_to.Text = "";
            txt_subject.Text = "";
            txt_port.Text = "";
            txt_SMTP.Text = "";
            txt_attachment1.Text = "";
            txt_attachment2.Text = "";
            txt_attachment3.Text = "";
            btn_gmail.Enabled = true;
            btn_yahoo.Enabled = true;
            txt_from.Enabled = false;
        }
        
        private void txt_attachment_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            if (file.ShowDialog() == DialogResult.OK)
            {
                String path = file.FileName.ToString();
                txt_attachment1.Text = path;
            }
        }

        private void txt_attachment2_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            if (file.ShowDialog() == DialogResult.OK)
            {
                String path = file.FileName.ToString();
                txt_attachment2.Text = path;
            }
        }

        private void txt_attachment3_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            if (file.ShowDialog() == DialogResult.OK)
            {
                String path = file.FileName.ToString();
                txt_attachment3.Text = path;
            }
        }

        private void button_logout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu_after_admin_login f1 = new Menu_after_admin_login();
            f1.ShowDialog();
            this.Close();
        }
        
       
       
       
    }
}
