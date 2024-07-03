using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace EFcorefirstTask
{
    public class Datacontext : DbContext
    {
        public DbSet<Genre> Genre { get; set; }
        public DbSet<Book> Books { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-N5N9E4H\\SQLEXPRESS;Database=EFcorefirstTask;Trusted_Connection=True;TrustServerCertificate=True");
            base.OnConfiguring(optionsBuilder);
        }
    }
}
