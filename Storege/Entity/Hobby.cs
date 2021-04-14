using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication1.Storege.Entity
{
    public class Hobby : IUnic
    {
        [Key]
        [Required]
        [Column("id")]
        public Guid Id { get; set; }
        [Required]
        [Column("hobby")]
        public string hobby { get; set; }
    }
}
