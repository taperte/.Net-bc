using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace NewsLogic.DB
{
    public partial class NewsDb : DbContext
    {
        public NewsDb()
        {
        }

        public NewsDb(DbContextOptions<NewsDb> options)
            : base(options)
        {
        }

        public virtual DbSet<Articles> Articles { get; set; }
        public virtual DbSet<Topics> Topics { get; set; }
        public virtual DbSet<Users> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\sl41040\\source\\NewsDB.mdf;Integrated Security=True;Connect Timeout=30");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Articles>(entity =>
            {
                entity.HasKey(e => e.ArticleId)
                    .HasName("PK__Articles__9C6270E8A79D1C84");

                entity.Property(e => e.Author)
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('The Daily Prophet editorial staff')");

                entity.Property(e => e.Body)
                    .IsRequired()
                    .HasMaxLength(2000);

                entity.Property(e => e.Headline)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.Image).HasMaxLength(1000);

                entity.Property(e => e.WhenAdded)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.Topic)
                    .WithMany(p => p.Articles)
                    .HasForeignKey(d => d.TopicId)
                    .HasConstraintName("FK__Articles__TopicI__25869641");
            });

            modelBuilder.Entity<Topics>(entity =>
            {
                entity.HasKey(e => e.TopicId)
                    .HasName("PK__Topics__022E0F5D0D2127F4");

                entity.Property(e => e.TopicName)
                    .IsRequired()
                    .HasMaxLength(20);
            });

            modelBuilder.Entity<Users>(entity =>
            {
                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Username)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
