using System;
using date_processor.structures;
using date_processor.utils;

namespace date_processor
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime[] holidays = { Convert.ToDateTime("Jun 01 2020")
            , Convert.ToDateTime("Jun 25 2020")
            , Convert.ToDateTime("Jun 26 2020") };

            DateRange dateRange = new DateRange();
            dateRange.Start = Convert.ToDateTime("Jun 01 2020");
            dateRange.End = Convert.ToDateTime("Jun 29 2020");

            Console.WriteLine("Working days: {0}", CountWorkingDays(dateRange, holidays));
        }

        public static int CountWorkingDays(DateRange dateRange, DateTime[] holidays)
        {
            int workDays = 0;

            for (DateTime date = dateRange.Start; date.Date <= dateRange.End; date = date.AddDays(1))
            {
                if (Array.IndexOf(holidays, date) == -1 && !DateTimeUtils.IsDayWeekend(date.DayOfWeek))
                {
                    workDays++;
                }
            }
            return workDays;
        }
    }

}
