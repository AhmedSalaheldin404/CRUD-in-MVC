using Microsoft.EntityFrameworkCore;
using mvctask1.Models;

namespace mvctask1.Data
{
    public class ITIdata:DbContext
    {
      public  DbSet<Student> Students { get; set; }
      public  DbSet<Department> Departments { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=AHMEDSALAH;Database=mydb1;integrated security=true;Trusted_Connection=True;TrustServerCertificate=True;");
            base.OnConfiguring(optionsBuilder);
        }

    }
}
