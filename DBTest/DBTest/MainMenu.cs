using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace EM
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            Thread t = new Thread(new ThreadStart(splashstart));
            t.Start();
            Thread.Sleep(4000);

            InitializeComponent();
            t.Abort();
        }

        public void splashstart()
        {
            Application.Run(new Splash());
        }

        private void btn_admin_mainmenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            Admin_login f1 = new Admin_login();
            f1.ShowDialog();
            this.Close();
        }

        private void btn_viewer_mainmenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu_after_viewer f1 = new Menu_after_viewer();
            f1.ShowDialog();
            this.Close();
        }

    }
}
