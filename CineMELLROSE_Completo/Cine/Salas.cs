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
    public partial class Salas : Form
    {
        public Salas()
        {
            InitializeComponent();
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
            " salas " +
            "set " +
            "tipo  = '" + cbxTipo.Text + "'," +
            "valor_tipo = '" + txtVtipo.Text + "'," +
            "valor_niños = '" + txtVniños.Text + "'," +
            "valor_adultos = '" + txtVadultos.Text + "'," +
            "valor_mayores = '" + txtVmayores.Text + "'" +
            " where sala = " + txtSala.Text;
            sqlcomm.Connection = sqlconn;
            sqlcomm.CommandText = sql;
            sqlcomm.CommandType = CommandType.Text;
            sqlcomm.ExecuteNonQuery();
            sqlconn.Close();
            sql = "select " +
                "sala" + " as 'Sala'," +
                "tipo" + " as Tipo," +
                "valor_tipo" + " as Valor_tipo," +
                "valor_niños" + " as Valor_niños," +
                "valor_adultos" + " Valor_adultos," +
                "valor_mayores" + " as 'Valor_mayores'" +
                " from " +
                "salas";
            sqlconn.Open();
            SqlDataAdapter sqlda = new SqlDataAdapter(sql, sqlconn);
            sqlda.Fill(dt);
            sqlconn.Close();
            dataGridView1.DataSource = dt;
        }

        private void Salas_Load(object sender, EventArgs e)
        {
            string sql;
            string conexion = "Data Source=JAMES\\SQLEXPRESS;" +
                              "Initial Catalog=Cinee;" +
                              "Integrated Security=True;"
                               ;


            DataTable dt = new DataTable();
            sql = "select " +
                "sala" + " as 'Sala'," +
                "tipo" + " as Tipo," +
                "valor_tipo" + " as Valor_tipo," +
                "valor_niños" + " as Valor_niños," +
                "valor_adultos" + " Valor_adultos," +
                "valor_mayores" + " as 'Valor_mayores'" +
                " from " +
                "salas";
            SqlConnection sqlconn = new SqlConnection(conexion);
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
