using BlazorApp1.Model;
using Microsoft.EntityFrameworkCore;

namespace BlazorApp1.Data
{
    public class MyDBContext : DbContext

    {
        public MyDBContext(DbContextOptions<MyDBContext> options) : base(options) { }

        public DbSet<User> Users { get; set; }
        public DbSet<Article> Article { get; set; }
    }
}
