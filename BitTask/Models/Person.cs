using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace BitTask.Models
{
    internal class Person
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        internal string Email { get; set; }
        internal string FirstName { get; set; }
        internal string LastName { get; set; }
        internal byte Permission { get; set; }
        internal List<Shift> Shifts { get; set; } = new List<Shift>();
        internal string Password { get; set; }
    }
}