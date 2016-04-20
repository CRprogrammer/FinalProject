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
    
    public partial class asientos : Form
    {
        public static string peli = "";
        Cartelera regresar = new Cartelera();
        static Facturacion fac = new Facturacion();
        string asiento = "";
        public asientos()
        {
            InitializeComponent();
        }

        private void A1_Click(object sender, EventArgs e)
        {
            if(asiento == "")
            {
                asiento = "A1";
            }
            else
            {
                asiento =asiento + "-A1";
            }
            
            this.A1.BackColor = Color.Red;
        }
        
        

        private void asientos_Load(object sender, EventArgs e)
        {
            peli = Cartelera.factu;
            asiento = "";
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
               
                         "sala," +
                         "tipo," +
                         "valor_tipo," +
                         "valor_niños," +
                         "valor_adultos," +
                         "valor_mayores" +
                         
                         " from " +
                         "salas" +

                         " where " +
                         "sala = " + peli;
            sqlcomm.Connection = sqlconn;
            sqlcomm.CommandText = sql;
            sqlcomm.CommandType = CommandType.Text;
            sqlcomm.ExecuteNonQuery();
            SqlDataAdapter sqlda = new SqlDataAdapter(sql, sqlconn);
            sqlda.Fill(dt);
            sqlconn.Close();
            Facturacion.Tipo =  dt.Rows[0][1].ToString();
            Facturacion.ValorT = dt.Rows[0][2].ToString();
            Facturacion.ValorN = dt.Rows[0][3].ToString();
            Facturacion.ValorA = dt.Rows[0][4].ToString();
            Facturacion.ValorM = dt.Rows[0][5].ToString();

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void A2_Click(object sender, EventArgs e)
        {
            
            if (asiento == "")
            {
                asiento = "A2";
            }
            else
            {
                asiento = asiento + "-A2";
            }

            this.A2.BackColor = Color.Red;
        
    }

        private void A3_Click(object sender, EventArgs e)
        {
           
        
            if (asiento == "")
            {
                asiento = "A3";
            }
            else
            {
                asiento = asiento + "-A3";
            }

            this.A3.BackColor = Color.Red;
        
    }

        private void A4_Click(object sender, EventArgs e)
        {

            if (asiento == "")
            {
                asiento = "A4";
            }
            else
            {
                asiento = asiento + "-A4";
            }

            this.A4.BackColor = Color.Red;
        }

        private void A5_Click(object sender, EventArgs e)
        {

            if (asiento == "")
            {
                asiento = "A5";
            }
            else
            {
                asiento = asiento + "-A5";
            }

            this.A5.BackColor = Color.Red;
        }

        private void A6_Click(object sender, EventArgs e)
        {

            if (asiento == "")
            {
                asiento = "A6";
            }
            else
            {
                asiento = asiento + "-A6";
            }

            this.A6.BackColor = Color.Red;
        }

        private void A7_Click(object sender, EventArgs e)
        {

            if (asiento == "")
            {
                asiento = "A7";
            }
            else
            {
                asiento = asiento + "-A7";
            }

            this.A7.BackColor = Color.Red;
        }

        private void A8_Click(object sender, EventArgs e)
        {

            if (asiento == "")
            {
                asiento = "A8";
            }
            else
            {
                asiento = asiento + "-A8";
            }

            this.A8.BackColor = Color.Red;
        }

        private void A9_Click(object sender, EventArgs e)
        {

            if (asiento == "")
            {
                asiento = "A9";
            }
            else
            {
                asiento = asiento + "-A9";
            }

            this.A9.BackColor = Color.Red;
        }

        private void A10_Click(object sender, EventArgs e)
        {

            if (asiento == "")
            {
                asiento = "A10";
            }
            else
            {
                asiento = asiento + "-A10";
            }

            this.A10.BackColor = Color.Red;
        }

        private void A11_Click(object sender, EventArgs e)
        {

            if (asiento == "")
            {
                asiento = "A11";
            }
            else
            {
                asiento = asiento + "-A11";
            }

            this.A11.BackColor = Color.Red;
        }

        private void A12_Click(object sender, EventArgs e)
        {

            if (asiento == "")
            {
                asiento = "A12";
            }
            else
            {
                asiento = asiento + "-A12";
            }

            this.A12.BackColor = Color.Red;
        }

        private void A13_Click(object sender, EventArgs e)
        {

            if (asiento == "")
            {
                asiento = "A13";
            }
            else
            {
                asiento = asiento + "-A13";
            }

            this.A13.BackColor = Color.Red;
        }

        private void A14_Click(object sender, EventArgs e)
        {

            if (asiento == "")
            {
                asiento = "A14";
            }
            else
            {
                asiento = asiento + "-A14";
            }

            this.A14.BackColor = Color.Red;
        }

        private void A15_Click(object sender, EventArgs e)
        {

            if (asiento == "")
            {
                asiento = "A15";
            }
            else
            {
                asiento = asiento + "-A15";
            }

            this.A15.BackColor = Color.Red;
        }

        private void A16_Click(object sender, EventArgs e)
        {

            if (asiento == "")
            {
                asiento = "A16";
            }
            else
            {
                asiento = asiento + "-A16";
            }

            this.A16.BackColor = Color.Red;
        }

        private void A17_Click(object sender, EventArgs e)
        {

            if (asiento == "")
            {
                asiento = "A17";
            }
            else
            {
                asiento = asiento + "-A17";
            }

            this.A17.BackColor = Color.Red;
        }

        private void B1_Click(object sender, EventArgs e)
        {

            if (asiento == "")
            {
                asiento = "B1";
            }
            else
            {
                asiento = asiento + "-B1";
            }

            this.B1.BackColor = Color.Red;
        }

        private void B2_Click(object sender, EventArgs e)
        {
            if (asiento == "")
            {
                asiento = "B2";
            }
            else
            {
                asiento = asiento + "-B2";
            }

            this.B2.BackColor = Color.Red;
        }

        private void B3_Click(object sender, EventArgs e)
        {
            if (asiento == "")
            {
                asiento = "B3";
            }
            else
            {
                asiento = asiento + "-B3";
            }

            this.B3.BackColor = Color.Red;
        }

        private void B4_Click(object sender, EventArgs e)
        {
            if (asiento == "")
            {
                asiento = "B4";
            }
            else
            {
                asiento = asiento + "-B4";
            }

            this.B4.BackColor = Color.Red;
        }

        private void B5_Click(object sender, EventArgs e)
        {
            if (asiento == "")
            {
                asiento = "B5";
            }
            else
            {
                asiento = asiento + "-B5";
            }

            this.B5.BackColor = Color.Red;
        }

        private void B6_Click(object sender, EventArgs e)
        {
            if (asiento == "")
            {
                asiento = "B6";
            }
            else
            {
                asiento = asiento + "-B6";
            }

            this.B6.BackColor = Color.Red;
        }

        private void B7_Click(object sender, EventArgs e)
        {
            if (asiento == "")
            {
                asiento = "B7";
            }
            else
            {
                asiento = asiento + "-B7";
            }

            this.B7.BackColor = Color.Red;
        }

        private void B8_Click(object sender, EventArgs e)
        {
            if (asiento == "")
            {
                asiento = "B8";
            }
            else
            {
                asiento = asiento + "-B8";
            }

            this.B8.BackColor = Color.Red;
        }

        private void B9_Click(object sender, EventArgs e)
        {
            if (asiento == "")
            {
                asiento = "B9";
            }
            else
            {
                asiento = asiento + "-B9";
            }

            this.B9.BackColor = Color.Red;
        }

        private void B10_Click(object sender, EventArgs e)
        {
            if (asiento == "")
            {
                asiento = "B10";
            }
            else
            {
                asiento = asiento + "-B10";
            }

            this.B10.BackColor = Color.Red;
        }

        private void B11_Click(object sender, EventArgs e)
        {
            if (asiento == "")
            {
                asiento = "B11";
            }
            else
            {
                asiento = asiento + "-B11";
            }

            this.B11.BackColor = Color.Red;
        }

        private void B12_Click(object sender, EventArgs e)
        {
            if (asiento == "")
            {
                asiento = "B12";
            }
            else
            {
                asiento = asiento + "-B12";
            }

            this.B12.BackColor = Color.Red;
        }

        private void B13_Click(object sender, EventArgs e)
        {
            if (asiento == "")
            {
                asiento = "B13";
            }
            else
            {
                asiento = asiento + "-B13";
            }

            this.B13.BackColor = Color.Red;
        }

        private void B14_Click(object sender, EventArgs e)
        {
            if (asiento == "")
            {
                asiento = "B14";
            }
            else
            {
                asiento = asiento + "-B14";
            }

            this.B14.BackColor = Color.Red;
        }

        private void B15_Click(object sender, EventArgs e)
        {
            if (asiento == "")
            {
                asiento = "B15";
            }
            else
            {
                asiento = asiento + "-B15";
            }

            this.B15.BackColor = Color.Red;
        }

        private void B16_Click(object sender, EventArgs e)
        {
            if (asiento == "")
            {
                asiento = "B16";
            }
            else
            {
                asiento = asiento + "-B16";
            }

            this.B16.BackColor = Color.Red;
        }

        private void B17_Click(object sender, EventArgs e)
        {
            if (asiento == "")
            {
                asiento = "B17";
            }
            else
            {
                asiento = asiento + "-B17";
            }

            this.B17.BackColor = Color.Red;
        }

        private void B18_Click(object sender, EventArgs e)
        {
            if (asiento == "")
            {
                asiento = "B18";
            }
            else
            {
                asiento = asiento + "-B18";
            }

            this.B18.BackColor = Color.Red;
        }

        private void B19_Click(object sender, EventArgs e)
        {
            if (asiento == "")
            {
                asiento = "B19";
            }
            else
            {
                asiento = asiento + "-B19";
            }

            this.B19.BackColor = Color.Red;
        }

        private void B20_Click(object sender, EventArgs e)
        {
            if (asiento == "")
            {
                asiento = "B20";
            }
            else
            {
                asiento = asiento + "-B20";
            }

            this.B20.BackColor = Color.Red;
        }

        private void B21_Click(object sender, EventArgs e)
        {
            if (asiento == "")
            {
                asiento = "B21";
            }
            else
            {
                asiento = asiento + "-B21";
            }

            this.B21.BackColor = Color.Red;
        }

        private void B22_Click(object sender, EventArgs e)
        {
            if (asiento == "")
            {
                asiento = "B22";
            }
            else
            {
                asiento = asiento + "-B22";
            }

            this.B22.BackColor = Color.Red;
        }

        private void B23_Click(object sender, EventArgs e)
        {
            if (asiento == "")
            {
                asiento = "B23";
            }
            else
            {
                asiento = asiento + "-B23";
            }

            this.B23.BackColor = Color.Red;
        }

        private void B24_Click(object sender, EventArgs e)
        {
            if (asiento == "")
            {
                asiento = "B24";
            }
            else
            {
                asiento = asiento + "-B24";
            }

            this.B24.BackColor = Color.Red;
        }

        private void C1_Click(object sender, EventArgs e)
        {
            if (asiento == "")
            {
                asiento = "C1";
            }
            else
            {
                asiento = asiento + "-C1";
            }

            this.C1.BackColor = Color.Red;
        }

        private void C2_Click(object sender, EventArgs e)
        {
            if (asiento == "")
            {
                asiento = "C2";
            }
            else
            {
                asiento = asiento + "-C2";
            }

            this.C2.BackColor = Color.Red;
        }

        private void C3_Click(object sender, EventArgs e)
        {
            if (asiento == "")
            {
                asiento = "C3";
            }
            else
            {
                asiento = asiento + "-C3";
            }

            this.C3.BackColor = Color.Red;
        }

        private void C4_Click(object sender, EventArgs e)
        {
            if (asiento == "")
            {
                asiento = "C4";
            }
            else
            {
                asiento = asiento + "-C4";
            }

            this.C4.BackColor = Color.Red;
        }

        private void C5_Click(object sender, EventArgs e)
        {
            if (asiento == "")
            {
                asiento = "C5";
            }
            else
            {
                asiento = asiento + "-C5";
            }

            this.C5.BackColor = Color.Red;
        }

        private void C6_Click(object sender, EventArgs e)
        {
            if (asiento == "")
            {
                asiento = "C6";
            }
            else
            {
                asiento = asiento + "-C6";
            }

            this.C6.BackColor = Color.Red;
        }

        private void C7_Click(object sender, EventArgs e)
        {
            if (asiento == "")
            {
                asiento = "C7";
            }
            else
            {
                asiento = asiento + "-C7";
            }

            this.C7.BackColor = Color.Red;
        }

        private void C8_Click(object sender, EventArgs e)
        {
            if (asiento == "")
            {
                asiento = "C8";
            }
            else
            {
                asiento = asiento + "-C8";
            }

            this.C8.BackColor = Color.Red;
        }

        private void C9_Click(object sender, EventArgs e)
        {
            if (asiento == "")
            {
                asiento = "C9";
            }
            else
            {
                asiento = asiento + "-C9";
            }

            this.C9.BackColor = Color.Red;
        }

        private void C10_Click(object sender, EventArgs e)
        {
            if (asiento == "")
            {
                asiento = "C10";
            }
            else
            {
                asiento = asiento + "-C10";
            }

            this.C10.BackColor = Color.Red;
        }

        private void C11_Click(object sender, EventArgs e)
        {
            if (asiento == "")
            {
                asiento = "C11";
            }
            else
            {
                asiento = asiento + "-C11";
            }

            this.C11.BackColor = Color.Red;
        }

        private void C12_Click(object sender, EventArgs e)
        {
            if (asiento == "")
            {
                asiento = "C12";
            }
            else
            {
                asiento = asiento + "-C12";
            }

            this.C12.BackColor = Color.Red;
        }

        private void C13_Click(object sender, EventArgs e)
        {
            if (asiento == "")
            {
                asiento = "C13";
            }
            else
            {
                asiento = asiento + "-C13";
            }

            this.C13.BackColor = Color.Red;
        }

        private void C14_Click(object sender, EventArgs e)
        {
            if (asiento == "")
            {
                asiento = "C14";
            }
            else
            {
                asiento = asiento + "-C14";
            }

            this.C14.BackColor = Color.Red;
        }

        private void C15_Click(object sender, EventArgs e)
        {
            if (asiento == "")
            {
                asiento = "C15";
            }
            else
            {
                asiento = asiento + "-C15";
            }

            this.C15.BackColor = Color.Red;
        }

        private void C16_Click(object sender, EventArgs e)
        {
            if (asiento == "")
            {
                asiento = "C16";
            }
            else
            {
                asiento = asiento + "-C16";
            }

            this.C16.BackColor = Color.Red;
        }

        private void C17_Click(object sender, EventArgs e)
        {
            if (asiento == "")
            {
                asiento = "C17";
            }
            else
            {
                asiento = asiento + "-C17";
            }

            this.C17.BackColor = Color.Red;
        }

        private void C18_Click(object sender, EventArgs e)
        {
            if (asiento == "")
            {
                asiento = "C18";
            }
            else
            {
                asiento = asiento + "-C18";
            }

            this.C18.BackColor = Color.Red;
        }

        private void C19_Click(object sender, EventArgs e)
        {
            if (asiento == "")
            {
                asiento = "C19";
            }
            else
            {
                asiento = asiento + "-C19";
            }

            this.C19.BackColor = Color.Red;
        }

        private void C20_Click(object sender, EventArgs e)
        {
            if (asiento == "")
            {
                asiento = "C20";
            }
            else
            {
                asiento = asiento + "-C20";
            }

            this.C20.BackColor = Color.Red;
        }

        private void C21_Click(object sender, EventArgs e)
        {
            if (asiento == "")
            {
                asiento = "C21";
            }
            else
            {
                asiento = asiento + "-C21";
            }

            this.C21.BackColor = Color.Red;
        }

        private void C22_Click(object sender, EventArgs e)
        {
            if (asiento == "")
            {
                asiento = "C22";
            }
            else
            {
                asiento = asiento + "-C22";
            }

            this.C22.BackColor = Color.Red;
        }

        private void C23_Click(object sender, EventArgs e)
        {
            if (asiento == "")
            {
                asiento = "C23";
            }
            else
            {
                asiento = asiento + "-C23";
            }

            this.C23.BackColor = Color.Red;
        }

        private void C24_Click(object sender, EventArgs e)
        {
            if (asiento == "")
            {
                asiento = "C24";
            }
            else
            {
                asiento = asiento + "-C24";
            }

            this.C24.BackColor = Color.Red;
        }

        private void D1_Click(object sender, EventArgs e)
        {
            if (asiento == "")
            {
                asiento = "D1";
            }
            else
            {
                asiento = asiento + "-D1";
            }

            this.D1.BackColor = Color.Red;
        }

        private void D2_Click(object sender, EventArgs e)
        {
            if (asiento == "")
            {
                asiento = "D2";
            }
            else
            {
                asiento = asiento + "-D2";
            }

            this.D2.BackColor = Color.Red;
        }

        private void D3_Click(object sender, EventArgs e)
        {
            if (asiento == "")
            {
                asiento = "D3";
            }
            else
            {
                asiento = asiento + "-D3";
            }

            this.D3.BackColor = Color.Red;
        }

        private void D4_Click(object sender, EventArgs e)
        {
            if (asiento == "")
            {
                asiento = "D4";
            }
            else
            {
                asiento = asiento + "-D4";
            }

            this.D4.BackColor = Color.Red;
        }

        private void D5_Click(object sender, EventArgs e)
        {
            if (asiento == "")
            {
                asiento = "D5";
            }
            else
            {
                asiento = asiento + "-D5";
            }

            this.D5.BackColor = Color.Red;
        }

        private void D6_Click(object sender, EventArgs e)
        {
            if (asiento == "")
            {
                asiento = "D7";
            }
            else
            {
                asiento = asiento + "-D7";
            }

            this.D7.BackColor = Color.Red;
        }

        private void D7_Click(object sender, EventArgs e)
        {
            if (asiento == "")
            {
                asiento = "D8";
            }
            else
            {
                asiento = asiento + "-D8";
            }

            this.D8.BackColor = Color.Red;
        }

        private void D8_Click(object sender, EventArgs e)
        {
            if (asiento == "")
            {
                asiento = "D8";
            }
            else
            {
                asiento = asiento + "-D8";
            }

            this.D8.BackColor = Color.Red;
        }

        private void D9_Click(object sender, EventArgs e)
        {
            if (asiento == "")
            {
                asiento = "D9";
            }
            else
            {
                asiento = asiento + "-D9";
            }

            this.D9.BackColor = Color.Red;
        }

        private void D10_Click(object sender, EventArgs e)
        {
            if (asiento == "")
            {
                asiento = "D10";
            }
            else
            {
                asiento = asiento + "-D10";
            }

            this.D10.BackColor = Color.Red;
        }

        private void D11_Click(object sender, EventArgs e)
        {
            if (asiento == "")
            {
                asiento = "D11";
            }
            else
            {
                asiento = asiento + "-D11";
            }

            this.D11.BackColor = Color.Red;
        }

        private void D12_Click(object sender, EventArgs e)
        {
            if (asiento == "")
            {
                asiento = "D12";
            }
            else
            {
                asiento = asiento + "-D12";
            }

            this.D12.BackColor = Color.Red;
        }

        private void D13_Click(object sender, EventArgs e)
        {
            if (asiento == "")
            {
                asiento = "D13";
            }
            else
            {
                asiento = asiento + "-D13";
            }

            this.D13.BackColor = Color.Red;
        }

        private void D14_Click(object sender, EventArgs e)
        {
            if (asiento == "")
            {
                asiento = "D14";
            }
            else
            {
                asiento = asiento + "-D14";
            }

            this.D14.BackColor = Color.Red;
        }

        private void D15_Click(object sender, EventArgs e)
        {
            if (asiento == "")
            {
                asiento = "D15";
            }
            else
            {
                asiento = asiento + "-D15";
            }

            this.D15.BackColor = Color.Red;
        }

        private void D16_Click(object sender, EventArgs e)
        {
            if (asiento == "")
            {
                asiento = "D16";
            }
            else
            {
                asiento = asiento + "-D16";
            }

            this.D16.BackColor = Color.Red;
        }

        private void D17_Click(object sender, EventArgs e)
        {
            if (asiento == "")
            {
                asiento = "D17";
            }
            else
            {
                asiento = asiento + "-D17";
            }

            this.D17.BackColor = Color.Red;
        }

        private void D18_Click(object sender, EventArgs e)
        {
            if (asiento == "")
            {
                asiento = "D18";
            }
            else
            {
                asiento = asiento + "-D18";
            }

            this.D18.BackColor = Color.Red;
        }

        private void D19_Click(object sender, EventArgs e)
        {
            if (asiento == "")
            {
                asiento = "D19";
            }
            else
            {
                asiento = asiento + "-D19";
            }

            this.D19.BackColor = Color.Red;
        }

        private void D20_Click(object sender, EventArgs e)
        {
            if (asiento == "")
            {
                asiento = "D20";
            }
            else
            {
                asiento = asiento + "-D20";
            }

            this.D20.BackColor = Color.Red;
        }

        private void D21_Click(object sender, EventArgs e)
        {
            if (asiento == "")
            {
                asiento = "D21";
            }
            else
            {
                asiento = asiento + "-D21";
            }

            this.D21.BackColor = Color.Red;
        }

        private void D22_Click(object sender, EventArgs e)
        {
            if (asiento == "")
            {
                asiento = "D22";
            }
            else
            {
                asiento = asiento + "-D22";
            }

            this.D22.BackColor = Color.Red;
        }

        private void D23_Click(object sender, EventArgs e)
        {
            if (asiento == "")
            {
                asiento = "D23";
            }
            else
            {
                asiento = asiento + "-D23";
            }

            this.D23.BackColor = Color.Red;
        }

        private void D24_Click(object sender, EventArgs e)
        {
            if (asiento == "")
            {
                asiento = "D24";
            }
            else
            {
                asiento = asiento + "-D24";
            }

            this.D24.BackColor = Color.Red;
        }

        private void D25_Click(object sender, EventArgs e)
        {
            if (asiento == "")
            {
                asiento = "D25";
            }
            else
            {
                asiento = asiento + "-D25";
            }

            this.D25.BackColor = Color.Red;
        }

        private void D26_Click(object sender, EventArgs e)
        {
            if (asiento == "")
            {
                asiento = "D26";
            }
            else
            {
                asiento = asiento + "-D26";
            }

            this.D26.BackColor = Color.Red;
        }

        private void D27_Click(object sender, EventArgs e)
        {
            if (asiento == "")
            {
                asiento = "D27";
            }
            else
            {
                asiento = asiento + "-D27";
            }

            this.D27.BackColor = Color.Red;
        }

        private void D28_Click(object sender, EventArgs e)
        {
            if (asiento == "")
            {
                asiento = "D28";
            }
            else
            {
                asiento = asiento + "-D28";
            }

            this.D28.BackColor = Color.Red;
        }

        private void E1_Click(object sender, EventArgs e)
        {
            if (asiento == "")
            {
                asiento = "E1";
            }
            else
            {
                asiento = asiento + "-E1";
            }

            this.E1.BackColor = Color.Red;
        }

        private void E2_Click(object sender, EventArgs e)
        {
            if (asiento == "")
            {
                asiento = "E2";
            }
            else
            {
                asiento = asiento + "-E2";
            }

            this.E2.BackColor = Color.Red;
        }

        private void E3_Click(object sender, EventArgs e)
        {
            if (asiento == "")
            {
                asiento = "E3";
            }
            else
            {
                asiento = asiento + "-E3";
            }

            this.E3.BackColor = Color.Red;
        }

        private void E4_Click(object sender, EventArgs e)
        {
            if (asiento == "")
            {
                asiento = "E4";
            }
            else
            {
                asiento = asiento + "-E4";
            }

            this.E4.BackColor = Color.Red;
        }

        private void E5_Click(object sender, EventArgs e)
        {
            if (asiento == "")
            {
                asiento = "E5";
            }
            else
            {
                asiento = asiento + "-E5";
            }

            this.E5.BackColor = Color.Red;
        }

        private void E6_Click(object sender, EventArgs e)
        {
            if (asiento == "")
            {
                asiento = "E6";
            }
            else
            {
                asiento = asiento + "-E6";
            }

            this.E6.BackColor = Color.Red;
        }

        private void E7_Click(object sender, EventArgs e)
        {
            if (asiento == "")
            {
                asiento = "E7";
            }
            else
            {
                asiento = asiento + "-E7";
            }

            this.E7.BackColor = Color.Red;
        }

        private void E8_Click(object sender, EventArgs e)
        {
            if (asiento == "")
            {
                asiento = "E8";
            }
            else
            {
                asiento = asiento + "-E8";
            }

            this.E8.BackColor = Color.Red;
        }

        private void E9_Click(object sender, EventArgs e)
        {
            if (asiento == "")
            {
                asiento = "E9";
            }
            else
            {
                asiento = asiento + "-E9";
            }

            this.E9.BackColor = Color.Red;
        }

        private void E10_Click(object sender, EventArgs e)
        {
            if (asiento == "")
            {
                asiento = "E10";
            }
            else
            {
                asiento = asiento + "-E10";
            }

            this.E10.BackColor = Color.Red;
        }

        private void E11_Click(object sender, EventArgs e)
        {
            if (asiento == "")
            {
                asiento = "E11";
            }
            else
            {
                asiento = asiento + "-E11";
            }

            this.E11.BackColor = Color.Red;
        }

        private void E12_Click(object sender, EventArgs e)
        {
            if (asiento == "")
            {
                asiento = "E12";
            }
            else
            {
                asiento = asiento + "-E12";
            }

            this.E12.BackColor = Color.Red;
        }

        private void E13_Click(object sender, EventArgs e)
        {
            if (asiento == "")
            {
                asiento = "E13";
            }
            else
            {
                asiento = asiento + "-E13";
            }

            this.E13.BackColor = Color.Red;
        }

        private void E14_Click(object sender, EventArgs e)
        {
            if (asiento == "")
            {
                asiento = "E14";
            }
            else
            {
                asiento = asiento + "-E14";
            }

            this.E14.BackColor = Color.Red;
        }

        private void E15_Click(object sender, EventArgs e)
        {
            if (asiento == "")
            {
                asiento = "E15";
            }
            else
            {
                asiento = asiento + "-E15";
            }

            this.E15.BackColor = Color.Red;
        }

        private void E16_Click(object sender, EventArgs e)
        {
            if (asiento == "")
            {
                asiento = "E16";
            }
            else
            {
                asiento = asiento + "-E16";
            }

            this.E16.BackColor = Color.Red;
        }

        private void E17_Click(object sender, EventArgs e)
        {
            if (asiento == "")
            {
                asiento = "E17";
            }
            else
            {
                asiento = asiento + "-E17";
            }

            this.E17.BackColor = Color.Red;
        }

        private void E18_Click(object sender, EventArgs e)
        {
            if (asiento == "")
            {
                asiento = "E18";
            }
            else
            {
                asiento = asiento + "-E18";
            }

            this.E18.BackColor = Color.Red;
        }

        private void E19_Click(object sender, EventArgs e)
        {
            if (asiento == "")
            {
                asiento = "E19";
            }
            else
            {
                asiento = asiento + "-E19";
            }

            this.E19.BackColor = Color.Red;
        }

        private void E20_Click(object sender, EventArgs e)
        {
            if (asiento == "")
            {
                asiento = "E20";
            }
            else
            {
                asiento = asiento + "-E20";
            }

            this.E20.BackColor = Color.Red;
        }

        private void E21_Click(object sender, EventArgs e)
        {
            if (asiento == "")
            {
                asiento = "E21";
            }
            else
            {
                asiento = asiento + "-E21";
            }

            this.E21.BackColor = Color.Red;
        }

        private void E22_Click(object sender, EventArgs e)
        {
            if (asiento == "")
            {
                asiento = "E22";
            }
            else
            {
                asiento = asiento + "-E22";
            }

            this.E22.BackColor = Color.Red;
        }

        private void E23_Click(object sender, EventArgs e)
        {
            if (asiento == "")
            {
                asiento = "E23";
            }
            else
            {
                asiento = asiento + "-E23";
            }

            this.E23.BackColor = Color.Red;
        }

        private void E24_Click(object sender, EventArgs e)
        {
            if (asiento == "")
            {
                asiento = "E24";
            }
            else
            {
                asiento = asiento + "-E24";
            }

            this.E24.BackColor = Color.Red;
        }

        private void E25_Click(object sender, EventArgs e)
        {
            if (asiento == "")
            {
                asiento = "E25";
            }
            else
            {
                asiento = asiento + "-E25";
            }

            this.E25.BackColor = Color.Red;
        }

        private void E26_Click(object sender, EventArgs e)
        {
            if (asiento == "")
            {
                asiento = "E26";
            }
            else
            {
                asiento = asiento + "-E26";
            }

            this.E26.BackColor = Color.Red;
        }

        private void E27_Click(object sender, EventArgs e)
        {
            if (asiento == "")
            {
                asiento = "E27";
            }
            else
            {
                asiento = asiento + "-E27";
            }

            this.E27.BackColor = Color.Red;
        }

        private void E28_Click(object sender, EventArgs e)
        {
            if (asiento == "")
            {
                asiento = "E28";
            }
            else
            {
                asiento = asiento + "-E28";
            }

            this.E28.BackColor = Color.Red;
        }

        private void F1_Click(object sender, EventArgs e)
        {
            if (asiento == "")
            {
                asiento = "F1";
            }
            else
            {
                asiento = asiento + "-F1";
            }

            this.F1.BackColor = Color.Red;
        }

        private void F2_Click(object sender, EventArgs e)
        {

            if (asiento == "")
            {
                asiento = "F2";
            }
            else
            {
                asiento = asiento + "-F2";
            }

            this.F2.BackColor = Color.Red;
        }

        private void F3_Click(object sender, EventArgs e)
        {

            if (asiento == "")
            {
                asiento = "F3";
            }
            else
            {
                asiento = asiento + "-F3";
            }

            this.F3.BackColor = Color.Red;
        }

        private void F4_Click(object sender, EventArgs e)
        {

            if (asiento == "")
            {
                asiento = "F4";
            }
            else
            {
                asiento = asiento + "-F4";
            }

            this.F4.BackColor = Color.Red;
        }

        private void F5_Click(object sender, EventArgs e)
        {

            if (asiento == "")
            {
                asiento = "F5";
            }
            else
            {
                asiento = asiento + "-F5";
            }

            this.F5.BackColor = Color.Red;
        }

        private void F6_Click(object sender, EventArgs e)
        {

            if (asiento == "")
            {
                asiento = "F6";
            }
            else
            {
                asiento = asiento + "-F6";
            }

            this.F6.BackColor = Color.Red;
        }

        private void F7_Click(object sender, EventArgs e)
        {

            if (asiento == "")
            {
                asiento = "F7";
            }
            else
            {
                asiento = asiento + "-F7";
            }

            this.F7.BackColor = Color.Red;
        }

        private void F8_Click(object sender, EventArgs e)
        {

            if (asiento == "")
            {
                asiento = "F8";
            }
            else
            {
                asiento = asiento + "-F8";
            }

            this.F8.BackColor = Color.Red;
        }

        private void F9_Click(object sender, EventArgs e)
        {

            if (asiento == "")
            {
                asiento = "F9";
            }
            else
            {
                asiento = asiento + "-F9";
            }

            this.F9.BackColor = Color.Red;
        }

        private void F10_Click(object sender, EventArgs e)
        {

            if (asiento == "")
            {
                asiento = "F10";
            }
            else
            {
                asiento = asiento + "-F10";
            }

            this.F10.BackColor = Color.Red;
        }

        private void F11_Click(object sender, EventArgs e)
        {

            if (asiento == "")
            {
                asiento = "F11";
            }
            else
            {
                asiento = asiento + "-F11";
            }

            this.F11.BackColor = Color.Red;
        }

        private void F12_Click(object sender, EventArgs e)
        {

            if (asiento == "")
            {
                asiento = "F12";
            }
            else
            {
                asiento = asiento + "-F12";
            }

            this.F12.BackColor = Color.Red;
        }

        private void F13_Click(object sender, EventArgs e)
        {

            if (asiento == "")
            {
                asiento = "F13";
            }
            else
            {
                asiento = asiento + "-F13";
            }

            this.F13.BackColor = Color.Red;
        }

        private void F14_Click(object sender, EventArgs e)
        {

            if (asiento == "")
            {
                asiento = "F14";
            }
            else
            {
                asiento = asiento + "-F14";
            }

            this.F14.BackColor = Color.Red;
        }

        private void F15_Click(object sender, EventArgs e)
        {

            if (asiento == "")
            {
                asiento = "F15";
            }
            else
            {
                asiento = asiento + "-F15";
            }

            this.F15.BackColor = Color.Red;
        }

        private void F16_Click(object sender, EventArgs e)
        {

            if (asiento == "")
            {
                asiento = "F16";
            }
            else
            {
                asiento = asiento + "-F16";
            }

            this.F16.BackColor = Color.Red;
        }

        private void F17_Click(object sender, EventArgs e)
        {

            if (asiento == "")
            {
                asiento = "F17";
            }
            else
            {
                asiento = asiento + "-F17";
            }

            this.F17.BackColor = Color.Red;
        }

        private void F18_Click(object sender, EventArgs e)
        {

            if (asiento == "")
            {
                asiento = "F18";
            }
            else
            {
                asiento = asiento + "-F18";
            }

            this.F18.BackColor = Color.Red;
        }

        private void F19_Click(object sender, EventArgs e)
        {

            if (asiento == "")
            {
                asiento = "F19";
            }
            else
            {
                asiento = asiento + "-F19";
            }

            this.F19.BackColor = Color.Red;
        }

        private void F20_Click(object sender, EventArgs e)
        {

            if (asiento == "")
            {
                asiento = "F20";
            }
            else
            {
                asiento = asiento + "-F20";
            }

            this.F20.BackColor = Color.Red;
        }

        private void F21_Click(object sender, EventArgs e)
        {
            if (asiento == "")
            {
                asiento = "F21";
            }
            else
            {
                asiento = asiento + "-F21";
            }

            this.F21.BackColor = Color.Red;
        }

        private void F22_Click(object sender, EventArgs e)
        {
            if (asiento == "")
            {
                asiento = "F22";
            }
            else
            {
                asiento = asiento + "-F22";
            }

            this.F22.BackColor = Color.Red;
        }

        private void F23_Click(object sender, EventArgs e)
        {
            if (asiento == "")
            {
                asiento = "F23";
            }
            else
            {
                asiento = asiento + "-F23";
            }

            this.F23.BackColor = Color.Red;
        }

        private void F24_Click(object sender, EventArgs e)
        {
            if (asiento == "")
            {
                asiento = "F24";
            }
            else
            {
                asiento = asiento + "-F24";
            }

            this.F24.BackColor = Color.Red;
        }

        private void F25_Click(object sender, EventArgs e)
        {
            if (asiento == "")
            {
                asiento = "F25";
            }
            else
            {
                asiento = asiento + "-F25";
            }

            this.F25.BackColor = Color.Red;
        }

        private void F26_Click(object sender, EventArgs e)
        {
            if (asiento == "")
            {
                asiento = "F26";
            }
            else
            {
                asiento = asiento + "-F26";
            }

            this.F26.BackColor = Color.Red;
        }

        private void F27_Click(object sender, EventArgs e)
        {
            if (asiento == "")
            {
                asiento = "F27";
            }
            else
            {
                asiento = asiento + "-F27";
            }

            this.F27.BackColor = Color.Red;
        }

        private void F28_Click(object sender, EventArgs e)
        {
            if (asiento == "")
            {
                asiento = "F28";
            }
            else
            {
                asiento = asiento + "-F28";
            }

            this.F28.BackColor = Color.Red;
        }

        private void G1_Click(object sender, EventArgs e)
        {
            if (asiento == "")
            {
                asiento = "G1";
            }
            else
            {
                asiento = asiento + "-G1";
            }

            this.G1.BackColor = Color.Red;
        }

        private void G2_Click(object sender, EventArgs e)
        {

            if (asiento == "")
            {
                asiento = "G2";
            }
            else
            {
                asiento = asiento + "-G2";
            }

            this.G2.BackColor = Color.Red;
        }

        private void G3_Click(object sender, EventArgs e)
        {

            if (asiento == "")
            {
                asiento = "G3";
            }
            else
            {
                asiento = asiento + "-G3";
            }

            this.G3.BackColor = Color.Red;
        }

        private void G4_Click(object sender, EventArgs e)
        {

            if (asiento == "")
            {
                asiento = "G4";
            }
            else
            {
                asiento = asiento + "-G4";
            }

            this.G4.BackColor = Color.Red;
        }

        private void G5_Click(object sender, EventArgs e)
        {

            if (asiento == "")
            {
                asiento = "G5";
            }
            else
            {
                asiento = asiento + "-G5";
            }

            this.G5.BackColor = Color.Red;
        }

        private void G6_Click(object sender, EventArgs e)
        {

            if (asiento == "")
            {
                asiento = "G6";
            }
            else
            {
                asiento = asiento + "-G6";
            }

            this.G6.BackColor = Color.Red;
        }

        private void G7_Click(object sender, EventArgs e)
        {

            if (asiento == "")
            {
                asiento = "G7";
            }
            else
            {
                asiento = asiento + "-G7";
            }

            this.G7.BackColor = Color.Red;
        }

        private void G8_Click(object sender, EventArgs e)
        {

            if (asiento == "")
            {
                asiento = "G8";
            }
            else
            {
                asiento = asiento + "-G8";
            }

            this.G8.BackColor = Color.Red;
        }

        private void G9_Click(object sender, EventArgs e)
        {

            if (asiento == "")
            {
                asiento = "G9";
            }
            else
            {
                asiento = asiento + "-G9";
            }

            this.G9.BackColor = Color.Red;
        }

        private void G10_Click(object sender, EventArgs e)
        {

            if (asiento == "")
            {
                asiento = "G10";
            }
            else
            {
                asiento = asiento + "-G10";
            }

            this.G10.BackColor = Color.Red;
        }

        private void G11_Click(object sender, EventArgs e)
        {

            if (asiento == "")
            {
                asiento = "G11";
            }
            else
            {
                asiento = asiento + "-G11";
            }

            this.G11.BackColor = Color.Red;
        }

        private void G12_Click(object sender, EventArgs e)
        {

            if (asiento == "")
            {
                asiento = "G12";
            }
            else
            {
                asiento = asiento + "-G12";
            }

            this.G12.BackColor = Color.Red;
        }

        private void G13_Click(object sender, EventArgs e)
        {

            if (asiento == "")
            {
                asiento = "G13";
            }
            else
            {
                asiento = asiento + "-G13";
            }

            this.G13.BackColor = Color.Red;
        }

        private void G14_Click(object sender, EventArgs e)
        {

            if (asiento == "")
            {
                asiento = "G14";
            }
            else
            {
                asiento = asiento + "-G14";
            }

            this.G14.BackColor = Color.Red;
        }

        private void G15_Click(object sender, EventArgs e)
        {

            if (asiento == "")
            {
                asiento = "G15";
            }
            else
            {
                asiento = asiento + "-G15";
            }

            this.G15.BackColor = Color.Red;
        }

        private void G16_Click(object sender, EventArgs e)
        {

            if (asiento == "")
            {
                asiento = "G16";
            }
            else
            {
                asiento = asiento + "-G16";
            }

            this.G16.BackColor = Color.Red;
        }

        private void G17_Click(object sender, EventArgs e)
        {

            if (asiento == "")
            {
                asiento = "G17";
            }
            else
            {
                asiento = asiento + "-G17";
            }

            this.G17.BackColor = Color.Red;
        }

        private void G18_Click(object sender, EventArgs e)
        {

            if (asiento == "")
            {
                asiento = "G18";
            }
            else
            {
                asiento = asiento + "-G18";
            }

            this.G18.BackColor = Color.Red;
        }

        private void G19_Click(object sender, EventArgs e)
        {

            if (asiento == "")
            {
                asiento = "G19";
            }
            else
            {
                asiento = asiento + "-G19";
            }

            this.G19.BackColor = Color.Red;
        }

        private void G20_Click(object sender, EventArgs e)
        {

            if (asiento == "")
            {
                asiento = "G20";
            }
            else
            {
                asiento = asiento + "-G20";
            }

            this.G20.BackColor = Color.Red;
        }

        private void G21_Click(object sender, EventArgs e)
        {
            if (asiento == "")
            {
                asiento = "G21";
            }
            else
            {
                asiento = asiento + "-G21";
            }

            this.G21.BackColor = Color.Red;
        }

        private void G22_Click(object sender, EventArgs e)
        {
            if (asiento == "")
            {
                asiento = "G22";
            }
            else
            {
                asiento = asiento + "-G22";
            }

            this.G22.BackColor = Color.Red;
        }

        private void G23_Click(object sender, EventArgs e)
        {
            if (asiento == "")
            {
                asiento = "G23";
            }
            else
            {
                asiento = asiento + "-G23";
            }

            this.G23.BackColor = Color.Red;
        }

        private void G24_Click(object sender, EventArgs e)
        {
            if (asiento == "")
            {
                asiento = "G24";
            }
            else
            {
                asiento = asiento + "-G24";
            }

            this.G24.BackColor = Color.Red;
        }

        private void G25_Click(object sender, EventArgs e)
        {
            if (asiento == "")
            {
                asiento = "G25";
            }
            else
            {
                asiento = asiento + "-G25";
            }

            this.G25.BackColor = Color.Red;
        }

        private void G26_Click(object sender, EventArgs e)
        {
            if (asiento == "")
            {
                asiento = "G26";
            }
            else
            {
                asiento = asiento + "-G26";
            }

            this.G26.BackColor = Color.Red;
        }

        private void G27_Click(object sender, EventArgs e)
        {
            if (asiento == "")
            {
                asiento = "G27";
            }
            else
            {
                asiento = asiento + "-G27";
            }

            this.G27.BackColor = Color.Red;
        }

        private void G28_Click(object sender, EventArgs e)
        {
            if (asiento == "")
            {
                asiento = "G28";
            }
            else
            {
                asiento = asiento + "-G28";
            }

            this.G28.BackColor = Color.Red;
        }

        private void H1_Click(object sender, EventArgs e)
        {
            if (asiento == "")
            {
                asiento = "H1";
            }
            else
            {
                asiento = asiento + "-H1";
            }

            this.H1.BackColor = Color.Red;
        }

        private void H2_Click(object sender, EventArgs e)
        {
            if (asiento == "")
            {
                asiento = "H2";
            }
            else
            {
                asiento = asiento + "-H2";
            }

            this.H2.BackColor = Color.Red;
        }

        private void H3_Click(object sender, EventArgs e)
        {
            if (asiento == "")
            {
                asiento = "H3";
            }
            else
            {
                asiento = asiento + "-H3";
            }

            this.H3.BackColor = Color.Red;
        }

        private void H4_Click(object sender, EventArgs e)
        {
            if (asiento == "")
            {
                asiento = "H4";
            }
            else
            {
                asiento = asiento + "-H4";
            }

            this.H4.BackColor = Color.Red;
        }

        private void H5_Click(object sender, EventArgs e)
        {
            if (asiento == "")
            {
                asiento = "H5";
            }
            else
            {
                asiento = asiento + "-H5";
            }

            this.H5.BackColor = Color.Red;
        }

        private void H6_Click(object sender, EventArgs e)
        {
            if (asiento == "")
            {
                asiento = "H6";
            }
            else
            {
                asiento = asiento + "-H6";
            }

            this.H6.BackColor = Color.Red;
        }

        private void H7_Click(object sender, EventArgs e)
        {
            if (asiento == "")
            {
                asiento = "H7";
            }
            else
            {
                asiento = asiento + "-H7";
            }

            this.H7.BackColor = Color.Red;
        }

        private void H8_Click(object sender, EventArgs e)
        {
            if (asiento == "")
            {
                asiento = "H8";
            }
            else
            {
                asiento = asiento + "-H8";
            }

            this.H8.BackColor = Color.Red;
        }

        private void H9_Click(object sender, EventArgs e)
        {
            if (asiento == "")
            {
                asiento = "H9";
            }
            else
            {
                asiento = asiento + "-H9";
            }

            this.H9.BackColor = Color.Red;
        }

        private void H10_Click(object sender, EventArgs e)
        {
            if (asiento == "")
            {
                asiento = "H10";
            }
            else
            {
                asiento = asiento + "-H10";
            }

            this.H10.BackColor = Color.Red;
        }

        private void H11_Click(object sender, EventArgs e)
        {
            if (asiento == "")
            {
                asiento = "H11";
            }
            else
            {
                asiento = asiento + "-H11";
            }

            this.H11.BackColor = Color.Red;
        }

        private void H12_Click(object sender, EventArgs e)
        {
            if (asiento == "")
            {
                asiento = "H12";
            }
            else
            {
                asiento = asiento + "-H12";
            }

            this.H12.BackColor = Color.Red;
        }

        private void H13_Click(object sender, EventArgs e)
        {
            if (asiento == "")
            {
                asiento = "H13";
            }
            else
            {
                asiento = asiento + "-H13";
            }

            this.H13.BackColor = Color.Red;
        }

        private void H14_Click(object sender, EventArgs e)
        {
            if (asiento == "")
            {
                asiento = "H14";
            }
            else
            {
                asiento = asiento + "-H14";
            }

            this.H14.BackColor = Color.Red;
        }

        private void H15_Click(object sender, EventArgs e)
        {
            if (asiento == "")
            {
                asiento = "H15";
            }
            else
            {
                asiento = asiento + "-H15";
            }

            this.H15.BackColor = Color.Red;
        }

        private void H16_Click(object sender, EventArgs e)
        {
            if (asiento == "")
            {
                asiento = "H16";
            }
            else
            {
                asiento = asiento + "-H16";
            }

            this.H16.BackColor = Color.Red;
        }

        private void H17_Click(object sender, EventArgs e)
        {
            if (asiento == "")
            {
                asiento = "H17";
            }
            else
            {
                asiento = asiento + "-H17";
            }

            this.H17.BackColor = Color.Red;
        }

        private void H18_Click(object sender, EventArgs e)
        {
            if (asiento == "")
            {
                asiento = "H18";
            }
            else
            {
                asiento = asiento + "-H18";
            }

            this.H18.BackColor = Color.Red;
        }

        private void H19_Click(object sender, EventArgs e)
        {
            if (asiento == "")
            {
                asiento = "H19";
            }
            else
            {
                asiento = asiento + "-H19";
            }

            this.H19.BackColor = Color.Red;
        }

        private void H20_Click(object sender, EventArgs e)
        {
            if (asiento == "")
            {
                asiento = "H20";
            }
            else
            {
                asiento = asiento + "-H20";
            }

            this.H20.BackColor = Color.Red;
        }

        private void H21_Click(object sender, EventArgs e)
        {
            if (asiento == "")
            {
                asiento = "H21";
            }
            else
            {
                asiento = asiento + "-H21";
            }

            this.H21.BackColor = Color.Red;
        }

        private void H22_Click(object sender, EventArgs e)
        {
            if (asiento == "")
            {
                asiento = "H22";
            }
            else
            {
                asiento = asiento + "-H22";
            }

            this.H22.BackColor = Color.Red;
        }

        private void H23_Click(object sender, EventArgs e)
        {
            if (asiento == "")
            {
                asiento = "H23";
            }
            else
            {
                asiento = asiento + "-H23";
            }

            this.H23.BackColor = Color.Red;
        }

        private void H24_Click(object sender, EventArgs e)
        {
            if (asiento == "")
            {
                asiento = "H24";
            }
            else
            {
                asiento = asiento + "-H24";
            }

            this.H24.BackColor = Color.Red;
        }

        private void H25_Click(object sender, EventArgs e)
        {
            if (asiento == "")
            {
                asiento = "H25";
            }
            else
            {
                asiento = asiento + "-H25";
            }

            this.H25.BackColor = Color.Red;
        }

        private void H26_Click(object sender, EventArgs e)
        {
            if (asiento == "")
            {
                asiento = "H26";
            }
            else
            {
                asiento = asiento + "-H26";
            }

            this.H26.BackColor = Color.Red;
        }

        private void H27_Click(object sender, EventArgs e)
        {
            if (asiento == "")
            {
                asiento = "H27";
            }
            else
            {
                asiento = asiento + "-H27";
            }

            this.H27.BackColor = Color.Red;
        }

        private void H28_Click(object sender, EventArgs e)
        {
            if (asiento == "")
            {
                asiento = "H28";
            }
            else
            {
                asiento = asiento + "-H28";
            }

            this.H28.BackColor = Color.Red;
        }

        private void I1_Click(object sender, EventArgs e)
        {
            if (asiento == "")
            {
                asiento = "I1";
            }
            else
            {
                asiento = asiento + "-I1";
            }

            this.I1.BackColor = Color.Red;
        }

        private void I2_Click(object sender, EventArgs e)
        {
            if (asiento == "")
            {
                asiento = "I2";
            }
            else
            {
                asiento = asiento + "-I2";
            }

            this.I2.BackColor = Color.Red;
        }

        private void I3_Click(object sender, EventArgs e)
        {
            if (asiento == "")
            {
                asiento = "I3";
            }
            else
            {
                asiento = asiento + "-I3";
            }

            this.I3.BackColor = Color.Red;
        }

        private void I4_Click(object sender, EventArgs e)
        {
            if (asiento == "")
            {
                asiento = "I4";
            }
            else
            {
                asiento = asiento + "-I4";
            }

            this.I4.BackColor = Color.Red;
        }

        private void I5_Click(object sender, EventArgs e)
        {
            if (asiento == "")
            {
                asiento = "I5";
            }
            else
            {
                asiento = asiento + "-I5";
            }

            this.I5.BackColor = Color.Red;
        }

        private void I6_Click(object sender, EventArgs e)
        {
            if (asiento == "")
            {
                asiento = "I6";
            }
            else
            {
                asiento = asiento + "-I6";
            }

            this.I6.BackColor = Color.Red;
        }

        private void I7_Click(object sender, EventArgs e)
        {
            if (asiento == "")
            {
                asiento = "I7";
            }
            else
            {
                asiento = asiento + "-I7";
            }

            this.I7.BackColor = Color.Red;
        }

        private void I8_Click(object sender, EventArgs e)
        {
            if (asiento == "")
            {
                asiento = "I8";
            }
            else
            {
                asiento = asiento + "-I8";
            }

            this.I8.BackColor = Color.Red;
        }

        private void I9_Click(object sender, EventArgs e)
        {
            if (asiento == "")
            {
                asiento = "I9";
            }
            else
            {
                asiento = asiento + "-I9";
            }

            this.I9.BackColor = Color.Red;
        }

        private void I10_Click(object sender, EventArgs e)
        {
            if (asiento == "")
            {
                asiento = "I10";
            }
            else
            {
                asiento = asiento + "-I10";
            }

            this.I10.BackColor = Color.Red;
        }

        private void I11_Click(object sender, EventArgs e)
        {
            if (asiento == "")
            {
                asiento = "I11";
            }
            else
            {
                asiento = asiento + "-I11";
            }

            this.I11.BackColor = Color.Red;
        }

        private void I12_Click(object sender, EventArgs e)
        {
            if (asiento == "")
            {
                asiento = "I12";
            }
            else
            {
                asiento = asiento + "-I12";
            }

            this.I12.BackColor = Color.Red;
        }

        private void I13_Click(object sender, EventArgs e)
        {
            if (asiento == "")
            {
                asiento = "I13";
            }
            else
            {
                asiento = asiento + "-I13";
            }

            this.I13.BackColor = Color.Red;
        }

        private void I14_Click(object sender, EventArgs e)
        {
            if (asiento == "")
            {
                asiento = "I14";
            }
            else
            {
                asiento = asiento + "-I14";
            }

            this.I14.BackColor = Color.Red;
        }

        private void I15_Click(object sender, EventArgs e)
        {
            if (asiento == "")
            {
                asiento = "I15";
            }
            else
            {
                asiento = asiento + "-I15";
            }

            this.I15.BackColor = Color.Red;
        }

        private void I16_Click(object sender, EventArgs e)
        {
            if (asiento == "")
            {
                asiento = "I16";
            }
            else
            {
                asiento = asiento + "-I16";
            }

            this.I16.BackColor = Color.Red;
        }

        private void I17_Click(object sender, EventArgs e)
        {
            if (asiento == "")
            {
                asiento = "I17";
            }
            else
            {
                asiento = asiento + "-I17";
            }

            this.I17.BackColor = Color.Red;
        }

        private void I18_Click(object sender, EventArgs e)
        {
            if (asiento == "")
            {
                asiento = "I18";
            }
            else
            {
                asiento = asiento + "-I18";
            }

            this.I18.BackColor = Color.Red;
        }

        private void I19_Click(object sender, EventArgs e)
        {
            if (asiento == "")
            {
                asiento = "I19";
            }
            else
            {
                asiento = asiento + "-I19";
            }

            this.I19.BackColor = Color.Red;
        }

        private void I20_Click(object sender, EventArgs e)
        {
            if (asiento == "")
            {
                asiento = "I20";
            }
            else
            {
                asiento = asiento + "-I20";
            }

            this.I20.BackColor = Color.Red;
        }

        private void I21_Click(object sender, EventArgs e)
        {
            if (asiento == "")
            {
                asiento = "I21";
            }
            else
            {
                asiento = asiento + "-I21";
            }

            this.I21.BackColor = Color.Red;
        }

        private void I22_Click(object sender, EventArgs e)
        {
            if (asiento == "")
            {
                asiento = "I22";
            }
            else
            {
                asiento = asiento + "-I22";
            }

            this.I22.BackColor = Color.Red;
        }

        private void I23_Click(object sender, EventArgs e)
        {
            if (asiento == "")
            {
                asiento = "I23";
            }
            else
            {
                asiento = asiento + "-I23";
            }

            this.I23.BackColor = Color.Red;
        }

        private void I24_Click(object sender, EventArgs e)
        {
            if (asiento == "")
            {
                asiento = "I24";
            }
            else
            {
                asiento = asiento + "-I24";
            }

            this.I24.BackColor = Color.Red;
        }

        private void I25_Click(object sender, EventArgs e)
        {
            if (asiento == "")
            {
                asiento = "I25";
            }
            else
            {
                asiento = asiento + "-I25";
            }

            this.I25.BackColor = Color.Red;
        }

        private void I26_Click(object sender, EventArgs e)
        {
            if (asiento == "")
            {
                asiento = "I26";
            }
            else
            {
                asiento = asiento + "-I26";
            }

            this.I26.BackColor = Color.Red;
        }

        private void I27_Click(object sender, EventArgs e)
        {
            if (asiento == "")
            {
                asiento = "I27";
            }
            else
            {
                asiento = asiento + "-I27";
            }

            this.I27.BackColor = Color.Red;
        }

        private void I28_Click(object sender, EventArgs e)
        {
            if (asiento == "")
            {
                asiento = "I28";
            }
            else
            {
                asiento = asiento + "-I28";
            }

            this.I28.BackColor = Color.Red;
        }

        private void J1_Click(object sender, EventArgs e)
        {
            if (asiento == "")
            {
                asiento = "J1";
            }
            else
            {
                asiento = asiento + "-J1";
            }

            this.J1.BackColor = Color.Red;
        }

        private void J2_Click(object sender, EventArgs e)
        {
            if (asiento == "")
            {
                asiento = "J2";
            }
            else
            {
                asiento = asiento + "-J2";
            }

            this.J2.BackColor = Color.Red;
        }

        private void J3_Click(object sender, EventArgs e)
        {
            if (asiento == "")
            {
                asiento = "J3";
            }
            else
            {
                asiento = asiento + "-J3";
            }

            this.J3.BackColor = Color.Red;
        }

        private void J4_Click(object sender, EventArgs e)
        {
            if (asiento == "")
            {
                asiento = "J4";
            }
            else
            {
                asiento = asiento + "-J4";
            }

            this.J4.BackColor = Color.Red;
        }

        private void J5_Click(object sender, EventArgs e)
        {
            if (asiento == "")
            {
                asiento = "J5";
            }
            else
            {
                asiento = asiento + "-J5";
            }

            this.J5.BackColor = Color.Red;
        }

        private void J6_Click(object sender, EventArgs e)
        {
            if (asiento == "")
            {
                asiento = "J6";
            }
            else
            {
                asiento = asiento + "-J6";
            }

            this.J6.BackColor = Color.Red;
        }

        private void J7_Click(object sender, EventArgs e)
        {
            if (asiento == "")
            {
                asiento = "J7";
            }
            else
            {
                asiento = asiento + "-J7";
            }

            this.J7.BackColor = Color.Red;
        }

        private void J8_Click(object sender, EventArgs e)
        {
            if (asiento == "")
            {
                asiento = "J8";
            }
            else
            {
                asiento = asiento + "-J8";
            }

            this.J8.BackColor = Color.Red;
        }

        private void J9_Click(object sender, EventArgs e)
        {
            if (asiento == "")
            {
                asiento = "J9";
            }
            else
            {
                asiento = asiento + "-J9";
            }

            this.J9.BackColor = Color.Red;
        }

        private void J10_Click(object sender, EventArgs e)
        {
            if (asiento == "")
            {
                asiento = "J10";
            }
            else
            {
                asiento = asiento + "-J10";
            }

            this.J10.BackColor = Color.Red;
        }

        private void J11_Click(object sender, EventArgs e)
        {
            if (asiento == "")
            {
                asiento = "J11";
            }
            else
            {
                asiento = asiento + "-J11";
            }

            this.J11.BackColor = Color.Red;
        }

        private void J12_Click(object sender, EventArgs e)
        {
            if (asiento == "")
            {
                asiento = "J12";
            }
            else
            {
                asiento = asiento + "-J12";
            }

            this.J12.BackColor = Color.Red;
        }

        private void J13_Click(object sender, EventArgs e)
        {
            if (asiento == "")
            {
                asiento = "J13";
            }
            else
            {
                asiento = asiento + "-J13";
            }

            this.J13.BackColor = Color.Red;
        }

        private void J14_Click(object sender, EventArgs e)
        {
            if (asiento == "")
            {
                asiento = "J14";
            }
            else
            {
                asiento = asiento + "-J14";
            }

            this.J14.BackColor = Color.Red;
        }

        private void J15_Click(object sender, EventArgs e)
        {
            if (asiento == "")
            {
                asiento = "J15";
            }
            else
            {
                asiento = asiento + "-J15";
            }

            this.J15.BackColor = Color.Red;
        }

        private void J16_Click(object sender, EventArgs e)
        {
            if (asiento == "")
            {
                asiento = "J16";
            }
            else
            {
                asiento = asiento + "-J16";
            }

            this.J16.BackColor = Color.Red;
        }

        private void J17_Click(object sender, EventArgs e)
        {
            if (asiento == "")
            {
                asiento = "J17";
            }
            else
            {
                asiento = asiento + "-J17";
            }

            this.J17.BackColor = Color.Red;
        }

        private void J18_Click(object sender, EventArgs e)
        {
            if (asiento == "")
            {
                asiento = "J18";
            }
            else
            {
                asiento = asiento + "-J18";
            }

            this.J18.BackColor = Color.Red;
        }

        private void J19_Click(object sender, EventArgs e)
        {
            if (asiento == "")
            {
                asiento = "J19";
            }
            else
            {
                asiento = asiento + "-J19";
            }

            this.J19.BackColor = Color.Red;
        }

        private void J20_Click(object sender, EventArgs e)
        {
            if (asiento == "")
            {
                asiento = "J20";
            }
            else
            {
                asiento = asiento + "-J20";
            }

            this.J20.BackColor = Color.Red;
        }

        private void J21_Click(object sender, EventArgs e)
        {
            if (asiento == "")
            {
                asiento = "J21";
            }
            else
            {
                asiento = asiento + "-J21";
            }

            this.J21.BackColor = Color.Red;
        }

        private void J22_Click(object sender, EventArgs e)
        {
            if (asiento == "")
            {
                asiento = "J22";
            }
            else
            {
                asiento = asiento + "-J22";
            }

            this.J22.BackColor = Color.Red;
        }

        private void J23_Click(object sender, EventArgs e)
        {
            if (asiento == "")
            {
                asiento = "J23";
            }
            else
            {
                asiento = asiento + "-J23";
            }

            this.J23.BackColor = Color.Red;
        }

        private void J24_Click(object sender, EventArgs e)
        {
            if (asiento == "")
            {
                asiento = "J24";
            }
            else
            {
                asiento = asiento + "-J24";
            }

            this.J24.BackColor = Color.Red;
        }

        private void J25_Click(object sender, EventArgs e)
        {
            if (asiento == "")
            {
                asiento = "J25";
            }
            else
            {
                asiento = asiento + "-J25";
            }

            this.J25.BackColor = Color.Red;
        }

        private void J26_Click(object sender, EventArgs e)
        {
            if (asiento == "")
            {
                asiento = "J26";
            }
            else
            {
                asiento = asiento + "-J26";
            }

            this.J26.BackColor = Color.Red;
        }

        private void J27_Click(object sender, EventArgs e)
        {
            if (asiento == "")
            {
                asiento = "J27";
            }
            else
            {
                asiento = asiento + "-J27";
            }

            this.J27.BackColor = Color.Red;
        }

        private void J28_Click(object sender, EventArgs e)
        {
            if (asiento == "")
            {
                asiento = "J28";
            }
            else
            {
                asiento = asiento + "-J28";
            }

            this.J28.BackColor = Color.Red;
        }

        private void K1_Click(object sender, EventArgs e)
        {
            if (asiento == "")
            {
                asiento = "K1";
            }
            else
            {
                asiento = asiento + "-K1";
            }

            this.K1.BackColor = Color.Red;
        }

        private void K2_Click(object sender, EventArgs e)
        {
            if (asiento == "")
            {
                asiento = "K2";
            }
            else
            {
                asiento = asiento + "-K2";
            }

            this.K2.BackColor = Color.Red;
        }

        private void K3_Click(object sender, EventArgs e)
        {
            if (asiento == "")
            {
                asiento = "K3";
            }
            else
            {
                asiento = asiento + "-K3";
            }

            this.K3.BackColor = Color.Red;
        }

        private void K4_Click(object sender, EventArgs e)
        {
            if (asiento == "")
            {
                asiento = "K4";
            }
            else
            {
                asiento = asiento + "-K4";
            }

            this.K4.BackColor = Color.Red;
        }

        private void K5_Click(object sender, EventArgs e)
        {
            if (asiento == "")
            {
                asiento = "K5";
            }
            else
            {
                asiento = asiento + "-K5";
            }

            this.K5.BackColor = Color.Red;
        }

        private void K6_Click(object sender, EventArgs e)
        {
            if (asiento == "")
            {
                asiento = "K6";
            }
            else
            {
                asiento = asiento + "-K6";
            }

            this.K6.BackColor = Color.Red;
        }

        private void K7_Click(object sender, EventArgs e)
        {
            if (asiento == "")
            {
                asiento = "K7";
            }
            else
            {
                asiento = asiento + "-K7";
            }

            this.K7.BackColor = Color.Red;
        }

        private void K8_Click(object sender, EventArgs e)
        {
            if (asiento == "")
            {
                asiento = "K8";
            }
            else
            {
                asiento = asiento + "-K8";
            }

            this.K8.BackColor = Color.Red;
        }

        private void K9_Click(object sender, EventArgs e)
        {
            if (asiento == "")
            {
                asiento = "K9";
            }
            else
            {
                asiento = asiento + "-K9";
            }

            this.K9.BackColor = Color.Red;
        }

        private void K10_Click(object sender, EventArgs e)
        {
            if (asiento == "")
            {
                asiento = "K10";
            }
            else
            {
                asiento = asiento + "-K10";
            }

            this.K10.BackColor = Color.Red;
        }

        private void K11_Click(object sender, EventArgs e)
        {
            if (asiento == "")
            {
                asiento = "K11";
            }
            else
            {
                asiento = asiento + "-K11";
            }
            
            this.K11.BackColor = Color.Red;
        }

        private void K12_Click(object sender, EventArgs e)
        {
            if (asiento == "")
            {
                asiento = "K12";
            }
            else
            {
                asiento = asiento + "-K12";
            }

            this.K12.BackColor = Color.Red;
        }

        private void K13_Click(object sender, EventArgs e)
        {
            if (asiento == "")
            {
                asiento = "K13";
            }
            else
            {
                asiento = asiento + "-K13";
            }

            this.K13.BackColor = Color.Red;
        }

        private void K14_Click(object sender, EventArgs e)
        {
            if (asiento == "")
            {
                asiento = "K14";
            }
            else
            {
                asiento = asiento + "-K14";
            }

            this.K14.BackColor = Color.Red;
        }

        private void K15_Click(object sender, EventArgs e)
        {
            if (asiento == "")
            {
                asiento = "K15";
            }
            else
            {
                asiento = asiento + "-K15";
            }

            this.K15.BackColor = Color.Red;
        }

        private void K16_Click(object sender, EventArgs e)
        {
            if (asiento == "")
            {
                asiento = "K16";
            }
            else
            {
                asiento = asiento + "-K16";
            }

            this.K16.BackColor = Color.Red;
        }

        private void K17_Click(object sender, EventArgs e)
        {
            if (asiento == "")
            {
                asiento = "K17";
            }
            else
            {
                asiento = asiento + "-K17";
            }

            this.K17.BackColor = Color.Red;
        }

        private void K18_Click(object sender, EventArgs e)
        {
            if (asiento == "")
            {
                asiento = "K18";
            }
            else
            {
                asiento = asiento + "-K18";
            }

            this.K18.BackColor = Color.Red;
        }

        private void K19_Click(object sender, EventArgs e)
        {
            if (asiento == "")
            {
                asiento = "K19";
            }
            else
            {
                asiento = asiento + "-K19";
            }

            this.K19.BackColor = Color.Red;
        }

        private void K20_Click(object sender, EventArgs e)
        {
            if (asiento == "")
            {
                asiento = "K20";
            }
            else
            {
                asiento = asiento + "-K20";
            }

            this.K20.BackColor = Color.Red;
        }

        private void K21_Click(object sender, EventArgs e)
        {
            if (asiento == "")
            {
                asiento = "K21";
            }
            else
            {
                asiento = asiento + "-K21";
            }

            this.K21.BackColor = Color.Red;
        }

        private void K22_Click(object sender, EventArgs e)
        {
            if (asiento == "")
            {
                asiento = "K22";
            }
            else
            {
                asiento = asiento + "-K22";
            }

            this.K22.BackColor = Color.Red;
        }

        private void K23_Click(object sender, EventArgs e)
        {
            if (asiento == "")
            {
                asiento = "K23";
            }
            else
            {
                asiento = asiento + "-K23";
            }

            this.K23.BackColor = Color.Red;
        }

        private void K24_Click(object sender, EventArgs e)
        {
            if (asiento == "")
            {
                asiento = "K24";
            }
            else
            {
                asiento = asiento + "-K24";
            }

            this.K24.BackColor = Color.Red;
        }

        private void K25_Click(object sender, EventArgs e)
        {
            if (asiento == "")
            {
                asiento = "K25";
            }
            else
            {
                asiento = asiento + "-K25";
            }

            this.K25.BackColor = Color.Red;
        }

        private void K26_Click(object sender, EventArgs e)
        {
            if (asiento == "")
            {
                asiento = "K26";
            }
            else
            {
                asiento = asiento + "-K26";
            }

            this.K26.BackColor = Color.Red;
        }

        private void K27_Click(object sender, EventArgs e)
        {
            if (asiento == "")
            {
                asiento = "K27";
            }
            else
            {
                asiento = asiento + "-K27";
            }

            this.K27.BackColor = Color.Red;
        }

        private void K28_Click(object sender, EventArgs e)
        {
            if (asiento == "")
            {
                asiento = "K28";
            }
            else
            {
                asiento = asiento + "-K28";
            }

            this.K28.BackColor = Color.Red;
        }

        private void L1_Click(object sender, EventArgs e)
        {
            if (asiento == "")
            {
                asiento = "L1";
            }
            else
            {
                asiento = asiento + "-L1";
            }

            this.L1.BackColor = Color.Red;
        }

        private void L2_Click(object sender, EventArgs e)
        {
            if (asiento == "")
            {
                asiento = "L2";
            }
            else
            {
                asiento = asiento + "-L2";
            }

            this.L2.BackColor = Color.Red;
        }

        private void L3_Click(object sender, EventArgs e)
        {
            if (asiento == "")
            {
                asiento = "L3";
            }
            else
            {
                asiento = asiento + "-L3";
            }

            this.L3.BackColor = Color.Red;
        }

        private void L4_Click(object sender, EventArgs e)
        {
            if (asiento == "")
            {
                asiento = "L4";
            }
            else
            {
                asiento = asiento + "-L4";
            }

            this.L4.BackColor = Color.Red;
        }

        private void L5_Click(object sender, EventArgs e)
        {
            if (asiento == "")
            {
                asiento = "L5";
            }
            else
            {
                asiento = asiento + "-L5";
            }

            this.L5.BackColor = Color.Red;
        }

        private void L6_Click(object sender, EventArgs e)
        {
            if (asiento == "")
            {
                asiento = "L6";
            }
            else
            {
                asiento = asiento + "-L6";
            }

            this.L6.BackColor = Color.Red;
        }

        private void L7_Click(object sender, EventArgs e)
        {
            if (asiento == "")
            {
                asiento = "L7";
            }
            else
            {
                asiento = asiento + "-L7";
            }

            this.L7.BackColor = Color.Red;
        }

        private void L8_Click(object sender, EventArgs e)
        {
            if (asiento == "")
            {
                asiento = "L8";
            }
            else
            {
                asiento = asiento + "-L8";
            }

            this.L8.BackColor = Color.Red;
        }

        private void L9_Click(object sender, EventArgs e)
        {
            if (asiento == "")
            {
                asiento = "L9";
            }
            else
            {
                asiento = asiento + "-L9";
            }

            this.L9.BackColor = Color.Red;
        }

        private void L10_Click(object sender, EventArgs e)
        {
            if (asiento == "")
            {
                asiento = "L10";
            }
            else
            {
                asiento = asiento + "-L10";
            }

            this.L10.BackColor = Color.Red;
        }

        private void L11_Click(object sender, EventArgs e)
        {
            if (asiento == "")
            {
                asiento = "L11";
            }
            else
            {
                asiento = asiento + "-L11";
            }

            this.L11.BackColor = Color.Red;
        }

        private void L12_Click(object sender, EventArgs e)
        {
            if (asiento == "")
            {
                asiento = "L12";
            }
            else
            {
                asiento = asiento + "-L12";
            }

            this.L12.BackColor = Color.Red;
        }

        private void L13_Click(object sender, EventArgs e)
        {
            if (asiento == "")
            {
                asiento = "L13";
            }
            else
            {
                asiento = asiento + "-L13";
            }

            this.L13.BackColor = Color.Red;
        }

        private void L14_Click(object sender, EventArgs e)
        {
            if (asiento == "")
            {
                asiento = "L14";
            }
            else
            {
                asiento = asiento + "-L14";
            }

            this.L14.BackColor = Color.Red;
        }

        private void L15_Click(object sender, EventArgs e)
        {
            if (asiento == "")
            {
                asiento = "L15";
            }
            else
            {
                asiento = asiento + "-L15";
            }

            this.L15.BackColor = Color.Red;
        }

        private void L16_Click(object sender, EventArgs e)
        {
            if (asiento == "")
            {
                asiento = "L16";
            }
            else
            {
                asiento = asiento + "-L16";
            }

            this.L16.BackColor = Color.Red;
        }

        private void L17_Click(object sender, EventArgs e)
        {
            if (asiento == "")
            {
                asiento = "L17";
            }
            else
            {
                asiento = asiento + "-L17";
            }

            this.L17.BackColor = Color.Red;
        }

        private void L18_Click(object sender, EventArgs e)
        {
            if (asiento == "")
            {
                asiento = "L18";
            }
            else
            {
                asiento = asiento + "-L18";
            }

            this.L18.BackColor = Color.Red;
        }

        private void L19_Click(object sender, EventArgs e)
        {
            if (asiento == "")
            {
                asiento = "L19";
            }
            else
            {
                asiento = asiento + "-L19";
            }

            this.L19.BackColor = Color.Red;
        }

        private void L20_Click(object sender, EventArgs e)
        {
            if (asiento == "")
            {
                asiento = "L20";
            }
            else
            {
                asiento = asiento + "-L20";
            }

            this.L20.BackColor = Color.Red;
        }

        private void L21_Click(object sender, EventArgs e)
        {
            if (asiento == "")
            {
                asiento = "L21";
            }
            else
            {
                asiento = asiento + "-L21";
            }

            this.L21.BackColor = Color.Red;
        }

        private void L22_Click(object sender, EventArgs e)
        {
            if (asiento == "")
            {
                asiento = "L22";
            }
            else
            {
                asiento = asiento + "-L22";
            }

            this.L22.BackColor = Color.Red;
        }

        private void L23_Click(object sender, EventArgs e)
        {
            if (asiento == "")
            {
                asiento = "L23";
            }
            else
            {
                asiento = asiento + "-L23";
            }

            this.L23.BackColor = Color.Red;
        }

        private void L24_Click(object sender, EventArgs e)
        {
            if (asiento == "")
            {
                asiento = "L24";
            }
            else
            {
                asiento = asiento + "-L24";
            }

            this.L24.BackColor = Color.Red;
        }

        private void L25_Click(object sender, EventArgs e)
        {
            if (asiento == "")
            {
                asiento = "L25";
            }
            else
            {
                asiento = asiento + "-L25";
            }

            this.L25.BackColor = Color.Red;
        }

        private void L26_Click(object sender, EventArgs e)
        {
            if (asiento == "")
            {
                asiento = "L26";
            }
            else
            {
                asiento = asiento + "-L26";
            }

            this.L26.BackColor = Color.Red;
        }

        private void L27_Click(object sender, EventArgs e)
        {
            if (asiento == "")
            {
                asiento = "L27";
            }
            else
            {
                asiento = asiento + "-L27";
            }

            this.L27.BackColor = Color.Red;
        }

        private void L28_Click(object sender, EventArgs e)
        {
            if (asiento == "")
            {
                asiento = "L28";
            }
            else
            {
                asiento = asiento + "-L28";
            }

            this.L28.BackColor = Color.Red;
        }

        private void L29_Click(object sender, EventArgs e)
        {
            if (asiento == "")
            {
                asiento = "L29";
            }
            else
            {
                asiento = asiento + "-L29";
            }

            this.L29.BackColor = Color.Red;
        }

        private void L30_Click(object sender, EventArgs e)
        {
            if (asiento == "")
            {
                asiento = "L30";
            }
            else
            {
                asiento = asiento + "-L30";
            }

            this.L30.BackColor = Color.Red;
        }

        private void L31_Click(object sender, EventArgs e)
        {
            if (asiento == "")
            {
                asiento = "L32";
            }
            else
            {
                asiento = asiento + "-L31";
            }

            this.L31.BackColor = Color.Red;
        }

        private void L32_Click(object sender, EventArgs e)
        {
            if (asiento == "")
            {
                asiento = "L32";
            }
            else
            {
                asiento = asiento + "-L32";
            }

            this.L32.BackColor = Color.Red;
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            Facturacion.asientoss = asiento;
            fac.Visible = true;
            this.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            A1.BackColor = SystemColors.Control;
            A2.BackColor = SystemColors.Control;
            A3.BackColor = SystemColors.Control;
            A4.BackColor = SystemColors.Control;
            A5.BackColor = SystemColors.Control;
            A6.BackColor = SystemColors.Control;
            A7.BackColor = SystemColors.Control;
            A8.BackColor = SystemColors.Control;
            A9.BackColor = SystemColors.Control;
            A10.BackColor = SystemColors.Control;
            A11.BackColor = SystemColors.Control;
            A12.BackColor = SystemColors.Control;
            A13.BackColor = SystemColors.Control;
            A14.BackColor = SystemColors.Control;
            A15.BackColor = SystemColors.Control;
            A16.BackColor = SystemColors.Control;
            A17.BackColor = SystemColors.Control;
            B1.BackColor = SystemColors.Control;
            B2.BackColor = SystemColors.Control;
            B3.BackColor = SystemColors.Control;
            B4.BackColor = SystemColors.Control;
            B5.BackColor = SystemColors.Control;
            B6.BackColor = SystemColors.Control;
            B7.BackColor = SystemColors.Control;
            B8.BackColor = SystemColors.Control;
            B9.BackColor = SystemColors.Control;
            B10.BackColor = SystemColors.Control;
            B11.BackColor = SystemColors.Control;
            B12.BackColor = SystemColors.Control;
            B13.BackColor = SystemColors.Control;
            B14.BackColor = SystemColors.Control;
            B15.BackColor = SystemColors.Control;
            B16.BackColor = SystemColors.Control;
            B17.BackColor = SystemColors.Control;
            B18.BackColor = SystemColors.Control;
            B19.BackColor = SystemColors.Control;
            B20.BackColor = SystemColors.Control;
            B21.BackColor = SystemColors.Control;
            B22.BackColor = SystemColors.Control;
            B23.BackColor = SystemColors.Control;
            B24.BackColor = SystemColors.Control;
            C1.BackColor = SystemColors.Control;
            C2.BackColor = SystemColors.Control;
            C3.BackColor = SystemColors.Control;
            C4.BackColor = SystemColors.Control;
            C5.BackColor = SystemColors.Control;
            C6.BackColor = SystemColors.Control;
            C7.BackColor = SystemColors.Control;
            C8.BackColor = SystemColors.Control;
            C9.BackColor = SystemColors.Control;
            C10.BackColor = SystemColors.Control;
            C11.BackColor = SystemColors.Control;
            C12.BackColor = SystemColors.Control;
            C13.BackColor = SystemColors.Control;
            C14.BackColor = SystemColors.Control;
            C15.BackColor = SystemColors.Control;
            C16.BackColor = SystemColors.Control;
            C17.BackColor = SystemColors.Control;
            C18.BackColor = SystemColors.Control;
            C19.BackColor = SystemColors.Control;
            C20.BackColor = SystemColors.Control;
            C21.BackColor = SystemColors.Control;
            C22.BackColor = SystemColors.Control;
            C23.BackColor = SystemColors.Control;
            C24.BackColor = SystemColors.Control;
            D1.BackColor = SystemColors.Control;
            D2.BackColor = SystemColors.Control;
            D3.BackColor = SystemColors.Control;
            D4.BackColor = SystemColors.Control;
            D5.BackColor = SystemColors.Control;
            D6.BackColor = SystemColors.Control;
            D7.BackColor = SystemColors.Control;
            D8.BackColor = SystemColors.Control;
            D9.BackColor = SystemColors.Control;
            D10.BackColor = SystemColors.Control;
            D11.BackColor = SystemColors.Control;
            D12.BackColor = SystemColors.Control;
            D13.BackColor = SystemColors.Control;
            D14.BackColor = SystemColors.Control;
            D15.BackColor = SystemColors.Control;
            D16.BackColor = SystemColors.Control;
            D17.BackColor = SystemColors.Control;
            D18.BackColor = SystemColors.Control;
            D19.BackColor = SystemColors.Control;
            D20.BackColor = SystemColors.Control;
            D21.BackColor = SystemColors.Control;
            D22.BackColor = SystemColors.Control;
            D23.BackColor = SystemColors.Control;
            D24.BackColor = SystemColors.Control;
            D25.BackColor = SystemColors.Control;
            D26.BackColor = SystemColors.Control;
            D27.BackColor = SystemColors.Control;
            D28.BackColor = SystemColors.Control;
            E1.BackColor = SystemColors.Control;
            E2.BackColor = SystemColors.Control;
            E3.BackColor = SystemColors.Control;
            E4.BackColor = SystemColors.Control;
            E5.BackColor = SystemColors.Control;
            E6.BackColor = SystemColors.Control;
            E7.BackColor = SystemColors.Control;
            E8.BackColor = SystemColors.Control;
            E9.BackColor = SystemColors.Control;
            E10.BackColor = SystemColors.Control;
            E11.BackColor = SystemColors.Control;
            E12.BackColor = SystemColors.Control;
            E13.BackColor = SystemColors.Control;
            E14.BackColor = SystemColors.Control;
            E15.BackColor = SystemColors.Control;
            E16.BackColor = SystemColors.Control;
            E17.BackColor = SystemColors.Control;
            E18.BackColor = SystemColors.Control;
            E19.BackColor = SystemColors.Control;
            E20.BackColor = SystemColors.Control;
            E21.BackColor = SystemColors.Control;
            E22.BackColor = SystemColors.Control;
            E23.BackColor = SystemColors.Control;
            E24.BackColor = SystemColors.Control;
            E25.BackColor = SystemColors.Control;
            E26.BackColor = SystemColors.Control;
            E27.BackColor = SystemColors.Control;
            E28.BackColor = SystemColors.Control;
            F1.BackColor = SystemColors.Control;
            F2.BackColor = SystemColors.Control;
            F3.BackColor = SystemColors.Control;
            F4.BackColor = SystemColors.Control;
            F5.BackColor = SystemColors.Control;
            F6.BackColor = SystemColors.Control;
            F7.BackColor = SystemColors.Control;
            F8.BackColor = SystemColors.Control;
            F9.BackColor = SystemColors.Control;
            F10.BackColor = SystemColors.Control;
            F11.BackColor = SystemColors.Control;
            F12.BackColor = SystemColors.Control;
            F13.BackColor = SystemColors.Control;
            F14.BackColor = SystemColors.Control;
            F15.BackColor = SystemColors.Control;
            F16.BackColor = SystemColors.Control;
            F17.BackColor = SystemColors.Control;
            F18.BackColor = SystemColors.Control;
            F19.BackColor = SystemColors.Control;
            F20.BackColor = SystemColors.Control;
            F21.BackColor = SystemColors.Control;
            F22.BackColor = SystemColors.Control;
            F23.BackColor = SystemColors.Control;
            F24.BackColor = SystemColors.Control;
            F25.BackColor = SystemColors.Control;
            F26.BackColor = SystemColors.Control;
            F27.BackColor = SystemColors.Control;
            F28.BackColor = SystemColors.Control;
            G1.BackColor = SystemColors.Control;
            G2.BackColor = SystemColors.Control;
            G3.BackColor = SystemColors.Control;
            G4.BackColor = SystemColors.Control;
            G5.BackColor = SystemColors.Control;
            G6.BackColor = SystemColors.Control;
            G7.BackColor = SystemColors.Control;
            G8.BackColor = SystemColors.Control;
            G9.BackColor = SystemColors.Control;
            G10.BackColor = SystemColors.Control;
            G11.BackColor = SystemColors.Control;
            G12.BackColor = SystemColors.Control;
            G13.BackColor = SystemColors.Control;
            G14.BackColor = SystemColors.Control;
            G15.BackColor = SystemColors.Control;
            G16.BackColor = SystemColors.Control;
            G17.BackColor = SystemColors.Control;
            G18.BackColor = SystemColors.Control;
            G19.BackColor = SystemColors.Control;
            G20.BackColor = SystemColors.Control;
            G21.BackColor = SystemColors.Control;
            G22.BackColor = SystemColors.Control;
            G23.BackColor = SystemColors.Control;
            G24.BackColor = SystemColors.Control;
            G25.BackColor = SystemColors.Control;
            G26.BackColor = SystemColors.Control;
            G27.BackColor = SystemColors.Control;
            G28.BackColor = SystemColors.Control;
            H1.BackColor = SystemColors.Control;
            H2.BackColor = SystemColors.Control;
            H3.BackColor = SystemColors.Control;
            H4.BackColor = SystemColors.Control;
            H5.BackColor = SystemColors.Control;
            H6.BackColor = SystemColors.Control;
            H7.BackColor = SystemColors.Control;
            H8.BackColor = SystemColors.Control;
            H9.BackColor = SystemColors.Control;
            H10.BackColor = SystemColors.Control;
            H11.BackColor = SystemColors.Control;
            H12.BackColor = SystemColors.Control;
            H13.BackColor = SystemColors.Control;
            H14.BackColor = SystemColors.Control;
            H15.BackColor = SystemColors.Control;
            H16.BackColor = SystemColors.Control;
            H17.BackColor = SystemColors.Control;
            H18.BackColor = SystemColors.Control;
            H19.BackColor = SystemColors.Control;
            H20.BackColor = SystemColors.Control;
            H21.BackColor = SystemColors.Control;
            H22.BackColor = SystemColors.Control;
            H23.BackColor = SystemColors.Control;
            H24.BackColor = SystemColors.Control;
            H25.BackColor = SystemColors.Control;
            H26.BackColor = SystemColors.Control;
            H27.BackColor = SystemColors.Control;
            H28.BackColor = SystemColors.Control;
            I1.BackColor = SystemColors.Control;
            I2.BackColor = SystemColors.Control;
            I3.BackColor = SystemColors.Control;
            I4.BackColor = SystemColors.Control;
            I5.BackColor = SystemColors.Control;
            I6.BackColor = SystemColors.Control;
            I7.BackColor = SystemColors.Control;
            I8.BackColor = SystemColors.Control;
            I9.BackColor = SystemColors.Control;
            I10.BackColor = SystemColors.Control;
            I11.BackColor = SystemColors.Control;
            I12.BackColor = SystemColors.Control;
            I13.BackColor = SystemColors.Control;
            I14.BackColor = SystemColors.Control;
            I15.BackColor = SystemColors.Control;
            I16.BackColor = SystemColors.Control;
            I17.BackColor = SystemColors.Control;
            I18.BackColor = SystemColors.Control;
            I19.BackColor = SystemColors.Control;
            I20.BackColor = SystemColors.Control;
            I21.BackColor = SystemColors.Control;
            I22.BackColor = SystemColors.Control;
            I23.BackColor = SystemColors.Control;
            I24.BackColor = SystemColors.Control;
            I25.BackColor = SystemColors.Control;
            I26.BackColor = SystemColors.Control;
            I27.BackColor = SystemColors.Control;
            I28.BackColor = SystemColors.Control;
            J1.BackColor = SystemColors.Control;
            J2.BackColor = SystemColors.Control;
            J3.BackColor = SystemColors.Control;
            J4.BackColor = SystemColors.Control;
            J5.BackColor = SystemColors.Control;
            J6.BackColor = SystemColors.Control;
            J7.BackColor = SystemColors.Control;
            J8.BackColor = SystemColors.Control;
            J9.BackColor = SystemColors.Control;
            J10.BackColor = SystemColors.Control;
            J11.BackColor = SystemColors.Control;
            J12.BackColor = SystemColors.Control;
            J13.BackColor = SystemColors.Control;
            J14.BackColor = SystemColors.Control;
            J15.BackColor = SystemColors.Control;
            J16.BackColor = SystemColors.Control;
            J17.BackColor = SystemColors.Control;
            J18.BackColor = SystemColors.Control;
            J19.BackColor = SystemColors.Control;
            J20.BackColor = SystemColors.Control;
            J21.BackColor = SystemColors.Control;
            J22.BackColor = SystemColors.Control;
            J23.BackColor = SystemColors.Control;
            J24.BackColor = SystemColors.Control;
            J25.BackColor = SystemColors.Control;
            J26.BackColor = SystemColors.Control;
            J27.BackColor = SystemColors.Control;
            J28.BackColor = SystemColors.Control;
            L1.BackColor = SystemColors.Control;
            L2.BackColor = SystemColors.Control;
            L3.BackColor = SystemColors.Control;
            L4.BackColor = SystemColors.Control;
            L5.BackColor = SystemColors.Control;
            L6.BackColor = SystemColors.Control;
            L7.BackColor = SystemColors.Control;
            L8.BackColor = SystemColors.Control;
            L9.BackColor = SystemColors.Control;
            L10.BackColor = SystemColors.Control;
            L11.BackColor = SystemColors.Control;
            L12.BackColor = SystemColors.Control;
            L13.BackColor = SystemColors.Control;
            L14.BackColor = SystemColors.Control;
            L15.BackColor = SystemColors.Control;
            L16.BackColor = SystemColors.Control;
            L17.BackColor = SystemColors.Control;
            L18.BackColor = SystemColors.Control;
            L19.BackColor = SystemColors.Control;
            L20.BackColor = SystemColors.Control;
            L21.BackColor = SystemColors.Control;
            L22.BackColor = SystemColors.Control;
            L23.BackColor = SystemColors.Control;
            L24.BackColor = SystemColors.Control;
            L25.BackColor = SystemColors.Control;
            L26.BackColor = SystemColors.Control;
            L27.BackColor = SystemColors.Control;
            L29.BackColor = SystemColors.Control;
            L30.BackColor = SystemColors.Control;
            L31.BackColor = SystemColors.Control;
            L32.BackColor = SystemColors.Control;
            

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            regresar.Visible = true;
            this.Visible = false;
        }
    }
}
