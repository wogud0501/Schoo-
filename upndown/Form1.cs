using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace upndown
{
    public partial class Form1 : Form
    {
        int answer = 0;
        int findnum = 0;
        int cnt = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = true;

            Random rnd = new Random();
            findnum = rnd.Next(1, 100);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            cnt++;
            answer = int.Parse(textBox1.Text);
            if ( answer > findnum )
            {
                pictureBox2.Image = Properties.Resources.down;
            }
            else if ( answer == findnum)
            {
                pictureBox2.Image = Properties.Resources.congratulation;
                label1.Text = cnt + "회 만에 맞혔습니다.";
            }
            else if ( answer < findnum)
            {
                pictureBox2.Image = Properties.Resources.up;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            findnum = 0;
            cnt = 0;
            answer = 0;
            pictureBox2.Visible = false;
            label1.Text = "초기화가 성공하였습니다!";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
            
        }
    }
}
