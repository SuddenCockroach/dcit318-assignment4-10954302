using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace Drawing
{
    public partial class Form1 : Form
    {
        ArrayList listofPoints;
        bool PencilDown;

        public Form1()
        {
            InitializeComponent();
            listofPoints = new ArrayList();
            PencilDown = false;
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            Point p = new Point(e.X, e.Y);
            listofPoints.Add(p);
            PencilDown = true;
            this.statusStrip1.Items[0].Text = "MouseDown";
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            PencilDown = false;
            this.statusStrip1.Items[0].Text = "MouseUp";
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            Graphics g = this.CreateGraphics();
            Point points = new Point(e.X, e.Y);
            Pen pencil = new Pen(Color.BlueViolet);

            if (PencilDown)
            {
                this.statusStrip1.Items[0].Text = "MouseMove";
                if(listofPoints.Count > 1)
                    g.DrawLine(pencil, (Point)listofPoints[listofPoints.Count - 1],points);
                listofPoints.Add(points);
            }

        }
    }
}
