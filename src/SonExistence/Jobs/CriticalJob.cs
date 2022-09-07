using System;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using Quartz;

namespace SonExistence.Jobs
{
    [DisallowConcurrentExecution]
    public class CriticalJob : IJob
    {
        private readonly ILogger _logger;

        public CriticalJob(ILogger logger)
        {
            _logger = logger;
        }


        public async Task Execute(IJobExecutionContext context)
        {
            while (true)
            {
                _logger.LogCritical("AAAAAAAAA");
            }
            
        }

    }
}