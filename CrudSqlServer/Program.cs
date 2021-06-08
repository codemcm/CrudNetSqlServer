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
            //Listar<Estudiante> estudiante = new Listar<Estudiante>();
            //estudiante.muestraEstudiantes(estudiante.getList("select EstudianteId, Apellidos, Nombre, Direccion, Observaciones from Estudiante"));


            Save estudiante = new Save();

            string insertQuery= @"INSERT INTO Estudiante (Apellidos, Nombre, Direccion, Observaciones) VALUES('Cruz', 'Martin','mi direccion','sin observations...')";

            string UpdateQuery = @"UPDATE Estudiante SET Nombre='Editado' WHERE EstudianteId=2";
            string DeleteQuery = @"DELETE FROM Estudiante WHERE EstudianteId =1";
            //estudiante.InsertData(insertQuery);
            //estudiante.DeleteData(DeleteQuery);
            estudiante.UpdateData(UpdateQuery);
        }
    }
}
