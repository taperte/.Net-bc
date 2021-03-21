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

        public virtual DbSet<AuditoriumSeats> AuditoriumSeats { get; set; }
        public virtual DbSet<Auditoriums> Auditoriums { get; set; }
        public virtual DbSet<AvailableSeats> AvailableSeats { get; set; }
        public virtual DbSet<Bookings> Bookings { get; set; }
        public virtual DbSet<Genres> Genres { get; set; }
        public virtual DbSet<MovieGenres> MovieGenres { get; set; }
        public virtual DbSet<Movies> Movies { get; set; }
        public virtual DbSet<Screenings> Screenings { get; set; }
        public virtual DbSet<Seats> Seats { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\sl41040\\source\\CinemaDB.mdf;Integrated Security=True;MultipleActiveResultSets=true;Connect Timeout=30");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AuditoriumSeats>(entity =>
            {
                entity.HasOne(d => d.Auditorium)
                    .WithMany(p => p.AuditoriumSeats)
                    .HasForeignKey(d => d.AuditoriumId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Auditoriu__Audit__49C3F6B7");

                entity.HasOne(d => d.Seat)
                    .WithMany(p => p.AuditoriumSeats)
                    .HasForeignKey(d => d.SeatId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Auditoriu__SeatI__4AB81AF0");
            });

            modelBuilder.Entity<Auditoriums>(entity =>
            {
                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<AvailableSeats>(entity =>
            {
                entity.Property(e => e.Type).HasMaxLength(20);

                entity.HasOne(d => d.AuditoriumSeats)
                    .WithMany(p => p.AvailableSeats)
                    .HasForeignKey(d => d.AuditoriumSeatsId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Screening__Audit__5AEE82B9");

                entity.HasOne(d => d.Screening)
                    .WithMany(p => p.AvailableSeats)
                    .HasForeignKey(d => d.ScreeningId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Screening__Scree__4D94879B");
            });

            modelBuilder.Entity<Bookings>(entity =>
            {
                entity.Property(e => e.TotalPrice).HasColumnType("decimal(8, 2)");

                entity.HasOne(d => d.AvailableSeats)
                    .WithMany(p => p.Bookings)
                    .HasForeignKey(d => d.AvailableSeatsId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Bookings__SeatsI__5CD6CB2B");
            });

            modelBuilder.Entity<Genres>(entity =>
            {
                entity.Property(e => e.Genre)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<MovieGenres>(entity =>
            {
                entity.HasOne(d => d.Genre)
                    .WithMany(p => p.MovieGenres)
                    .HasForeignKey(d => d.GenreId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__MovieGenr__Genre__52593CB8");

                entity.HasOne(d => d.Movie)
                    .WithMany(p => p.MovieGenres)
                    .HasForeignKey(d => d.MovieId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__MovieGenr__Movie__5165187F");
            });

            modelBuilder.Entity<Movies>(entity =>
            {
                entity.Property(e => e.Abstract).HasMaxLength(2000);

                entity.Property(e => e.Country).HasMaxLength(255);

                entity.Property(e => e.Director)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.OriginalTitle).HasMaxLength(100);

                entity.Property(e => e.Poster).HasMaxLength(500);

                entity.Property(e => e.Price).HasColumnType("decimal(4, 2)");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Trailer).HasMaxLength(1000);

                entity.HasOne(d => d.Auditorium)
                    .WithMany(p => p.Movies)
                    .HasForeignKey(d => d.AuditoriumId)
                    .HasConstraintName("FK__Movies__Auditori__398D8EEE");

                entity.HasOne(d => d.Genre)
                    .WithMany(p => p.Movies)
                    .HasForeignKey(d => d.GenreId)
                    .HasConstraintName("FK__Movies__GenreId__25869641");
            });

            modelBuilder.Entity<Screenings>(entity =>
            {
                entity.Property(e => e.Time).HasColumnType("datetime");

                entity.HasOne(d => d.Movie)
                    .WithMany(p => p.Screenings)
                    .HasForeignKey(d => d.MovieId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Screening__Movie__3D5E1FD2");
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
