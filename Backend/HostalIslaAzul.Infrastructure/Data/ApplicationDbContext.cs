using System.Reflection;
using HostalIslaAzul.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace HostalIslaAzul.Infrastructure.Data;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) 
        : base(options) {}

    public DbSet<Client> Clients { get; set; }
    public DbSet<Room> Rooms { get; set; }
    public DbSet<Reserve> Reserves { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
    }
}