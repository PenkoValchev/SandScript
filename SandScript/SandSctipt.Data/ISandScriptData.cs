namespace SandSctipt.Data
{
    using SandScript.Data.Models;
    using SandSctipt.Data.Repositories;

    public interface ISandScriptData
    {
        ISandScriptDbContext Context { get; }

        IRepository<Story> Stories { get; }

        IRepository<User> Users { get; }

        IRepository<Stat> Stats { get; }

        IRepository<Potion> Potions { get; }

        IRepository<Mob> Mobs { get; }

        IRepository<ItemStat> ItemStats { get; }

        IRepository<Item> Items { get; }

        IRepository<Inventory> Inventories { get; }

        IRepository<Hero> Heroes { get; }

        IRepository<Equipment> Equipments { get; }

         IRepository<Episode> Episodes { get; }

        int SaveChanges();
    }
}
