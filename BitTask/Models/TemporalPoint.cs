using System;

namespace BitTask.Models
{
    internal enum DayOfTheWeek
    {
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
        Sunday
    }
    internal class TemporalPoint
    {
        internal Guid ID { get; set; } = Guid.NewGuid();
        internal DayOfTheWeek Day { get; set; }
        internal int MinutesPastMidnight { get; set; }
    }
}