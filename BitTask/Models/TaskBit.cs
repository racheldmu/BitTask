using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BitTask.Models
{
    public class TaskBit
    {
        public Guid ID { get; set; } = Guid.NewGuid();
        public int EstimatedTime { get; set; }
        public int ActualTime { get; set; }
        public Person Person { get; set; }
        public string ShortTaskDescription { get; set; }
        public string LongTaskDescription { get; set; }
        public Project Project { get; set; }
        public Category Category { get; set; }
        public DateTime Date { get; set; }
        public Person Approver { get; set; }
    }
}