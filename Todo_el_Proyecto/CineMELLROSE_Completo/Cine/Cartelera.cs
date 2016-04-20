using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
namespace Cine
{
    public partial class Cartelera : Form
    {
        int n = 1;
        static asientos Salas1 = new asientos();
        static asientos Salas2 = new asientos();
        static asientos Salas3 = new asientos();
        static asientos Salas4 = new asientos();
        static asientos Salas5 = new asientos();
        DatoPelicula Pelicula = new DatoPelicula();
        public static string peli = "";
         public static string factu = "";
        public Cartelera()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (Administrador.Editar.Equals("Imagenes"))
            {
                btnSubir1.Visible = true;
                btnSubir2.Visible = true;
                btnSubir3.Visible = true;
                btnSubir4.Visible = true;
                btnSubir5.Visible = true;
                button1.Visible = true;
            }
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
            lblPeli1.Text = dt.Rows[0][1].ToString();
            lblPeli2.Text = dt.Rows[1][1].ToString();
            lblPeli3.Text = dt.Rows[2][1].ToString();
            lblPeli4.Text = dt.Rows[3][1].ToString();
            lblPeli5.Text = dt.Rows[4][1].ToString();
            lblIdioma1.Text = dt.Rows[0][6].ToString();
            lblIdioma2.Text = dt.Rows[1][6].ToString();
            lblIdioma3.Text = dt.Rows[2][6].ToString();
            lblIdioma4.Text = dt.Rows[3][6].ToString();
            lblIdioma5.Text = dt.Rows[4][6].ToString();
            lblHorario1.Text = dt.Rows[0][3].ToString();
            lblHorario2.Text = dt.Rows[1][3].ToString();
            lblHorario3.Text = dt.Rows[2][3].ToString();
            lblHorario4.Text = dt.Rows[3][3].ToString();
            lblHorario5.Text = dt.Rows[4][3].ToString();

        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void Sala1_Click(object sender, EventArgs e)
        {
            if(Administrador.Editar.Equals(""))
            {
                factu = "1";
                
                Salas1.Visible = true;
                this.Visible = false;
            }
           
        }

        private void Sala2_Click(object sender, EventArgs e)
        {
            if (Administrador.Editar.Equals(""))
            {
                factu = "2";
                Salas2.Visible = true;
                this.Visible = false;
            }
        }

        private void Sala3_Click(object sender, EventArgs e)
        {
            if (Administrador.Editar.Equals(""))
            {
                factu = "3";
                Salas3.Visible = true;
                this.Visible = false;
            }
        }

        private void Sala4_Click(object sender, EventArgs e)
        {
            if (Administrador.Editar.Equals(""))
            {
                factu = "4";
                Salas4.Visible = true;
                this.Visible = false;
            }
        }

        private void Sala5_Click(object sender, EventArgs e)
        {
            if (Administrador.Editar.Equals(""))
            {
                factu = "5";
                Salas5.Visible = true;
                this.Visible = false;
            }
        }

        private void Pelicula1_Click(object sender, EventArgs e)
        {
            peli = "1";
            Pelicula.Visible = true;
            peli = "";
        }

        private void Pelicula2_Click(object sender, EventArgs e)
        {
            peli = "2";
            Pelicula.Visible = true;
        }

        private void Pelicula3_Click(object sender, EventArgs e)
        {
            peli = "3";
            Pelicula.Visible = true;

        }

        private void Pelicula4_Click(object sender, EventArgs e)
        {
            peli = "4";
            Pelicula.Visible = true;
        }

        private void Pelicula5_Click(object sender, EventArgs e)
        {
            peli = "5";
            Pelicula.Visible = true;
        }

        private void btnSubir1_Click(object sender, EventArgs e)
        {
            OpenFileDialog subir = new OpenFileDialog();
            subir.Filter = "Archivos JPEG(*.jpg) | *.jpg";
            subir.InitialDirectory = "C:/";
            if(subir.ShowDialog() == DialogResult.OK)
            {
                String dir = subir.FileName;
                Pelicula1.SizeMode = PictureBoxSizeMode.StretchImage;
                Bitmap imagen = new Bitmap(dir);
                Pelicula1.Image = (Image)imagen;
            }

        }

        private void btnSubir2_Click(object sender, EventArgs e)
        {
            OpenFileDialog subir = new OpenFileDialog();
            subir.Filter = "Archivos JPEG(*.jpg) | *.jpg";
            subir.InitialDirectory = "C:/";
            if (subir.ShowDialog() == DialogResult.OK)
            {
                String dir = subir.FileName;
                Pelicula2.SizeMode = PictureBoxSizeMode.StretchImage;
                Bitmap imagen = new Bitmap(dir);
                Pelicula2.Image = (Image)imagen;
            }
        }

        private void btnSubir3_Click(object sender, EventArgs e)
        {
            OpenFileDialog subir = new OpenFileDialog();
            subir.Filter = "Archivos JPEG(*.jpg) | *.jpg";
            subir.InitialDirectory = "C:/";
            if (subir.ShowDialog() == DialogResult.OK)
            {
                String dir = subir.FileName;
                Pelicula3.SizeMode = PictureBoxSizeMode.StretchImage;
                Bitmap imagen = new Bitmap(dir);
                Pelicula3.Image = (Image)imagen;
            }
        }

        private void btnSubir4_Click(object sender, EventArgs e)
        {
            OpenFileDialog subir = new OpenFileDialog();
            subir.Filter = "Archivos JPEG(*.jpg) | *.jpg";
            subir.InitialDirectory = "C:/";
            if (subir.ShowDialog() == DialogResult.OK)
            {
                String dir = subir.FileName;
                Pelicula4.SizeMode = PictureBoxSizeMode.StretchImage;
                Bitmap imagen = new Bitmap(dir);
                Pelicula4.Image = (Image)imagen;
            }
        }

        private void btnSubir5_Click(object sender, EventArgs e)
        {
            OpenFileDialog subir = new OpenFileDialog();
            subir.Filter = "Archivos JPEG(*.jpg) | *.jpg";
            subir.InitialDirectory = "C:/";
            if (subir.ShowDialog() == DialogResult.OK)
            {
                String dir = subir.FileName;
                Pelicula5.SizeMode = PictureBoxSizeMode.StretchImage;
                Bitmap imagen = new Bitmap(dir);
                Pelicula5.Image = (Image)imagen;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Administrador.Editar = "";
            this.Visible = false;
        }

        private void lblIdioma3_Click(object sender, EventArgs e)
        {

        }
    }
}
