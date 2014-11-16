using SandScript.Data.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SandSctipt.Data
{
    public interface ISandScriptDbContext
    {
        IDbSet<Hero> Heroes { get; set; }

        IDbSet<Story> Stories { get; set; }

        IDbSet<Stat> Stats { get; set; }

        IDbSet<Potion> Potions { get; set; }

        IDbSet<Mob> Mobs { get; set; }

        IDbSet<ItemStat> ItemStats { get; set; }

        IDbSet<Item> Items { get; set; }

        IDbSet<Inventory> Inventories { get; set; }

        IDbSet<Equipment> Equipments { get; set; }

        IDbSet<Episode> Episodes { get; set; }

        DbContext DbContext { get; }

        int SaveChanges();

        DbEntityEntry<TEntity> Entry<TEntity>(TEntity entity) where TEntity : class;

        IDbSet<T> Set<T>() where T : class;
    }
}
