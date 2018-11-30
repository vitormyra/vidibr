using System.ComponentModel.DataAnnotations;

namespace vidibr.Models
{
    public class Cliente
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(255)]
        public string Nome { get; set; }
        public int Idade { get; set; }
    }
}