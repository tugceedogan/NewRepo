using Proje.ToDo.Entities.Interfaces;
using System;
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
        public string Ad { get; set; }
        [Column(TypeName="ntext")]
        public string Description { get; set; }
        public DateTime CreationDate { get; set; }
        [ForeignKey("Kullanici")]
        public int UserId { get; set; }
        public User User { get; set; }
    }
}
