using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Discos_Proyecto
{
    internal class DiscosDatos
    {
        public List<Disco> datos()
        {
            List<Disco> list = new List<Disco> ();
            SqlConnection connection = new SqlConnection();
            SqlCommand cmd = new SqlCommand();
            SqlDataReader reader;

            try
            {
                connection.ConnectionString = "server=.\\SQLEXPRESS; database=DISCOS_DB; integrated security=true";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = "Select Titulo, FechaLanzamiento, CantidadCanciones, UrlImagenTapa From DISCOS";
                cmd.Connection = connection;

                connection.Open ();
                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Disco aux = new Disco ();
                    aux.Titulo = (string)reader["Titulo"];
                    aux.FechaLanzamiento = (DateTime)reader["FechaLanzamiento"];
                    aux.CantidadDeCanciones = (int)reader["CantidadCanciones"];
                    aux.UrlImagenTapa = (string)reader["UrlImagenTapa"];

                    list.Add(aux);


                }

                connection.Close ();
                return list;

            }
            catch (Exception ex)
            {
                throw ex;
            }


        }
    }
}
