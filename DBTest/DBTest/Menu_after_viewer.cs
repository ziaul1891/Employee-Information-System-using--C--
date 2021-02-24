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
    public partial class Menu_after_viewer : Form
    {
        public Menu_after_viewer()
        {
            InitializeComponent();
        }

        private void button_goto_generalinfo_Click(object sender, EventArgs e)
        {
            this.Hide();
            EmployeeGeneralInfo f2 = new EmployeeGeneralInfo();
            f2.ShowDialog();
            this.Close();
        }

        private void button_goto_workinfo_Click(object sender, EventArgs e)
        {
            this.Hide();
            EmployeeWorkInfo f2 = new EmployeeWorkInfo();
            f2.ShowDialog();
            this.Close();
        }
    }
}
