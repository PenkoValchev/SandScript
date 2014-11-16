namespace SandSctipt.Data
{
    using Microsoft.AspNet.Identity.EntityFramework;
    using System.Data.Entity;
    using SandScript.Data.Models;
    using SandSctipt.Data.Migrations;
      
    public class SandScriptDbContext : IdentityDbContext<User>,ISandScriptDbContext
    {
        public SandScriptDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<SandScriptDbContext, Configuration>());
        }

        public static SandScriptDbContext Create()
        {
            return new SandScriptDbContext();
        }

        public virtual IDbSet<Hero> Heroes { get; set;}

        public virtual IDbSet<Story> Stories { get; set; }

        public virtual IDbSet<Stat> Stats { get; set;}

        public virtual IDbSet<Potion> Potions {get; set; }

        public  virtual IDbSet<Mob> Mobs{ get; set; }

        public virtual IDbSet<ItemStat> ItemStats { get; set; }

        public virtual IDbSet<Item> Items { get; set; }

        public virtual IDbSet<Inventory> Inventories { get; set; }

        public virtual IDbSet<Equipment> Equipments { get; set; }

        public virtual IDbSet<Episode> Episodes { get; set; }

        public DbContext DbContext
        {
            get { return this; }
        }

        public override int SaveChanges()
        {
            return base.SaveChanges();
        }

        public new IDbSet<T> Set<T>() where T : class
        {
            return base.Set<T>();
        }
    }
}
