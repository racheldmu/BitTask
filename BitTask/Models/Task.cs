using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BitTask.Models
{
    internal class Task
    {
        internal Guid ID { get; set; } = Guid.NewGuid();
        internal int EstimatedTime { get; set; }
        internal int ActualTime { get; set; }
        internal Person Person { get; set; }
        internal string ShortTaskDescription { get; set; }
        internal string LongTaskDescription { get; set; }
        internal Project Project { get; set; }
        internal Category Category { get; set; }
        internal DateTime Date { get; set; }
        internal Person Approver { get; set; }
    }
}