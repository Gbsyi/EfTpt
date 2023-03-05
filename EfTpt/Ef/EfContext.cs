using EfTpt.Ef.Models;
using Microsoft.EntityFrameworkCore;

namespace EfTpt.Ef;

public class EfContext : DbContext
{
    public required DbSet<Transport> Transports { get; set; }
    public required DbSet<Car> Cars { get; set; }

    public EfContext(DbContextOptions<EfContext> options)
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Transport>(e =>
        {
            e.HasKey(x => x.Id);
            e.UseTptMappingStrategy();
        });

        modelBuilder.Entity<Car>(e =>
        {
            e.OwnsOne(x => x.Speed, bld =>
            {
                bld.Property(x => x.Value)
                    .HasColumnName("speed");
            });
        });
    }
}