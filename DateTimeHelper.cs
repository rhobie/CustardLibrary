using System;

namespace CustardLibrary
{
    public static class DateTimeHelper
    {
        public static DateTime PrevMonday
        {
            get { return DateTime.Now.StartOfWeek(DayOfWeek.Monday).AddDays(-7); }
        }

        public static DateTime MostRecentSaturday
        {
            get { return DateTime.Now.StartOfWeek(DayOfWeek.Saturday); }
        }

        public static DateTime Today
        {
            get { return DateTime.Now; }
        }

        public static DateTime SevenDaysAgo
        {
            get { return DateTime.Now.AddDays(-7); }
        }

    }

    public static class DateTimeExtensions
    {
        public static DateTime StartOfWeek(this DateTime dt, DayOfWeek startOfWeek)
        {
            int diff = dt.DayOfWeek - startOfWeek;
            if (diff < 0)
            {
                diff += 7;
            }
            return dt.AddDays(-1 * diff).Date;
        }

        public static DateTime GetDateWithoutMilliseconds(DateTime d)
        {
            return new DateTime(d.Year, d.Month, d.Day, d.Hour, d.Minute, d.Second);
        }
    }
}
