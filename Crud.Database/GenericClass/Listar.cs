using Crud.DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Reflection;

namespace Crud.Database.GenericClass
{
    public class Listar<T> where T:class, new()
    {
        private readonly SqlConnection Conexion = new SqlConnection("Server=DESKTOP-5CIT38A;DataBase= Escuela;Integrated Security=true");
        public List<T> getList(string cadena)
        {
            Console.WriteLine("Listar Generico");
            List<T> lista = new();
            T entidad;
            Conexion.Open();
            SqlCommand comando = new SqlCommand(cadena, Conexion);
            SqlDataReader registros = comando.ExecuteReader();
            while (registros.Read())
            {
                entidad = Activator.CreateInstance<T>();
                foreach (PropertyInfo prop in entidad.GetType().GetProperties())
                {
                    if (!registros[prop.Name].Equals(DBNull.Value))
                    {
                        prop.SetValue(entidad, registros[prop.Name], null);
                    }
                }
                lista.Add(entidad);
            }
            Conexion.Close();
            return lista;
        }

        public void muestraEstudiantes(List<Estudiante> lista)
        {
            foreach (var item in lista)
            {
                Console.WriteLine(item.Apellidos);
            }
        }
    }
}
