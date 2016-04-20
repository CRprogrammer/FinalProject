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
    public partial class DatoPelicula : Form
    {
        string mostrar = "";
        public DatoPelicula()
        {
            InitializeComponent();
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }
         
        private void DatoPelicula_Load(object sender, EventArgs e)
        {
            mostrar = Cartelera.peli;
            string conexion = "Data Source=JAMES\\SQLEXPRESS;" +
                                       "Initial Catalog=Cinee;" +
                                       "Integrated Security=True;"
                                        ;
            SqlConnection sqlconn = new SqlConnection(conexion);
            sqlconn.Open();
            SqlCommand sqlcomm = new SqlCommand();
            string sql;
            DataTable dt = new DataTable();
            sql = "select " +
                "id," +
                         "pelicula," +
                         "titulo," +
                         "duracion," +
                         "horarios," +
                         "actores," +
                         "categoria," +
                         "sinopsis," +
                         "estado," +
                         "idioma," +
                         "pais" +
                         " from " +
                         "peliculas" +
                         
                         " where " +
                         "id = " + mostrar;
            sqlcomm.Connection = sqlconn;
            sqlcomm.CommandText = sql;
            sqlcomm.CommandType = CommandType.Text;
            sqlcomm.ExecuteNonQuery();
            SqlDataAdapter sqlda = new SqlDataAdapter(sql, sqlconn);
            sqlda.Fill(dt);
            sqlconn.Close();

             txtPelicula.Text = dt.Rows[0][1].ToString();
           txtTitulo.Text = dt.Rows[0][2].ToString();
            txtDuracion.Text = dt.Rows[0][3].ToString();
            txtSala.Text = dt.Rows[0][1].ToString();
            txtActores.Text = dt.Rows[0][5].ToString();
           txtClasifi.Text = dt.Rows[0][6].ToString();
            txtSinopsis.Text = dt.Rows[0][7].ToString();
            txtEstado.Text = dt.Rows[0][8].ToString();
            txtIdioma.Text = dt.Rows[0][9].ToString();
            txtPais.Text = dt.Rows[0][10].ToString();






        }

        private void txtPelicula_SelectedIndexChanged(object sender, EventArgs e)
        {
            string conexion = "Data Source=JAMES\\SQLEXPRESS;" +
                                       "Initial Catalog=Cinee;" +
                                       "Integrated Security=True;"
                                        ;
            SqlConnection sqlconn = new SqlConnection(conexion);
            sqlconn.Open();
            SqlCommand sqlcomm = new SqlCommand();
            string sql;
            DataTable dt = new DataTable();
            sql = "select " +
                "id," +
                         "pelicula," +
                         "titulo," +
                         "duracion," +
                         "horarios," +
                         "actores," +
                         "categoria," +
                         "sinopsis," +
                         "estado," +
                         "idioma," +
                         "pais" +
                         " from " +
                         "peliculas" +

                         " where " +
                         "id = " + txtPelicula.Text;
            sqlcomm.Connection = sqlconn;
            sqlcomm.CommandText = sql;
            sqlcomm.CommandType = CommandType.Text;
            sqlcomm.ExecuteNonQuery();
            SqlDataAdapter sqlda = new SqlDataAdapter(sql, sqlconn);
            sqlda.Fill(dt);
            sqlconn.Close();

            txtPelicula.Text = dt.Rows[0][1].ToString();
            txtTitulo.Text = dt.Rows[0][2].ToString();
            txtDuracion.Text = dt.Rows[0][3].ToString();
            txtSala.Text = dt.Rows[0][1].ToString();
            txtActores.Text = dt.Rows[0][5].ToString();
            txtClasifi.Text = dt.Rows[0][6].ToString();
            txtSinopsis.Text = dt.Rows[0][7].ToString();
            txtEstado.Text = dt.Rows[0][8].ToString();
            txtIdioma.Text = dt.Rows[0][9].ToString();
            txtPais.Text = dt.Rows[0][10].ToString();
        }
    }
}
