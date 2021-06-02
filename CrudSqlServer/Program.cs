using Crud.Database;
using Crud.DTO;
using System;

namespace CrudSqlServer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            DemoReflection demo = new DemoReflection();
            Estudiante es = new Estudiante();
            es.Apellidos = "Ramirez Gonzales";

            demo.imprimePropiedades(es);

            DemoGenericReflection<Estudiante> estudiante = new DemoGenericReflection<Estudiante>();

            estudiante.imprimeProps();
        }
    }
}
