using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace BitTask.Models
{
    public class PersonContext : DbContext
    {
        public  DbSet<Person> Persons { get; set; }
        
    }
}