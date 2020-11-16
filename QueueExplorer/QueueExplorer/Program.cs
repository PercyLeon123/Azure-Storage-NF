using Microsoft.Azure;
using Microsoft.WindowsAzure.Storage;
using Microsoft.WindowsAzure.Storage.Queue;

namespace QueueExplorer
{
    class Program
    {
        static void Main(string[] args)
        {
            CloudStorageAccount MiCuenta = 
                CloudStorageAccount.Parse(CloudConfigurationManager.GetSetting("StringConexion"));

            CloudQueueClient ClienteColas = MiCuenta.CreateCloudQueueClient();
        }
    }
}
