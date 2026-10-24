
using Microsoft.EntityFrameworkCore;
using PolyLearnAI.Api.Models;
using System.Reflection.Emit;

namespace PolyLearnAI.Api.Data;

public class PolyLearnDbContext : DbContext
{
    public PolyLearnDbContext(
        DbContextOptions<PolyLearnDbContext> options
    ) : base(options)
    {
    }

    public DbSet<Language> Languages => Set<Language>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Language>(entity =>
        {
            entity.ToTable("Languages", "dbo");

            entity.HasKey(e => e.LanguageID);

            entity.Property(e => e.LanguageCode)
                  .HasMaxLength(10)
                  .IsRequired();

            entity.Property(e => e.LanguageName)
                  .HasMaxLength(100)
                  .IsRequired();
        });
    }
}
