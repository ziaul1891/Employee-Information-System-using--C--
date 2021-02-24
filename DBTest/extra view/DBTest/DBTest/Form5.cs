using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DBTest
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {

                double a = textBox1.Text == "" ? 0 : Convert.ToDouble(textBox1.Text);
                double b = a + 10;
                textBox2.Text = b.ToString();
            
        }
    }
}
