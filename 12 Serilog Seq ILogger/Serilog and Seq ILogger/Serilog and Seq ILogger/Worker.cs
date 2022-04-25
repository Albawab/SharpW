using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serilog_and_Seq_ILogger
{
    public class Worker : BackgroundService
    {
        private readonly ILogger<object> logger;

        public Worker(ILogger<Worker> logger)
        {
            this.logger = logger;
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            while (!stoppingToken.IsCancellationRequested)
            {
                logger.LogInformation("Hello world at:", DateTimeOffset.Now);
                await Task.Delay(1000);
            }
        }
    }
}
