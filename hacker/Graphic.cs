using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hacker
{
    public partial class Graphic : Form
    {
        public Graphic()
        {
            InitializeComponent();
        }

        private void Graphic_Load(object sender, EventArgs e)
        {
            Paint += new PaintEventHandler(Form1_Paint);
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            int a = 1;
            if (a == 1)
            {
                Graphics g = this.CreateGraphics();

                System.Drawing.Drawing2D.AdjustableArrowCap linecap = new System.Drawing.Drawing2D.AdjustableArrowCap(6, 6, false);
                Pen pen2 = new Pen(Color.Blue, 3);
                pen2.CustomEndCap = linecap;
                g.DrawLine(pen2, 10, 300, 10, 0);
                g.DrawLine(pen2, 10, 150, 1120, 150);
                

                Pen pen1 = new Pen(Color.Blue, 2);
                float y = 150, y1, x1, x2;
                for (int x = 10; x < 1100; x++)
                {
                    x1 = (float)x;
                    x2 = (float)(x + 1);
                    y1 = (float)(150 - 50 * Math.Sin((3.14159 / 180.0) * (x - 9)));
                    g.DrawLine(pen1, x1, y, x2, y1);
                    y = y1;
                }
                
                
            }
            appTimer.Enabled = false;
        }

        private void appTimer_Tick(object sender, EventArgs e)
        {
            this.Refresh();
        }
    }
}
