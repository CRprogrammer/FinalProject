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
    public partial class NuevoUsuario : Form
    {
        public NuevoUsuario()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
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
                "'" + txtCedula.Text + "'," +
                "'" + txtNombre.Text + "'," +
                "'" + txtContraseña.Text + "'," +

                "'" + "Cliente" + "'" +
                ")";
            sqlcomm.Connection = sqlconn;
            sqlcomm.CommandText = sql;
            sqlcomm.CommandType = CommandType.Text;
            sqlcomm.ExecuteNonQuery();
            sqlconn.Close();
           
            

            Cartelera abrir = new Cartelera();
            abrir.Visible = true;
            this.Visible = false;

        }

        private void NuevoUsuario_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }
    }
}
