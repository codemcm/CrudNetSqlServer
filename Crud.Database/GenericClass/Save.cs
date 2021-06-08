using System.Data.SqlClient;

namespace Crud.Database.GenericClass
{
    public class Save
    {
        private readonly SqlConnection Conexion = new SqlConnection("Server=DESKTOP-5CIT38A;DataBase= Escuela;Integrated Security=true");

        /*
         Se puede utilizar ExecuteNonQuery para realizar operaciones de catálogo 
        (por ejemplo, consultar la estructura de una base de datos o crear objetos de base de datos como tablas)
        o para cambiar la información de una base de datos ejecutando las instrucciones UPDATE, INSERT o DELETE.*/
        // Para las instrucciones UPDATE, INSERT y DELETE, el valor devuelto corresponde al número de filas afectadas por el comando.
        // Para los demás tipos de instrucciones, el valor devuelto es -1.


        //InsertData regresa el numero de registros afectados al insertar
        public int InsertData(string query)
        {
            Conexion.Open();
            SqlCommand comando = new SqlCommand(query, Conexion);
            int registrosAfectados = comando.ExecuteNonQuery();
            Conexion.Close();
            return registrosAfectados;
        }

        public int UpdateData(string query)
        {
            Conexion.Open();
            SqlCommand comando = new SqlCommand(query, Conexion);
            int registrosAfectados = comando.ExecuteNonQuery();
            Conexion.Close();
            return registrosAfectados;
        }

        public int DeleteData(string query)
        {
            Conexion.Open();
            SqlCommand comando = new SqlCommand(query, Conexion);
            int registrosAfectados = comando.ExecuteNonQuery();
            Conexion.Close();
            return registrosAfectados;
        }
    }
}
