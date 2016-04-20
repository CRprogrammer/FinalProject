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
    public partial class Usuarios : Form
    {
        public Usuarios()
        {
            InitializeComponent();
        }

        private void Usuarios_Load(object sender, EventArgs e)
        {
            string sql;
            string conexion = "Data Source=JAMES\\SQLEXPRESS;" +
                              "Initial Catalog=Cinee;" +
                              "Integrated Security=True;"
                               ;


            DataTable dt = new DataTable();
            sql = "select " +
                "id" + " as 'Id'," +
                "usuario" + " as Usuario," +
                "contraseña" + " as Contraseña," +
                "tipo" + " as 'Tipo'" +
                " from " +
                "usuarios";
            SqlConnection sqlconn = new SqlConnection(conexion);
            sqlconn.Open();
            SqlDataAdapter sqlda = new SqlDataAdapter(sql, sqlconn);
            sqlda.Fill(dt);
            sqlconn.Close();
            dataGridView1.DataSource = dt;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
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
            sql = "insert into usuarios (" +
                "id," +
                "usuario," +
                "contraseña," +
                
                "tipo" +
                ") values (" +
                "'" + txtID.Text + "'," +
                 "'" + txtUsuario.Text + "'," +
                "'" + txtContraseña.Text + "'," +
               
                "'" + cbxTipo.Text + "'" +
                ")";
            sqlcomm.Connection = sqlconn;
            sqlcomm.CommandText = sql;
            sqlcomm.CommandType = CommandType.Text;
            sqlcomm.ExecuteNonQuery();
            sqlconn.Close();
            sql = "select " +
                "id" + " as 'Id'," +
                "usuario" + " as Usuario," +
                "contraseña" + " as Contraseña," +
                "tipo" + " as 'Tipo'" +
                " from " +
                "usuarios";
            sqlconn.Open();
            SqlDataAdapter sqlda = new SqlDataAdapter(sql, sqlconn);
            sqlda.Fill(dt);
            sqlconn.Close();
            dataGridView1.DataSource = dt;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
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
                "usuario," +
                "contraseña," +
                "tipo" +
                " from " +
                "usuarios" +
                " where " +
                "id = " + txtID.Text;
            sqlcomm.Connection = sqlconn;
            sqlcomm.CommandText = sql;
            sqlcomm.CommandType = CommandType.Text;
            sqlcomm.ExecuteNonQuery();
            SqlDataAdapter sqlda = new SqlDataAdapter(sql, sqlconn);
            sqlda.Fill(dt);
            sqlconn.Close();
            txtUsuario.Text = dt.Rows[0][1].ToString();
            txtContraseña.Text = dt.Rows[0][2].ToString();
            cbxTipo.Text = dt.Rows[0][3].ToString();
            //string conexion = "Data Source=JAMES\\SQLEXPRESS;" +
            //                  "Initial Catalog=Cinee;" +
            //                  "Integrated Security=True;"
            //                   ;
            //SqlConnection sqlconn = new SqlConnection(conexion);
            //sqlconn.Open();
            //SqlCommand sqlcomm = new SqlCommand();
            //string sql;
            //DataTable dt = new DataTable();
            //sql = "delete from" +
            //" usuarios " +
            //" where " +
            //"id = " + txtID.Text;
            //sqlcomm.Connection = sqlconn;
            //sqlcomm.CommandText = sql;
            //sqlcomm.CommandType = CommandType.Text;
            //sqlcomm.ExecuteNonQuery();
            //sqlconn.Close();
            //sql = "select " +
            //    "id" + " as 'Id'," +
            //    "usuario" + " as Usuario," +
            //    "contraseña" + " as Contraseña," +
            //    "tipo" + " as 'Tipo'" +
            //    " from " +
            //    "usuarios";
            //sqlconn.Open();
            //SqlDataAdapter sqlda = new SqlDataAdapter(sql, sqlconn);
            //sqlda.Fill(dt);
            //sqlconn.Close();
            //dataGridView1.DataSource = dt;

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
            " usuarios " +
            "set " +
            "contraseña  = '" + txtContraseña.Text + "'," +

            "tipo = '" + cbxTipo.Text + "'" +
            " where id = " + txtUsuario.Text;
            sqlcomm.Connection = sqlconn;
            sqlcomm.CommandText = sql;
            sqlcomm.CommandType = CommandType.Text;
            sqlcomm.ExecuteNonQuery();
            sqlconn.Close();
            sql = "select " +
                "id" + " as 'Id'," +
                "usuario" + " as Usuario," +
                "contraseña" + " as Contraseña," +
                "tipo" + " as 'Tipo'" +
                " from " +
                "usuarios";
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

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
