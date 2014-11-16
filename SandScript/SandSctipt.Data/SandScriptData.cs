namespace SandSctipt.Data
{
    using SandScript.Data.Models;
    using SandSctipt.Data.Repositories;
    using System;
    using System.Collections.Generic;
    public class SandScriptData:ISandScriptData
    {
        private readonly ISandScriptDbContext context;

        private readonly Dictionary<Type, object> repositories = new Dictionary<Type,object>();

        public SandScriptData(ISandScriptDbContext context)
        {
            this.context = context;
        }

        public ISandScriptDbContext Context 
        { 
            get 
            { 
                return this.context; 
            } 
        }
     
        public IRepository<Story> Stories
        {
            get { return this.GetRepository<Story>(); }
        }

        public IRepository<User> Users
        {
            get { return this.GetRepository<User>(); }
        }

        public IRepository<Stat> Stats
        {
            get { return this.GetRepository<Stat>(); }
        }

        public IRepository<Potion> Potions
        {
            get { return this.GetRepository<Potion>(); }
        }

        public IRepository<Mob> Mobs
        {
            get { return this.GetRepository<Mob>(); }
        }

        public IRepository<ItemStat> ItemStats
        {
            get { return this.GetRepository<ItemStat>(); }
        }

        public IRepository<Item> Items
        {
            get { return this.GetRepository<Item>(); }
        }

        public IRepository<Inventory> Inventories
        {
            get { return this.GetRepository<Inventory>(); }
        }

        public IRepository<Hero> Heroes
        {
            get { return this.GetRepository<Hero>(); }
        }

        public IRepository<Equipment> Equipments
        {
            get { return this.GetRepository<Equipment>(); }
        }

        public IRepository<Episode> Episodes
        {
            get { return this.GetRepository<Episode>(); }
        }

        public int SaveChanges()
        {
            return this.context.SaveChanges();
        }

        private IRepository<T> GetRepository<T>() where T :class
        {
            if (!this.repositories.ContainsKey(typeof(T)))
            {
                var type = typeof(GenericRepository<T>);
                this.repositories.Add(typeof(T), Activator.CreateInstance(type, this.context));
            }

            return (IRepository<T>)this.repositories[typeof(T)];
        }
    }
}
