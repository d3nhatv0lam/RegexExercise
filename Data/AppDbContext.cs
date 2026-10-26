using Microsoft.EntityFrameworkCore;
using RegexExercise.Models;

namespace RegexExercise.Data;

public sealed class AppDbContext: DbContext
{
    public DbSet<Staff> Staff => Set<Staff>();

    public AppDbContext()
    {
      
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        string dbPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "database.db");
        optionsBuilder.UseSqlite($"Data Source={dbPath}");

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
        
        
        
        modelBuilder.Entity<Staff>().HasData(
            new Staff
            {
                Id = 1,
                FullName = "Nguyễn Văn An",
                Email = "an.nguyen@gmail.com",
                PhoneNumber = "0912345678",
                StartWorkDay = new DateTime(2023, 1, 15),
                Photo = "avatar1.png"
            },
            new Staff
            {
                Id = 2,
                FullName = "Trần Thị B",
                Email = "bich.tran@gmail.com",
                PhoneNumber = "0987654321",
                StartWorkDay = new DateTime(2022, 5, 20),
                Photo = "avatar2.png"
            },
            new Staff
            {
                Id = 3,
                FullName = "Nguyễn Hoàng Khanh",
                Email = "KhanhCute@gmail.com",
                PhoneNumber = "0981054321",
                StartWorkDay = new DateTime(2022, 5, 1),
                Photo = "avatar3.png"
            },
            new Staff
            {
                Id = 4,
                FullName = "Trương Tam Phong",
                Email = "TamPhong@gmail.com",
                PhoneNumber = "0981011111",
                StartWorkDay = new DateTime(2023, 10, 1),
                Photo = "avatar5.png"
            }
        );
    }
}