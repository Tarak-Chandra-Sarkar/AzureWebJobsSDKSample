using Microsoft.Azure.WebJobs;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace AzureWebJobsSDKSample
{
    public class Functions
    {
        public static void ProcessQueueMessage([QueueTrigger("queue")]string message,
            [Blob("container/{queueTrigger}", FileAccess.Read)] Stream myBlob,
            [Blob("container/copy-{queueTrigger}", FileAccess.Write)] Stream outputBlob,
            ILogger logger)
        {
            logger.LogInformation($"Blob name:{message} \n Size: {myBlob.Length} bytes");
        }
    }
}
