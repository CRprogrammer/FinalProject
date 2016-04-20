using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CineMellRose
{
    public partial class Test : Form
    {
        //Queries queries = new Queries();
        DataTable table = new DataTable();
        public Test()
        {
            InitializeComponent();
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //queries.Query(table);
        }

        private void Test_Load(object sender, EventArgs e)
        {
            string sql;
            string conexion = "Data Source=localhost; Initial Catalog=Prueba; Integrated Security=True;";
            DataTable dt = new DataTable();
            sql = "select cedula, nombre, apellido, ubicacion from empleado";
            SqlConnection sqlConn = new SqlConnection(conexion);
            sqlConn.Open();
            SqlDataAdapter sqlAdapter = new SqlDataAdapter(sql, sqlConn);
            sqlAdapter.Fill(dt);
            sqlConn.Close();
            dataGridView1.DataSource = dt;
        }
    }
}
