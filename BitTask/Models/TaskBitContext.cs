using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace BitTask.Models
{
        public class TaskBitContext : DbContext
        {
            public DbSet<TaskBit> TaskBit { get; set; }

        }
    }