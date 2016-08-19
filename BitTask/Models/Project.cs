using System;
using System.Collections.Generic;

namespace BitTask.Models
{
    internal class Project
    {
        internal Guid ID { get; set; } = Guid.NewGuid();
        internal List<Category> Categories { get; set; } = new List<Category>();
        internal bool ApprovalRequired { get; set; } = true;

    }
}