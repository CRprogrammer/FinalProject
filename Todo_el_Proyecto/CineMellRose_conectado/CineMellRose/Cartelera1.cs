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
            //CargaInfo();


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
            string sql;
            string conexion = "Data Source=JAMES\\SQLEXPRESS;" +
                              "Initial Catalog=Cinee;" +
                              "Integrated Security=True;"
                               ;
            DataTable dt = new DataTable();
            sql = "select " +
                "pelicula" + " as 'Pédula'," +
                "titulo" + " as Titulo," +
                "duracion" + " as Duracion," +
                "horarios" + " as Horario," +
                "actores" + " as Actores," +
                "categoria" + " as Categoria," +
                 "idioma" + " as Idioma," +
                "sinopsis" + " as 'Sinopsis'" +
                " from " +
                "peliculas";
            SqlConnection sqlconn = new SqlConnection(conexion);
            sqlconn.Open();
            SqlDataAdapter sqlda = new SqlDataAdapter(sql, sqlconn);
            sqlda.Fill(dt);
            sqlconn.Close();
            Pelicula1.Text = dt.Rows[0][1].ToString();
            Pelicula2.Text = dt.Rows[1][1].ToString();
            Pelicula3.Text = dt.Rows[2][1].ToString();
            Pelicula4.Text = dt.Rows[3][1].ToString();
            Pelicula5.Text = dt.Rows[4][1].ToString();
            Horario1.Text = dt.Rows[0][3].ToString();
            Horario2.Text = dt.Rows[1][3].ToString();
            Horario3.Text = dt.Rows[2][3].ToString();
            Horario4.Text = dt.Rows[3][3].ToString();
            Horario5.Text = dt.Rows[4][3].ToString();
            Duracion1.Text = dt.Rows[0][2].ToString();
            Duracion2.Text = dt.Rows[1][2].ToString();
            Duracion3.Text = dt.Rows[2][2].ToString();
            Duracion4.Text = dt.Rows[3][2].ToString();
            Duracion5.Text = dt.Rows[4][2].ToString();

            //Cartelera2 pantalla2 = new Cartelera2();
            //Cartelera3 pantalla3 = new Cartelera3();

            //pantalla2.Show();
            //pantalla3.Show();
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblTit_Click(object sender, EventArgs e)
        {

        }
    }
}
