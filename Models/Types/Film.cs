using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication1.Models
{
    [Table("Films")]
    [Index("Id")]
    public class Film
    {
        [ForeignKey("Id")]
        public int Id { get; set; }
        public byte[] Image { get; set; }
        [Required]
        [MinLength(3),MaxLength(255)]
        public string Name { get; set; }
        public string Description { get; set; }
        public List<string> Tags { get; set; }
    }
}
