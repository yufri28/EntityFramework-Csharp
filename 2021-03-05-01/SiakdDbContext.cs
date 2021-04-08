using _2021_03_05_01.Entities;
using System.Data.Entity;

namespace _2021_03_05_01
{
    public class SiakdDbContext : DbContext
    {
        public SiakdDbContext() : base("KoneksiSaya")
        {
        }

        public DbSet<Mahasiswa> TableMahasiswa { get; set; }
        public DbSet<Nilai> TableNilai{ get; set; }
        public DbSet<Semester> TableSemester { get; set; }
        public DbSet<MataKuliah> TableMataKuliah { get; set; }
    }
}