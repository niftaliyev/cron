using cron.Services;
using Quartz;
using System;
using System.Threading.Tasks;

namespace cron.Quartz
{
    public class HelloWorldJob : IJob
    {
        public Task Execute(IJobExecutionContext context)
        {
            LogDate.testc();
            return Task.CompletedTask;
        }
    }
}
