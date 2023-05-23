using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test
{
    public partial class Form1 : Form
    {
        private bool isProgressBarVisible = false;
        public Form1()
        {
            InitializeComponent();
            progressBar.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (isProgressBarVisible)
            {
                // 프로그레스바 초기화 및 숨김 처리
                progressBar.Value = 0;
                progressBar.Visible = false;
                isProgressBarVisible = false;
            }
            else
            {
                // 프로그레스바 표시
                progressBar.Visible = true;
                isProgressBarVisible = true;

                // 프로그레스바 값 증가를 위한 타이머 설정
                Timer timer = new Timer();
                timer.Interval = 100;  // 타이머 간격 (ms)
                timer.Tick += Timer_Tick;  // 타이머 이벤트 핸들러 등록
                timer.Start();  // 타이머 시작
            }
            using (StreamWriter writer = new StreamWriter("test.txt", true))
            {
                writer.WriteLine(label1.Text);
            }

        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            progressBar.Value += 10;

            if (progressBar.Value >= progressBar.Maximum)
            {
                ((Timer)sender).Stop();
                MessageBox.Show("검색이 완료 되었습니다.");
                progressBar.Visible = false;

                Random random = new Random();
                string link = "https://google.com/" + random.Next(1000, 9999);

                label1.Text = link;
            }


        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }               
}