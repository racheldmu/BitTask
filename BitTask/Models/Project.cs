using System;
using System.Collections.Generic;

namespace BitTask.Models
{
    public class Project
    {
        public Guid ID { get; set; } = Guid.NewGuid();
        public List<Category> Categories { get; set; } = new List<Category>();
        public bool ApprovalRequired { get; set; } = true;

    }
}