using System;

namespace BitTask.Models
{
    public enum DayOfTheWeek
    {
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
        Sunday
    }
    public class TemporalPoint
    {
        public Guid ID { get; set; } = Guid.NewGuid();
        public DayOfTheWeek Day { get; set; }
        public int MinutesPastMidnight { get; set; }
    }
}