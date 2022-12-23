using Domain.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace Domain.Data.Data
{
    public class DomainDbContext:DbContext
    {
        public DbSet<Supplier> Suppliers { get; set; }

        public DomainDbContext(DbContextOptions<DomainDbContext> options) : base(options)
        {
        
        }

    }
}
