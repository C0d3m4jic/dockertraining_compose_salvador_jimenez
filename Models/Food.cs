using System.ComponentModel.DataAnnotations;

namespace dockertraining_compose_salvador_jimenez.Models
{
    public class Food
    {
        [Required]
        public int Id { get; set; }
        [Required]
        [StringLength(30)]
        public string Name { get; set; }

    }
}
