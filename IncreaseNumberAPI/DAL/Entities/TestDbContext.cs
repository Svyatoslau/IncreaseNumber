using Microsoft.EntityFrameworkCore;

namespace IncreaseNumberAPI.DAL.Entities;

public partial class TestDbContext : DbContext
{
    public virtual DbSet<Counter> Counters { get; set; }

    public TestDbContext(DbContextOptions<TestDbContext> options)
        : base(options) { }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Counter>(entity =>
        {
            entity.ToTable("Counter");
            entity.Property(e => e.LastChange).HasColumnType("datetime");
            entity.Property(e => e.PickedDate).HasColumnType("datetime");
        });
        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);

}
