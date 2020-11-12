using Microsoft.Azure;
using Microsoft.WindowsAzure.Storage;
using Microsoft.WindowsAzure.Storage.Table;
using System;
using TableExplorer.Entidades;

namespace TableExplorer
{
    class Program
    {
        static void Main(string[] args)
        {
            CloudStorageAccount CuentaAlamacenamiento =
                CloudStorageAccount.Parse(CloudConfigurationManager.GetSetting("CadenaConexion"));

            CloudTableClient ClienteTablas = CuentaAlamacenamiento.CreateCloudTableClient();

            CloudTable Tabla = ClienteTablas.GetTableReference("Clases");

            /* Listar las tablas */
            //Tabla.CreateIfNotExists();

            //var NombreTablas = ClienteTablas.ListTables();

            ///* var se le asigna el valor retornado en este caso lo especificaomos pero no es necesario*/
            //foreach (CloudTable item in NombreTablas) 
            //{
            //    Console.WriteLine(item.Name);
            //}

            /* Insertar entidades a una tabla */

            //Profesor Profe1 = new Profesor("001", "Profesores");
            //Profe1.NombreProfesor = "Percy Leon";
            //Profe1.NombreAsignatura = "Microcontroladores";

            //Profesor Profe2 = new Profesor("002", "Profesores");
            //Profe2.NombreProfesor = "Victor Leon";
            //Profe2.NombreAsignatura = "Diseño audiovisual";

            //TableOperation InsertProfe1 = TableOperation.Insert(Profe1);
            //TableOperation InsertProfe2 = TableOperation.Insert(Profe2);

            //Tabla.Execute(InsertProfe1);
            //Tabla.Execute(InsertProfe2);

            Console.WriteLine("Entidades insertadas con exito");
  
            Console.ReadLine();
        }
    }
}
