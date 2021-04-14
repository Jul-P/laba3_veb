using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication1.Storege.Entity
{
    public class Predmet : IUnic
    {
        [Key]
        [Required]
        [Column("id")]
        public Guid Id { get; set; }
        [Required]
        [Column("Nazvanie")]
        public string Nazvanie { get; set; }
        [Required]
        [Column("gPrepodId")]
        public Guid PrepodId { set; get; }
        [ForeignKey(nameof(PrepodId))]
        public Prepod Prepod { get; set; }
    }
}
