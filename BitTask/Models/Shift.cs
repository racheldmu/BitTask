using System;

namespace BitTask.Models
{
    public class Shift
    {
        public Guid ID { get; set; } = Guid.NewGuid();
        public TemporalPoint Start { get; set; }
        public TemporalPoint End { get; set; }
    }
}