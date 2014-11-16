namespace SandScript.Data.Models
{
    using System.ComponentModel.DataAnnotations;

    public class Item
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public ItemType ItemType { get; set; }

        public int Weight { get; set; }

        public int ItemStatId { get; set; }

        public virtual ItemStat ItemStat { get; set; }
    }
}
