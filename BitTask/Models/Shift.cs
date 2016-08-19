using System;

namespace BitTask.Models
{
    internal class Shift
    {
        internal Guid ID { get; set; } = Guid.NewGuid();
        internal TemporalPoint Start { get; set; }
        internal TemporalPoint End { get; set; }
    }
}