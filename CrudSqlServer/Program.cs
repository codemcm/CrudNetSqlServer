using Crud.Database;
using Crud.Database.GenericClass;
using Crud.DTO;

namespace CrudSqlServer
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            //DemoReflection demo = new DemoReflection();
            //Estudiante es = new Estudiante();
            //es.Apellidos = "Ramirez Gonzales";

            //demo.imprimePropiedades(es);

            //DemoGenericReflection<Estudiante> estudiante = new DemoGenericReflection<Estudiante>();

            //estudiante.imprimeProps();

            //ConeccionEstudiante coneccionEstudiante = new ConeccionEstudiante();
            //coneccionEstudiante.ConsultaEstudiantes();
            Listar<Estudiante> estudiante = new Listar<Estudiante>();
            estudiante.muestraEstudiantes(estudiante.getList("select EstudianteId, Apellidos, Nombre, Direccion, Observaciones from Estudiante"));
        }
    }
}
