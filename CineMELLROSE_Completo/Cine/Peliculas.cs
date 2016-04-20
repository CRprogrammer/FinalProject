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
    public partial class Peliculas : Form
    {
        public Peliculas()
        {
            InitializeComponent();
        }

        private void Peliculas_Load(object sender, EventArgs e)
        {
            string sql;
            string conexion = "Data Source=JAMES\\SQLEXPRESS;" +
                              "Initial Catalog=Cinee;"+
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
                "sinopsis" + " as 'Sinopsis'" +
                " from " +
                "peliculas";
            SqlConnection sqlconn = new SqlConnection(conexion);
            sqlconn.Open();
            SqlDataAdapter sqlda = new SqlDataAdapter(sql, sqlconn);
            sqlda.Fill(dt);
            sqlconn.Close();
            dataGridView1.DataSource = dt;
        }

        private void btnModificar_Click(object sender, EventArgs e)
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
            sql = "update" +
            " peliculas " +
            "set " +
            "titulo  = '" + txtTitulo.Text + "'," +
            "duracion = '" + txtDuracion.Text + "'," +
            "horarios = '" + txtHorarios.Text + "'," +
            "actores = '" + txtActores.Text + "'," +
            "categoria = '" + cbxCategoria.Text + "'," +
            "sinopsis = '" + txtsinopsis.Text + "'" +
            " where pelicula = " + txtPelicula.Text;
            sqlcomm.Connection = sqlconn;
            sqlcomm.CommandText = sql;
            sqlcomm.CommandType = CommandType.Text;
            sqlcomm.ExecuteNonQuery();
            sqlconn.Close();
            sql = "select " +
                "pelicula" + " as 'Pédula'," +
                "titulo" + " as Titulo," +
                "duracion" + " as Duracion," +
                "horarios" + " as Horario," +
                "actores" + " as Actores," +
                "categoria" + " as Categoria," +
                "sinopsis" + " as 'Sinopsis'" +
                " from " +
                "peliculas";
            sqlconn.Open();
            SqlDataAdapter sqlda = new SqlDataAdapter(sql, sqlconn);
            sqlda.Fill(dt);
            sqlconn.Close();
            dataGridView1.DataSource = dt;
        }

        private void btnListo_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }
    }
}
