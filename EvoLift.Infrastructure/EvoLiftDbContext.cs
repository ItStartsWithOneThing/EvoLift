using Microsoft.EntityFrameworkCore;

namespace EvoLift.Infrastructure
{
    public sealed class EvoLiftDbContext(
        DbContextOptions<EvoLiftDbContext> options) : DbContext(options)
    {
        // DbSet list

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Example of configuring an entity using Fluent API
            //modelBuilder.Entity<Product>(entity =>
            //{
            //    entity.HasKey(p => p.Id);

            //    entity.Property(p => p.Name)
            //        .IsRequired()
            //        .HasMaxLength(200);

            //    entity.Property(p => p.Price)
            //        .HasConversion<double>();
            //});
        }
    }
}
