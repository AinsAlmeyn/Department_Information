using Microsoft.EntityFrameworkCore;

namespace Knowledge_Departman_Revize.Models
{
    public class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=Knowledge_Departman;Trusted_Connection=True;User Id=DESKTOP-UBHIB7K\\YILDIRAY;");
        }
        public DbSet<Birim> Birims { get; set; }
        public DbSet<Personel> Personels { get; set; }
        public DbSet<Admin> Admins { get; set; }
    }
}
