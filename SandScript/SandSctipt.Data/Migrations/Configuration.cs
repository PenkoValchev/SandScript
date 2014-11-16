namespace SandSctipt.Data.Migrations
{
    using System.Data.Entity.Migrations;
    using SandScript.Data.Models;
    using SandSript.Data.Common;
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;

    internal sealed class Configuration : DbMigrationsConfiguration<SandScriptDbContext>
    {
        private RandomDataGenerator random;
        private UserManager<User> userManager;

        public Configuration()
        {
            this.AutomaticMigrationsEnabled = true;
            this.AutomaticMigrationDataLossAllowed = true;
            random = new RandomDataGenerator();
        }

        protected override void Seed(SandScriptDbContext context)
        {
            this.userManager = new UserManager<User>(new UserStore<User>(context));
            this.SeedUsers(context);
            this.SeedPotions(context);

        }

        public   void SeedPotions(SandScriptDbContext context)
        {
            for (int i = 0; i < 10; i++)
            {
                var potion = new Potion()
                {
                    Description = "Potionka"+i.ToString(),
                    BonusToMana = 10,
                    BonusToHealth = 10
                };
                context.Potions.Add(potion);
            }
            
            context.SaveChanges();
        }

        public void SeedUsers(SandScriptDbContext context)
        {
            for (int i = 0; i < 10; i++)
            {
                var user = new User()
                {
                    Email = string.Format("{0}@{1}.com", this.random.GetRandomStrigWithRandomLen(5, 9), this.random.GetRandomStrigWithRandomLen(5, 9)),
                    UserName = this.random.GetRandomString(8)
                };

                this.userManager.Create(user, "123456");
               
            }
            var adminUser = new User
            {
                Email = "admin@mysite.com",
                UserName = "Administrator"
            };

            this.userManager.Create(adminUser, "admin123456");
                     
        }

    }
}
