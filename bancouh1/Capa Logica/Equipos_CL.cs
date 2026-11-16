
using System;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace bancouh1.Capa_Logica
{
    public class Equipos_CL
    {
        static string conexion = ConfigurationManager
            .ConnectionStrings["conexion"].ConnectionString;

        public static DataTable MostrarEquipos()
        {
            using (SqlConnection con = new SqlConnection(conexion))
            {
                SqlDataAdapter da = new SqlDataAdapter(
                    "SELECT * FROM Equipos", con);

                DataTable tabla = new DataTable();
                da.Fill(tabla);
                return tabla;
            }
        }

        public static void AgregarEquipo(int id, string tipo,
            string modelo, int usuario)
        {
            Ejecutar(
                "INSERT INTO Equipos (EquipoID, TipoEquipo, Modelo, UsuarioID) VALUES (@id, @tipo, @modelo, @usuario)",
                id, tipo, modelo, usuario);
        }

        public static void ActualizarEquipo(int id, string tipo,
            string modelo, int usuario)
        {
            Ejecutar(
                "UPDATE Equipos SET TipoEquipo=@tipo, Modelo=@modelo, UsuarioID=@usuario WHERE EquipoID=@id",
                id, tipo, modelo, usuario);
        }

        public static void EliminarEquipo(int id)
        {
            Ejecutar(
                "DELETE FROM Equipos WHERE EquipoID=@id",
                id, "", "", 0);
        }

        private static void Ejecutar(string sql, int id,
            string tipo, string modelo, int usuario)
        {
            using (SqlConnection con = new SqlConnection(conexion))
            {
                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.Parameters.AddWithValue("@tipo", tipo);
                    cmd.Parameters.AddWithValue("@modelo", modelo);
                    cmd.Parameters.AddWithValue("@usuario", usuario);

                    con.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
