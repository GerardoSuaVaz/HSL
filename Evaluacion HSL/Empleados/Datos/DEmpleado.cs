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

    public class DEmpleado
    {
        string conection = ConfigurationManager.ConnectionStrings["LocalConnection"].ConnectionString;
        List<Empleado> lstEmpleado = new List<Empleado>();
        string query;
        SqlCommand comando;

        public List<Empleado> Consultar()
        {
            query = "select * from Empleado";
            using (SqlConnection con = new SqlConnection(conection))
            {
                comando = new SqlCommand(query, con);
                comando.CommandType = CommandType.Text;
                con.Open();
                SqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    lstEmpleado.Add(
                        new Empleado()
                        {
                            idEmpleado = Convert.ToInt32(reader["idEmpleado"]),
                            Nombre = reader["Nombre"].ToString(),
                            Apellido = reader["Apellido"].ToString(),
                            Curp = reader["Curp"].ToString(),
                            Rfc = reader["Rfc"].ToString(),
                            fechaNacimiento = Convert.ToDateTime(reader["fechaNacimiento"]),
                            idPuesto = Convert.ToInt32(reader["idPuesto"])
                        }
                        );
                }
                con.Close();
            }
            return lstEmpleado;
        }
        public Empleado Consultar(int id)
        {
            Empleado cEmpleado = new Empleado();
            query = "rEmpleados";
            using (SqlConnection con = new SqlConnection(conection))
            {
                comando = new SqlCommand(query, con);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@idEmpleado", id);
                con.Open();
                SqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    cEmpleado = new Empleado
                    {
                        idEmpleado = Convert.ToInt32(reader["idEmpleado"].ToString()),
                        Nombre = reader["Nombre"].ToString(),
                        Apellido = reader["Apellido"].ToString(),
                        Curp = reader["Curp"].ToString(),
                        Rfc = reader["Rfc"].ToString(),
                        fechaNacimiento = Convert.ToDateTime(reader["fechaNacimiento"].ToString()),
                        idPuesto = Convert.ToInt32(reader["idPuesto"])
                    };
                }
                con.Close();
            }
            return cEmpleado;
        }

        public void Agregar(Empleado nEmpleado) 
        {
            query = "cEmpleados";
            using (SqlConnection con = new SqlConnection(conection))
            {
                comando = new SqlCommand(query, con);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@Nombre", nEmpleado.Nombre);
                comando.Parameters.AddWithValue("@Apellido", nEmpleado.Apellido);
                comando.Parameters.AddWithValue("@Curp", nEmpleado.Curp);
                comando.Parameters.AddWithValue("@Rfc", nEmpleado.Rfc);
                comando.Parameters.AddWithValue("@fechaNacimiento", nEmpleado.fechaNacimiento);
                comando.Parameters.AddWithValue("@idPuesto", nEmpleado.idPuesto);
                con.Open();
                comando.ExecuteNonQuery();
                con.Close();
            }
        }

        public void Actualizar(Empleado aEmpleado)
        {
            query = "uEmpleados";
            using (SqlConnection con = new SqlConnection(conection))
            {
                comando = new SqlCommand(query, con);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@idEmpleado", aEmpleado.idEmpleado);
                comando.Parameters.AddWithValue("@Nombre", aEmpleado.Nombre);
                comando.Parameters.AddWithValue("@Apellido", aEmpleado.Apellido);
                comando.Parameters.AddWithValue("@Curp", aEmpleado.Curp);
                comando.Parameters.AddWithValue("@Rfc", aEmpleado.Rfc);
                comando.Parameters.AddWithValue("@fechaNacimiento", aEmpleado.fechaNacimiento);
                comando.Parameters.AddWithValue("@idPuesto", aEmpleado.idPuesto);
                con.Open();
                comando.ExecuteNonQuery();
                con.Close();
            }
        }

        public void Eliminar(int id)
        {
            query = "dEmpleados";
            using (SqlConnection con = new SqlConnection(conection))
            {
                comando = new SqlCommand(query, con);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@idEmpleado", id);
                con.Open();
                comando.ExecuteNonQuery();
                con.Close();
            }
        }
    }
}
