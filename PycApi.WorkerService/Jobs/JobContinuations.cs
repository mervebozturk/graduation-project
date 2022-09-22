using System;

namespace PycApi.Hangfire
{
    public static class JobContinuations
    {
        public static string Run()
        {
            Console.WriteLine("JobContinuations");
            return "JobContinuations";
        }
    }
}
