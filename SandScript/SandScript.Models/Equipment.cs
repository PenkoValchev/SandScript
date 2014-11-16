namespace SandScript.Data.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class Equipment
    {
        public Equipment()
        {
            this.Items = new HashSet<Item>();
        }

        [Key]
        public int Id { get; set; }

        public int Weight { get; set; }

        public virtual ICollection<Item> Items { get; set; }
    }
}
