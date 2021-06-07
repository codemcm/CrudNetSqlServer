using System;
using System.Reflection;

namespace Crud.Database
{
    public class DemoGenericReflection<T> where T:class
    {

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


        public void imprimeProps()
        {
            PropertyInfo[] lPropiedades;
            lPropiedades = typeof(T).GetProperties();
            for (int i = 0; i < lPropiedades.Length; i++)
            {
                Console.WriteLine(lPropiedades[i].Name);
                
            }
        }
    }
}
