using Microsoft.EntityFrameworkCore;
using PackIT.Domain.Entities;

namespace PackIT.Infrastructure.EF.Contexts;

internal class WriteDbContext : DbContext
{
    public DbSet<PackingList> PackingLists { get; set; }

    public WriteDbContext(DbContextOptions<WriteDbContext> options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.HasDefaultSchema("packing");
        base.OnModelCreating(modelBuilder);
    }
}