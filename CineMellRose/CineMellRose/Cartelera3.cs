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


namespace CineMellRose
{
    public partial class Cartelera3 : Form
    {
        enum Position
        {
            Left, Right, Up, Down
        }

        private int x;
        private int y;

        private Position pos;
        


        public Cartelera3()
        {
            InitializeComponent();
            x = 12;
            y = -170;
            this.ControlBox = false;
            pos = Position.Up;


        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            if (y != -770)
            {
                //if (y == -126)
                //{
                //    timer1.Enabled = false;
                //    Thread.Sleep(3000);
                //    timer1.Enabled = true;
                //}
                //if (y == -240)
                //{
                //    timer1.Enabled = false;
                //    Thread.Sleep(3000);
                //    timer1.Enabled = true;
                //}
                //if (y == -595)
                //{
                //    timer1.Enabled = false;
                //    Thread.Sleep(3000);
                //    timer1.Enabled = true;
                //}

                if (pos == Position.Up)
                {
                    y -= 5;

                    label1.Text = y.ToString();
                }

                this.pnl1.Location = new Point(x, y);


                Invalidate();
            }
            else
            {
                y = 500;

            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Test test = new Test();
            test.Show();
        }
    }
}
