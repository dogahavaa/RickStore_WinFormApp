namespace RickStock_WindowsFormApp.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<RickStock_WindowsFormApp.Models.RickStockDB>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(RickStock_WindowsFormApp.Models.RickStockDB context)
        {
            //context.Managers.AddOrUpdate(x => x.ID, new Models.Manager() { ID = 1, Name = "Doğa", Surname = "Hava", Email = "dev@dev.com", Username = "developer", Password = "1234", IsActive = true, IsDeleted = false });
        }
    }
}




