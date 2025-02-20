using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int x1, y1; //! 이전 점의 좌표 값
        bool isDrawing = false; //! 마우스 드래그 상태 확인 변수

        static int pensize = 5;    //TODO: 펜 굵기 지정 부분
        Pen pen = new Pen(Color.Black, pensize);

        private void button1_Click(object sender, EventArgs e)
        {
            this.Refresh(); //! 화면 초기화
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pen = new Pen(Color.Red, pensize);
        }


        private void button3_Click(object sender, EventArgs e)
        {
            pen = new Pen(Color.Yellow, pensize);
        }


        private void button4_Click(object sender, EventArgs e)
        {
            pen = new Pen(Color.Blue, pensize);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            pen = new Pen(Color.Black, pensize);
        }


        //! 마우스 클릭시 그림 그리기 시작
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            isDrawing = true; //! 드래그 상태 시작
            x1 = e.X;
            y1 = e.Y;
        }

        // 마우스 이동 시 곡선 그리기
        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDrawing) //! 드래그 중일 때만 그림을 그림
            {
                Graphics g = CreateGraphics();
                g.DrawLine(pen, x1, y1, e.X, e.Y);
                x1 = e.X;
                y1 = e.Y;
                g.Dispose(); //! 리소스 해제
            }
        }

        //! 마우스 버튼을 놓으면 그림 그리기 종료
        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            isDrawing = false; //! 드래그 상태 종료
        }
    }
}
