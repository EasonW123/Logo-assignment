using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Logo_assignment
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            // object created 
            Graphics g = this.CreateGraphics();
            Pen drawPen = new Pen(Color.White, 5);
            Pen drawPen2 = new Pen(Color.White, 6);
            Pen drawPen3 = new Pen(Color.White, 8);
            SolidBrush drawBrush = new SolidBrush(Color.Black);
            Font drawFont = new Font("Arial", 80, FontStyle.Bold);
            SolidBrush drawBrush2 = new SolidBrush(Color.Red);
            g.Clear(Color.Red);

            //the tesla logo
            g.DrawArc(drawPen2, 42, 45, 172, 30, 180, 180);
            g.DrawLine(drawPen, 110, 65, 125, 85);
            g.DrawLine(drawPen,140, 65, 125, 85);
            g.DrawArc(drawPen, 45, 63, 68, 7, 180, 180);
            g.DrawArc(drawPen, 140, 63, 68, 7, 180, 180);
            g.DrawLine(drawPen, 45, 63, 69, 90);
            g.DrawLine(drawPen, 210, 63, 186, 90);
            g.DrawArc(drawPen, 54, 82, 66, 60, 230, 30);
            g.DrawArc(drawPen, 135, 82, 65, 65, 280, 30);
            g.DrawLine(drawPen, 82, 82, 98, 82);
            g.DrawLine(drawPen, 174, 82, 158, 82);
            g.DrawLine(drawPen, 95, 80, 125,235 );
            g.DrawLine(drawPen, 160, 80, 125, 235);
           


        }
    }
}
