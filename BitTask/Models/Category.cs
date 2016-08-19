using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BitTask.Models
{
    internal class Category
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        internal string CategoryName { get; set; }
    }
}