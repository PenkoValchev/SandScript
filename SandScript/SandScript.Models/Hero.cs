namespace SandScript.Data.Models
{
    using System.ComponentModel.DataAnnotations;

    public class Hero
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        public int StatId { get; set; }

        public virtual Stat Stat { get; set; }

        public int InventoryId { get; set; }

        public virtual Inventory Inventory { get; set; }

        public int StoryId { get; set; }

        public virtual Story Story { get; set; }
    }
}
