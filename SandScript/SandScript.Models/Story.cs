namespace SandScript.Data.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class Story
    {
        public Story()
        {
            this.Episodes = new HashSet<Episode>();
            this.Heroes = new HashSet<Hero>();
        }

        [Key]
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public string Description { get; set; }

        public string UserId { get; set; }
             
        public virtual User User { get; set; }

        public ICollection<Episode> Episodes { get; set; }

        public ICollection<Hero> Heroes { get; set; }
    }
}
