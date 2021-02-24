using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace EM
{
    public partial class Menu_after_admin_login : Form
    {
        public Menu_after_admin_login()
        {
            InitializeComponent();
        }

        private void button_logout_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainMenu f1 = new MainMenu();
            f1.ShowDialog();
            this.Close();
        }

        private void button_goto_generalinfo_Click(object sender, EventArgs e)
        {
            this.Hide();
            Admin_generalinfo f2 = new Admin_generalinfo();
            f2.ShowDialog();
            this.Close();
        }

        private void button_goto_workinfo_Click(object sender, EventArgs e)
        {
            this.Hide();
            Admin_workinfo f4 = new Admin_workinfo();
            f4.ShowDialog();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            EmailSender f5 = new EmailSender();
            f5.ShowDialog();
            this.Close();
        }

        private void generalInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Admin_generalinfo f2 = new Admin_generalinfo();
            f2.ShowDialog();
            this.Close();
        }

        private void workInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Admin_workinfo f4 = new Admin_workinfo();
            f4.ShowDialog();
            this.Close();
        }

        private void sendEmailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            EmailSender f5 = new EmailSender();
            f5.ShowDialog();
            this.Close();
        }
    }
}
