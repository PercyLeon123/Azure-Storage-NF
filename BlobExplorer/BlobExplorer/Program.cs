using Microsoft.WindowsAzure;
using Microsoft.WindowsAzure.Storage;
using Microsoft.WindowsAzure.Storage.Blob;
using Microsoft.Azure;
using System;

namespace BlobExplorer
{
    class Program
    {
        static void Main(string[] args)
        {
            CloudStorageAccount CuentaAlmacenamiento = CloudStorageAccount.Parse(CloudConfigurationManager.GetSetting("StorageConnectionString"));
            CloudBlobClient ClienteBlob = CuentaAlmacenamiento.CreateCloudBlobClient();
            CloudBlobContainer Contenedor = ClienteBlob.GetContainerReference("pleondrive");
            //Contenedor.CreateIfNotExists();
            //Contenedor.SetPermissions(new BlobContainerPermissions { PublicAccess = BlobContainerPublicAccessType.Blob });

            CloudBlockBlob MiBlob = Contenedor.GetBlockBlobReference("foto.jpg");

            using (var fileStream = System.IO.File.OpenRead(@"D:\\no_tocar\\percy\\Nueva carpeta\\IMG_20190205_213629.jpg"))
            {
                MiBlob.UploadFromStream(fileStream);
            }

            Console.WriteLine("Successful container creation");
            Console.ReadLine();
        }
    }
}
