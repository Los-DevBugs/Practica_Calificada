using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;
using System.Configuration;  //Cadena de conexión

namespace CapaNegocio
{
    public class Docente
    {
        //Cadena Conexion
        private static string cadena = ConfigurationManager.ConnectionStrings["Cadena"].ConnectionString;

        // mapear las columnas de la tabla en columnas de la clase
        public string CodDocente { get; set; }

        public string APaterno { get; set; }

        public string AMaterno { get; set; }

        public string NombresDocen { get; set; }

        public string Usuario { get; set; }


        //Implementar los metodos de la clase
        public DataTable Listar()
        {
            using (SqlConnection conexion = new SqlConnection(cadena))
            {
                string consulta = "select * from TDocente";
                SqlDataAdapter adapter = new SqlDataAdapter(consulta, conexion);
                DataTable tabla = new DataTable();
                adapter.Fill(tabla);
                return tabla;
            }
        }

        public bool Agregar()
        {
            using (SqlConnection conexion = new SqlConnection(cadena))
            {
                string consulta = "insert into TDocente values(@CodDocente,@APaterno,@AMaterno,@NombresDocente,@Usuario)";
                SqlCommand comando = new SqlCommand(consulta, conexion);
                comando.Parameters.AddWithValue("@CodDocente", CodDocente);
                comando.Parameters.AddWithValue("@APaterno", APaterno);
                comando.Parameters.AddWithValue("@AMaterno", AMaterno);
                comando.Parameters.AddWithValue("@NombresDocente", NombresDocen);
                comando.Parameters.AddWithValue("@Usuario", Usuario);
                conexion.Open();
                byte i = Convert.ToByte(comando.ExecuteNonQuery());
                conexion.Close();
                if (i == 1) return true;
                else return false;
            }
        }

        public bool Eliminar()
        {
            using (SqlConnection conexion = new SqlConnection(cadena))
            {
                string consulta = "delete from TDocente where CodDocente = @CodDocente";
                SqlCommand comando = new SqlCommand(consulta, conexion);
                comando.Parameters.AddWithValue("@CodDocente", CodDocente);
                conexion.Open();
                byte i = Convert.ToByte(comando.ExecuteNonQuery());
                conexion.Close();
                if (i == 1) return true;
                else return false;
            }
        }

        public bool Actualizar()
        {
            using (SqlConnection conexion = new SqlConnection(cadena))
            {
                string consulta = "update TDocente set APaterno=@APaterno, AMaterno=@AMaterno, Docente=@NombresDocente, Usuario=@Usuario where CodDocente=@CodDocente";
                SqlCommand comando = new SqlCommand(consulta, conexion);
                comando.Parameters.AddWithValue("@CodDocente", CodDocente);
                comando.Parameters.AddWithValue("@APaterno", APaterno);
                comando.Parameters.AddWithValue("@AMaterno", AMaterno);
                comando.Parameters.AddWithValue("@NombresDocente", NombresDocen);
                comando.Parameters.AddWithValue("@Usuario", Usuario);
                conexion.Open();
                byte i = Convert.ToByte(comando.ExecuteNonQuery());
                conexion.Close();
                if (i == 1) return true;
                else return false;
            }
        }

        public DataTable Buscar(string criterio)
        {
            using (SqlConnection conexion = new SqlConnection(cadena))
            {
                string consulta = "SELECT * FROM TDocente WHERE CodDocente = @Criterio OR Usuario LIKE '%' + @Criterio + '%'";
                SqlCommand comando = new SqlCommand(consulta, conexion);
                comando.Parameters.AddWithValue("@Criterio", criterio);
                SqlDataAdapter adapter = new SqlDataAdapter(comando);
                DataTable table = new DataTable();
                adapter.Fill(table);
                return table;
            }
        }
    }
}
