using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Yeah
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            textBox2.PasswordChar = '*';
            textBox2.UseSystemPasswordChar = true;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string id = textBox1.Text;
            string pwd = textBox2.Text;

            if ((id == "wogud0501") && pwd.Equals("wogud05041"))
                    {
                
                MessageBox.Show("로그인 성공", "로그인");
            } else
            {
                MessageBox.Show("로그인 실패", "로그인");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


    }
}
