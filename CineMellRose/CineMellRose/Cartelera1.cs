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
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data;


namespace CineMellRose
{
    public partial class Cartelera1 : Form
    {

        enum Position
        {
            Left, Right, Up, Down
        }

        private int x;
        private int y;

        private Position pos;



        public Cartelera1()
        {
            InitializeComponent();
            x = 12;
            y = 105;
            this.ControlBox = false;
            pos = Position.Up;
            CargaInfo();


        }


        private void timer1_Tick(object sender, EventArgs e)
        {

            if (y != -770)
            {
                if (y == -180)
                {
                    timer1.Enabled = false;
                    Thread.Sleep(3000);
                    timer1.Enabled = true;
                }
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

        private void Cartelera1_Load(object sender, EventArgs e)
        {
            Cartelera2 pantalla2 = new Cartelera2();
            Cartelera3 pantalla3 = new Cartelera3();

            pantalla2.Show();
            pantalla3.Show();
        }

        private void CargaInfo()
        {
            CargaInfo cargaInfo = new CargaInfo();

            int numSala = 1;

            cargaInfo.CargaTitulos(numSala);
            cargaInfo.CargaSala(numSala);

            txtNombre.Text = GlobalParameters.NombrePelicula;
            txtSala.Text = "Sala: " + GlobalParameters.SalaPelicula;


        }
    }
}
