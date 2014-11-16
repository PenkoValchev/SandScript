namespace SandScript.Data.Models
{
    using System.ComponentModel.DataAnnotations;

    public class ItemStat
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int Attack { get; set; }

        [Required]
        public int Defence { get; set; }

        public int BonusToHealth { get; set; }

        public int BonusToStamina { get; set; }

        public int BonusToDexterity { get; set; }

        public int BonusToStrenght { get; set; }
    }
}
