using Microsoft.Azure;
using Microsoft.WindowsAzure.Storage;
using Microsoft.WindowsAzure.Storage.Blob;
using Microsoft.WindowsAzure.Storage.File;
using System;

namespace FileExplorer
{
    class Program
    {
        static void Main(string[] args)
        {
            CloudStorageAccount CuentaAlmacenamiento = 
                CloudStorageAccount.Parse(CloudConfigurationManager.GetSetting("CadenaConexion"));

            CloudFileClient ClienteArchivos = CuentaAlmacenamiento.CreateCloudFileClient();
            CloudFileShare ArchivoCompartido = ClienteArchivos.GetShareReference("filepleon");

            if (ArchivoCompartido.Exists()) 
            {
                CloudFileDirectory CarpetaRaiz = ArchivoCompartido.GetRootDirectoryReference();
                CloudFileDirectory Directorio = CarpetaRaiz.GetDirectoryReference("Archivos");

                if (Directorio.Exists())
                {
                    CloudFile Archivo = Directorio.GetFileReference("prueba.txt");

                    if (Archivo.Exists())
                    {
                        Console.WriteLine(Archivo.DownloadTextAsync().Result);
                        Console.ReadLine();
                    }
                }
            }
        }
    }
}
