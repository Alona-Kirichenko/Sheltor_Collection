using Microsoft.EntityFrameworkCore;
using ShelterCollection.Data;

namespace ShelterCollection.Data
{
    public class MyDbContext : DbContext
    {
        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options)
        {

        }

        public DbSet<Dog> Dog { get; set; }

    }
}