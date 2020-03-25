using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace NBA_MVC_website.Models
{
    public partial class NbaDbContext : DbContext
    {
        public NbaDbContext()
        {
        }

        public NbaDbContext(DbContextOptions<NbaDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Player> Player { get; set; }
        public virtual DbSet<Team> Team { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=NbaDb");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Player>(entity =>
            {
                entity.Property(e => e.AllStarGames)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.FirstName)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.LastName)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.PhotoLink)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.PlayerPointsScored)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Position)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.VideoLink)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.HasOne(d => d.Team)
                    .WithMany(p => p.Player)
                    .HasForeignKey(d => d.TeamId)
                    .HasConstraintName("FK__Player__TeamId__25869641");
            });

            modelBuilder.Entity<Team>(entity =>
            {
                entity.Property(e => e.TeamChampionships)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.TeamConference)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.TeamFinaslAppearances)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.TeamName)
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
