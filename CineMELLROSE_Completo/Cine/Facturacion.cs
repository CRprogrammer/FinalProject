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
    public partial class Facturacion : Form
    {
        public static string asientoss = "";
        public static string Tipo = "";
        public static string ValorT = "";
        public static string ValorN= "";
        public static string ValorA = "";
        public static string ValorM = "";
        public Facturacion()
        {
            InitializeComponent();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
                int n = 0;
                int a = 0;
                int m = 0;
            int t;
            if(txtNiños.Text != ValorN)
            {
                n = int.Parse(ValorN) * int.Parse(txtNiños.Text);
            }
           else if (txtNiños.Text != ValorA)
            {
                a = int.Parse(ValorA) * int.Parse(txtAdulto.Text);
            }
          else   if (txtNiños.Text != ValorM)
            {
                m = int.Parse(ValorM) * int.Parse(txtMayor.Text);
            }
            t = n + a + m + int.Parse(ValorT);
            string pagar = t.ToString();
            Archivo guardarFac = new Archivo();
            guardarFac.GuardarArchivo(txtFactu.Text);
            guardarFac.GuardarArchivo(txtPago.Text + " $" + pagar);
            guardarFac.GuardarArchivo("//////////////////////////////////////////////////////////////////");
            InicioMenu salir = new InicioMenu();
            salir.Visible = true;
            this.Visible = false;

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Facturacion_Load(object sender, EventArgs e)
        {
            txtPago.Text = "efectivo";
            txtNiños.Text = ValorN;
            txtAdulto.Text = ValorA;
            txtMayor.Text = ValorM;
            
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
                         "id = " + asientos.peli;
            sqlcomm.Connection = sqlconn;
            sqlcomm.CommandText = sql;
            sqlcomm.CommandType = CommandType.Text;
            sqlcomm.ExecuteNonQuery();
            SqlDataAdapter sqlda = new SqlDataAdapter(sql, sqlconn);
            sqlda.Fill(dt);
            sqlconn.Close();

           txtFactu.Text = dt.Rows[0][2].ToString() + " \n "+  " Duracion " + dt.Rows[0][3].ToString() + " \n " + " Sala " + dt.Rows[0][1].ToString() + " \n " + " Horario " + dt.Rows[0][4].ToString() + " \n " + " asientos "+ asientoss + " \n " + "Tipo de sala " + Tipo + " \n " +"$"+ ValorT;
           

            
        }

        private void txtNiños_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
