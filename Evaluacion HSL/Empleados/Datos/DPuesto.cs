using Entidades;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    
    public class DPuesto
    {
        string conection = ConfigurationManager.ConnectionStrings["LocalConnection"].ConnectionString;
        List<Puesto> lstPuesto = new List<Puesto>();
        string query;
        SqlCommand comando;

        public List<Puesto> Consultar() 
        {
            query = "select * from Puesto";
            using (SqlConnection con = new SqlConnection(conection))
            {
                comando = new SqlCommand(query, con);
                comando.CommandType = CommandType.Text;
                con.Open();
                SqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    lstPuesto.Add(
                        new Puesto()
                        {
                            idPuesto = Convert.ToInt32(reader["idPuesto"]),
                            clave = reader["clave"].ToString(),
                            nomPuesto = reader["nomPuesto"].ToString()
                        }
                        );
                }
                con.Close();
            }
            return lstPuesto;
        }
    }
}
