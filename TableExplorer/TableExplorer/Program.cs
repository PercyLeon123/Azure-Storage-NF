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
            Tabla.DeleteIfExists(); /* Eliminar tabla*/

            ///* Listar las tablas */
            //Tabla.CreateIfNotExists(); /* Crea la tabla si no existe */

            //var NombreTablas = ClienteTablas.ListTables();

            ///* var se le asigna el valor retornado en este caso lo especificaomos pero no es necesario*/
            //foreach (CloudTable item in NombreTablas)
            //{
            //    Console.WriteLine(item.Name);
            //}

            ///* Insertar entidades a una tabla */
            //Profesor Profe1 = new Profesor("003", "Profesores");
            //Profe1.NombreProfesor = "Percy Leon";
            //Profe1.NombreAsignatura = "Microcontroladores";

            //Profesor Profe2 = new Profesor("004", "Profesores");
            //Profe2.NombreProfesor = "Victor Leon";
            //Profe2.NombreAsignatura = "Diseño audiovisual";

            //TableOperation InsertProfe1 = TableOperation.Insert(Profe1);
            //TableOperation InsertProfe2 = TableOperation.Insert(Profe2);

            //Tabla.Execute(InsertProfe1);
            //Tabla.Execute(InsertProfe2);

            /* Listar registros de la tabla Clases */
            //TableQuery<Profesor> Consulta = new TableQuery<Profesor>()
            //        .Where(TableQuery.GenerateFilterCondition("PartitionKey", QueryComparisons.GreaterThan, "000"));

            //var ListRegistros = Tabla.ExecuteQuery(Consulta);

            //foreach (Profesor profe in ListRegistros)
            //{
            //    Console.WriteLine("{0}, {1}\t{2}\t{3}", profe.PartitionKey, profe.RowKey, profe.NombreProfesor, profe.NombreAsignatura);
            //}

            ///* Modificar */
            //TableOperation OperacionModificar = TableOperation.Retrieve<Profesor>("002", "Profesores"); /* Select */
            //TableResult ResultadoObtenido = Tabla.Execute(OperacionModificar);
            //Profesor EntidadModificada = (Profesor)ResultadoObtenido.Result;

            ///* Si encuentra el registro */
            //if (EntidadModificada != null)
            //{
            //    EntidadModificada.NombreAsignatura = "Diseño Grafico";
            //    TableOperation OperacionActualizar = TableOperation.Replace(EntidadModificada);
            //    Tabla.Execute(OperacionActualizar);

            //    Console.WriteLine("tu reagistro ha sido modificado");
            //}
            //else
            //{
            //    Console.WriteLine("Tu entidad no existe");
            //}

            /* Eliminar */
            //TableOperation OperacionModificar = TableOperation.Retrieve<Profesor>("002", "Profesores"); /* Select */
            //TableResult ResultadoObtenido = Tabla.Execute(OperacionModificar);
            //Profesor EntidadEliminada = (Profesor)ResultadoObtenido.Result;

            ///* Si encuentra el registro */
            //if (EntidadEliminada != null)
            //{
            //    TableOperation OperacionEliminarr = TableOperation.Delete(EntidadEliminada);
            //    Tabla.Execute(OperacionEliminarr);

            //    Console.WriteLine("tu reagistro ha sido modificado");
            //}
            //else
            //{
            //    Console.WriteLine("Tu entidad no existe");
            //}

            //var ListRegistros = Tabla.ExecuteQuery(Consulta);

            //foreach (Profesor profe in ListRegistros)
            //{
            //    Console.WriteLine("{0}, {1}\t{2}\t{3}", profe.PartitionKey, profe.RowKey, profe.NombreProfesor, profe.NombreAsignatura);
            //}

            Console.WriteLine("Lista de profesores obtenidad con exito");
            Console.ReadLine();
        }
    }
}
