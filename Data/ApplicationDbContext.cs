using Microsoft.EntityFrameworkCore;
using TPUSJ.Models;

namespace TPUSJ.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

            public DbSet<Blog> Blogs { get; set; }

            public DbSet<Product> Products { get; set; }

        public DbSet<Item> Items { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Blog>().HasData(
                new Blog { Id = 1, Name = "Blog 1", Content="First Blog" },
                new Blog { Id = 2, Name = "Blog 2", Content = "second Blog" }

                );
        }
    }

}
