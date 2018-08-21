using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Azure.WebJobs;
using Microsoft.Extensions.Logging;

namespace AzureWebJobsSDKSample
{
    class Program
    {
        static void Main(string[] args)
        {
            var config = new JobHostConfiguration();
            config.DashboardConnectionString = "";

            var loggerFactory = new LoggerFactory();
            config.LoggerFactory = loggerFactory.AddConsole();

            var host = new JobHost(config);
            host.RunAndBlock();
        }
    }
}
