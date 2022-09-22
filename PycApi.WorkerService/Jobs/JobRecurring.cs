using System;

namespace PycApi.Hangfire
{
    public static class JobRecurring
    {
        public static string Run()
        {
            Console.WriteLine("JobRecurring");
            return "JobRecurring";
        }
    }
}
