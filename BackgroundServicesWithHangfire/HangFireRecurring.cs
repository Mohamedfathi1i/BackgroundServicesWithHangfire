using DALHangfire.Repository.EventRepos;
using Hangfire;
using PLHangfire.Services.Eventservs;

namespace BackgroundServicesWithHangfire
{
    public static class HangFireRecurring
    {

        public static void hangFireConfigJobs()
        {
        RecurringJob.AddOrUpdate<IEventService>(x => x.GetAllEvents(),"*/5 * * * *");

        }
    }
}
