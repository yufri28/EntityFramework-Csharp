namespace _2021_03_05_01.Migrations
{
    using System.Data.Entity.Migrations;

    internal sealed class Configuration : DbMigrationsConfiguration<SiakdDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(SiakdDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.

            //Mahasiswa yanti = new Mahasiswa { Nim = "1902030408", Nama = "Yanti", Jk = false, Angkatan = 2019 };

            //context.Mahasiswa.Add(yanti);
        }
    }
}