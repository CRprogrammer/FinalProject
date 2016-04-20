using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data;

namespace CineMellRose
{
    class SQLConnection
    {
        protected SqlDataAdapter sqlDataAdapter = null;
        string Datasource = "JAMES\\SQLEXPRESS";
        string InitCatalog = "Cinee";
        string IntegratedSecurity = "True";
        static string conexion;
        public SqlConnection conn = new SqlConnection(conexion);
        bool state;

        public SQLConnection()
        {
            conexion = "";
        }

        public bool OpenConnection()
        {
            if (conn.State == ConnectionState.Closed)
            {
                state = false;
            }
            else
            {
                state = true;
            }
            return state;

        }

        public void ConnectingSQL()
        {
            try
            {
                if (!OpenConnection())
                {

                    conexion = "Data Source=" + Datasource + ";" + "Initial Catalog=" + InitCatalog + ";" + "Integrated Security=" + IntegratedSecurity + ";";
                    conn = new SqlConnection(conexion);
                    conn.Open();
                }
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);

            }
        }

        public void DesconnectingSQL()
        {
            try
            {
                if (OpenConnection())
                {
                    conn.Close();
                    conn = null;
                }
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
        }

    }
}