using System;
using System.Data.SqlClient;
using System.Data;
using System.Collections.Generic;
using Crud.DTO;
using System.Reflection;

namespace Crud.Database
{
    public class ConeccionEstudiante
    {
        private readonly SqlConnection Conexion = new SqlConnection("Server=DESKTOP-5CIT38A;DataBase= Escuela;Integrated Security=true");

        public void ConsultaEstudiantes()
        {
            Console.WriteLine("bu");
            Conexion.Open();
            string cadena = "select EstudianteId, Apellidos, Nombre from Estudiante";
            SqlCommand comando = new SqlCommand(cadena, Conexion);
            SqlDataReader registros = comando.ExecuteReader();
            while (registros.Read())
            {
                //Console.WriteLine(registros["EstudianteId"].ToString());
                //Console.WriteLine(registros["Apellidos"].ToString());
                Console.WriteLine(registros["Nombre"].ToString());
            }
            Conexion.Close();
        }

        public List<Estudiante> getEstudiantes()
        {
            Console.WriteLine("LISTA DE ESTUDIANTES");
            List<Estudiante> lEstudiantes = new List<Estudiante>();
            Estudiante estudiante;
            Console.WriteLine("bu");
            Conexion.Open();
            string cadena = "select EstudianteId, Apellidos, Nombre from Estudiante";
            SqlCommand comando = new SqlCommand(cadena, Conexion);
            SqlDataReader registros = comando.ExecuteReader();
            while (registros.Read())
            {
                estudiante = new Estudiante();
                estudiante.Apellidos = (string)registros["Apellidos"];
                estudiante.EstudianteId = (int)registros["EstudianteId"];
                //Console.WriteLine(registros["EstudianteId"].ToString());
                //Console.WriteLine(registros["Apellidos"].ToString());
                //Console.WriteLine(registros["Nombre"].ToString());
            }
            Conexion.Close();
            return lEstudiantes;
        }

        public void muestraEstudiantes(List<Estudiante> lista)
        {
            foreach (var item in lista)
            {
                Console.WriteLine(item.Apellidos);
            }
        }
        //public void imprimePropiedades(Estudiante estudiante)
        //{
        //    PropertyInfo[] myPropertyInfo;
        //    // Get the properties of 'Type' class object.
        //    myPropertyInfo = estudiante.GetType().GetProperties();
        //    Console.WriteLine("Properties of System.Type are:");
        //    for (int i = 0; i < myPropertyInfo.Length; i++)
        //    {
        //        Console.WriteLine(myPropertyInfo[i].ToString());
        //    }
        //}
        public List<Estudiante> listaEstudiantesDinamico()
        {
            Console.WriteLine("LISTA DE ESTUDIANTES");
            List<Estudiante> lEstudiantes = new List<Estudiante>();
            Estudiante estudiante;
            Console.WriteLine("bu");
            Conexion.Open();
            string cadena = "select EstudianteId, Apellidos, Nombre, Direccion, Observaciones from Estudiante";
            SqlCommand comando = new SqlCommand(cadena, Conexion);
            SqlDataReader registros = comando.ExecuteReader();
            while (registros.Read())
            {
                estudiante = new Estudiante();
                estudiante.Apellidos = (string)registros["Apellidos"];
                estudiante.EstudianteId = (int)registros["EstudianteId"];
                //Console.WriteLine(registros["EstudianteId"].ToString());
                //Console.WriteLine(registros["Apellidos"].ToString());
                //Console.WriteLine(registros["Nombre"].ToString());
                foreach (PropertyInfo prop in estudiante.GetType().GetProperties())
                {
                    if (!registros[prop.Name].Equals(DBNull.Value))
                    {
                        prop.SetValue(estudiante, registros[prop.Name], null);                  
                    }
                }
                lEstudiantes.Add(estudiante);
            }
            Conexion.Close();
            return lEstudiantes;
        }
    }
}
