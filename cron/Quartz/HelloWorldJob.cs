using cron.Services;
using Quartz;
using System;
using System.Threading.Tasks;

namespace cron.Quartz
{
    public class HelloWorldJob : IJob
    {
        private readonly LogDate logDate;

        public HelloWorldJob(LogDate logDate)
        {
            this.logDate = logDate;
        }
        public Task Execute(IJobExecutionContext context)
        {
            logDate.testc();
            return Task.CompletedTask;
        }
    }
}
