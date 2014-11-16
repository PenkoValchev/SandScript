namespace SandScript.Data.Models
{
    using System.ComponentModel.DataAnnotations;

    public class Stat
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int Strenght { get; set; }

        [Required]
        public int Stamina { get; set; }

        [Required]
        public int Health { get; set; }

        [Required]
        public int Mana { get; set; }

        [Required]
        public int Dexterity { get; set; }
    }
}
