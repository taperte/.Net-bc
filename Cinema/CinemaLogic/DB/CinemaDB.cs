using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace CinemaLogic.DB
{
    public partial class CinemaDB : DbContext
    {
        public CinemaDB()
        {
        }

        public CinemaDB(DbContextOptions<CinemaDB> options)
            : base(options)
        {
        }

        public virtual DbSet<Bookings> Bookings { get; set; }
        public virtual DbSet<Genres> Genres { get; set; }
        public virtual DbSet<Movies> Movies { get; set; }
        public virtual DbSet<Seats> Seats { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\sl41040\\source\\CinemaDB.mdf;Integrated Security=True;Connect Timeout=30");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Bookings>(entity =>
            {
                entity.Property(e => e.BookedTime).HasColumnType("datetime");

                entity.Property(e => e.TotalPrice).HasColumnType("decimal(8, 2)");

                entity.HasOne(d => d.Movie)
                    .WithMany(p => p.Bookings)
                    .HasForeignKey(d => d.MovieId)
                    .HasConstraintName("FK__Bookings__MovieI__286302EC");

                entity.HasOne(d => d.Seat)
                    .WithMany(p => p.Bookings)
                    .HasForeignKey(d => d.SeatId)
                    .HasConstraintName("FK__Bookings__SeatTy__36B12243");
            });

            modelBuilder.Entity<Genres>(entity =>
            {
                entity.Property(e => e.Genre)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<Movies>(entity =>
            {
                entity.Property(e => e.Abstract).HasMaxLength(2000);

                entity.Property(e => e.Country).HasMaxLength(255);

                entity.Property(e => e.Director)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Price).HasColumnType("decimal(4, 2)");

                entity.Property(e => e.ScreeningTime1).HasColumnType("datetime");

                entity.Property(e => e.ScreeningTime2).HasColumnType("datetime");

                entity.Property(e => e.ScreeningTime3).HasColumnType("datetime");

                entity.Property(e => e.ScreeningTime4).HasColumnType("datetime");

                entity.Property(e => e.ScreeningTime5).HasColumnType("datetime");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Trailer).HasMaxLength(1000);

                entity.HasOne(d => d.Genre)
                    .WithMany(p => p.Movies)
                    .HasForeignKey(d => d.GenreId)
                    .HasConstraintName("FK__Movies__GenreId__25869641");
            });

            modelBuilder.Entity<Seats>(entity =>
            {
                entity.Property(e => e.Coefficient).HasColumnType("decimal(4, 2)");

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasMaxLength(20);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
