using System;

namespace date_processor.utils
{
    public static class DateTimeUtils
    {
        public static bool IsDayWeekend(DayOfWeek day)
        {
            return ((day == DayOfWeek.Saturday) || (day == DayOfWeek.Sunday));
        }
    }
}
