using Proje.ToDo.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Proje.ToDo.Entities.Concrete
{
    public class Work:ITable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        [MaxLength(100)]
        public string Name { get; set; }
        [Column(TypeName = "ntext")]
        public string Description { get; set; }
        public bool State { get; set; }
        public DateTime CreationDate { get; set; } = DateTime.Now;

        public int AciliyetId { get; set; }
        public Aciliyet Aciliyet { get; set; }

        public int? AppUserId { get; set; }
        public AppUser AppUser { get; set; }
        public List<Rapor> Raporlar { get; set; }

    }
}
