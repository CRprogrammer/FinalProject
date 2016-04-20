using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data;
using System.Threading;
using System.Windows.Forms;

namespace CineMellRose
{
    class CargaInfo : SQLConnection
    {
        private string sql;
        SqlCommand sqlCmd;
        public void CargaTitulos(int numSala)
        {
            try
            {
                
                ConnectingSQL();

                sqlCmd = new SqlCommand();

                sql = "select titulo from peliculas where titulo = " + numSala;

                sqlCmd.Connection = conn;
                sqlCmd.CommandText = sql;
                sqlCmd.CommandType = CommandType.Text;
                sqlCmd.ExecuteNonQuery();
                GlobalParameters.NombrePelicula = sqlCmd.ExecuteScalar().ToString();

                DesconnectingSQL();
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void CargaSala(int numSala)
        {
            try
            {
                
                ConnectingSQL();

                sqlCmd = new SqlCommand();

                sql = "select titulo from peliculas where titulo = " + numSala;

                sqlCmd.Connection = conn;
                sqlCmd.CommandText = sql;
                sqlCmd.CommandType = CommandType.Text;
                sqlCmd.ExecuteNonQuery();
                GlobalParameters.SalaPelicula = Convert.ToInt16(sqlCmd.ExecuteScalar());

                DesconnectingSQL();
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
        }

    }
}
