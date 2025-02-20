using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Nakov.TurtleGraphics;

namespace OOP_Turtle
{
    public partial class Form1 : Form
    {
        int startX, startY, endX, endY;
        private void btn_init_Click(object sender, EventArgs e)
        {
            Turtle.Reset();
        }
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            startX = e.X;
            startY = e.Y;
            startX = startX - ClientSize.Width / 2;
            startY = ClientSize.Height / 2 - startY;
        }
        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            endX = e.X;
            endY = e.Y;
            endX = endX - ClientSize.Width / 2;
            endY = ClientSize.Height / 2 - endY;

            if (rdo_line.Checked)
            {
                Line line1 = new Line(startX, startY, endX, endY);
                line1.DrawLine();
            }
            else
            {
                Rectangle rect1 = new Rectangle(startX, startY, endX, endY);
                rect1.DrawLine();
            }
        }
    }

    abstract class Figure
    {
        public int x1, y1, x2, y2;
        abstract public void DrawLine();   // 추상 메서드
    }

    class Line : Figure
    {
        public Line(int x1, int y1, int x2, int y2)
        {
            this.x1 = x1;
            this.y1 = y1;
            this.x2 = x2;
            this.y2 = y2;
        }
        public override void DrawLine()    // 파생클래스에서 추상 메서드 오버라이드
        {
            Turtle.PenUp();
            Turtle.MoveTo(x1, y1);

            Turtle.PenColor = Color.Red;
            Turtle.PenDown();
            Turtle.MoveTo(x2, y2);
        }
    }

    class Rectangle : Figure
    {
        public Rectangle(int x1, int y1, int x2, int y2)
        {
            this.x1 = x1;
            this.y1 = y1;
            this.x2 = x2;
            this.y2 = y2;
        }

        public override void DrawLine()    // 파생클래스에서 추상 메서드 오버라이드
        {
            Turtle.PenUp();
            Turtle.MoveTo(x1, y1);

            Turtle.PenColor = Color.Green;
            Turtle.PenDown();
            Turtle.MoveTo(x1, y2);
            Turtle.MoveTo(x2, y2);
            Turtle.MoveTo(x2, y1);
            Turtle.MoveTo(x1, y1);
        }
    }

}
