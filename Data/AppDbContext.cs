using Microsoft.EntityFrameworkCore;
using RegexExercise.Models;

namespace RegexExercise.Data;

public class AppDbContext: DbContext
{
    public DbSet<Staff> Staff => Set<Staff>();

    public AppDbContext()
    {
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("Data Source=database.db");

        base.OnConfiguring(optionsBuilder);
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<Staff>(entity =>
        {
            entity.ToTable("staff");

            entity.HasKey(s => s.Id);
            entity.Property(s => s.Id)
                .ValueGeneratedOnAdd();

            entity.Property(s => s.FullName)
                .IsRequired()
                .HasMaxLength(100);
            
            entity.Property(s => s.Email)
                .IsRequired()
                .HasMaxLength(150);
            entity.HasIndex(s => s.Email).IsUnique();
            
            entity.Property(s => s.PhoneNumber)
                .IsRequired()
                .HasMaxLength(10);
            entity.HasIndex(s => s.PhoneNumber).IsUnique();

            entity.Property(s => s.Photo)
                .HasMaxLength(255);

            entity.ToTable(t =>
            {
                t.HasCheckConstraint("CK_STAFF_ID_POSITIVE", "ID > 0");
            });
        });
    }
}