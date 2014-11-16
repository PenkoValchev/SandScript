namespace SandScript.Data.Models
{
    using System.ComponentModel.DataAnnotations;

    public class Episode
    { 
        [Key]
        public int Id { get; set; }

        [Required]
        public int EpisodeNumber { get; set; }

        [Required]
        public string Content { get; set; }

        public int StoryId { get; set; }

        public virtual Story Story { get; set; }

        public int MobId { get; set; }

        public virtual Mob Mob { get; set; }
    }
}
