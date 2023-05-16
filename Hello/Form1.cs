using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace Hello
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "까꿍!";
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            label1.Visible = true;
            label1.Text = "까꿍!";
            
            
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            label1.Visible = false;
            label1.Text = "";
        }
    }
}
