using System.ComponentModel.DataAnnotations;

namespace Projeto.Models
{
    public class Pessoas
    {
        [Key]
        public Guid Id { get; set; }
        [Required]
        [MaxLength(100)]
        public string Nome { get; set; }

        public void GenerateId()
        {
            Id = Guid.NewGuid();
        }
    }
}