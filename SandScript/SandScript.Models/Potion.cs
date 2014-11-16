namespace SandScript.Data.Models
{
    using System.ComponentModel.DataAnnotations;

    public class Potion
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Description { get; set; }

        public int BonusToHealth { get; set; }

        public int BonusToMana { get; set; }
    }
}
