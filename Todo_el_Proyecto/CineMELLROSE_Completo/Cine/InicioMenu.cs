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
    public partial class InicioMenu : Form
    {
        
        
        
         Cartelera abrir = new Cartelera();
         Administrador entrar = new Administrador();
        public InicioMenu()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
           
            
            
        }

        private void btningresar_Click(object sender, EventArgs e)
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
                    "id = " + textBox1.Text;
                sqlcomm.Connection = sqlconn;
                sqlcomm.CommandText = sql;
                sqlcomm.CommandType = CommandType.Text;
                sqlcomm.ExecuteNonQuery();
                SqlDataAdapter sqlda = new SqlDataAdapter(sql, sqlconn);
                sqlda.Fill(dt);
                sqlconn.Close();
               
                string contra = dt.Rows[0][2].ToString();
                string tipo = dt.Rows[0][3].ToString();
                if (textBox2.Text == contra)
                {
                    

                    if (tipo == "Cliente")
                    {
                        abrir.Visible = true;
                        this.Visible = false;
                    }
                    else if (tipo == "Administrador")
                    {
                        entrar.Visible = true;
                        this.Visible = false;
                    }
                    else if (tipo == "Dependiente")
                    {
                        abrir.Visible = true;
                        this.Visible = false;

                    }
                }


            
           
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            NuevoUsuario nuevo = new NuevoUsuario();
            nuevo.Visible = true;
           this.Visible = false;
            
        }

        private void InicioMenu_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
           
        }
    }
}
