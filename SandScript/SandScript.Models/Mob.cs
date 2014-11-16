namespace SandScript.Data.Models
{
    using System.ComponentModel.DataAnnotations;

    public class Mob
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string  Description { get; set; }

        public int Score { get; set; }

        public int InventoryId { get; set; }

        public virtual Inventory Inventory { get; set; }
    }
}
