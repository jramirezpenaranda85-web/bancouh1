
using System;
using System.Data;
using System.Data.SqlClient;

namespace bancouh1.Capa_Logica
{
    public class Tecnicos_CL
    {
        public static int AgregarTecnico(int id, string nombre, string especialidad)
        {
            using (SqlConnection conn = DBconn.obtenerConexion())
            {
                SqlCommand cmd = new SqlCommand(
                    "INSERT INTO Tecnicos (TecnicoID, Nombre, Especialidad) VALUES (@id, @nombre, @especialidad)", conn);

                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@nombre", nombre);
                cmd.Parameters.AddWithValue("@especialidad", especialidad);

                return cmd.ExecuteNonQuery();
            }
        }

        public static int ActualizarTecnico(int id, string nombre, string especialidad)
        {
            using (SqlConnection conn = DBconn.obtenerConexion())
            {
                SqlCommand cmd = new SqlCommand(
                    "UPDATE Tecnicos SET Nombre=@nombre, Especialidad=@especialidad WHERE TecnicoID=@id", conn);

                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@nombre", nombre);
                cmd.Parameters.AddWithValue("@especialidad", especialidad);

                return cmd.ExecuteNonQuery();
            }
        }

        public static int EliminarTecnico(int id)
        {
            using (SqlConnection conn = DBconn.obtenerConexion())
            {
                SqlCommand cmd = new SqlCommand(
                    "DELETE FROM Tecnicos WHERE TecnicoID=@id", conn);

                cmd.Parameters.AddWithValue("@id", id);

                return cmd.ExecuteNonQuery();
            }
        }

        public static DataTable MostrarTecnicos()
        {
            using (SqlConnection conn = DBconn.obtenerConexion())
            {
                SqlDataAdapter da = new SqlDataAdapter(
                    "SELECT * FROM Tecnicos", conn);

                DataTable tabla = new DataTable();
                da.Fill(tabla);

                return tabla;
            }
        }
    }
}
