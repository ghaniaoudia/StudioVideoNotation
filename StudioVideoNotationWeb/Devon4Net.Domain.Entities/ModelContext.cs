using Microsoft.EntityFrameworkCore;
using Devon4Net.Domain.Context;
using Devon4Net.Domain.Entities.Models;

namespace Devon4Net.Domain.Entities
{
    public class ModelContext : Devon4NetBaseContext
    {

        public ModelContext(DbContextOptions<ModelContext> options) : base(options) { }
      

        public virtual DbSet<Client> Client { get; set; }
        public virtual DbSet<Notation> Notation { get; set; }
        public virtual DbSet<Prestation> Prestation { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=FRPARNETFACTTFS;Database=WebStudio;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Client>(entity =>
            {
                entity.HasKey(e => e.IdClient);

                entity.ToTable("CLIENT");

                entity.Property(e => e.IdClient).HasColumnName("ID_CLIENT");

                entity.Property(e => e.DateCreation)
                    .HasColumnName("DATE_CREATION")
                    .HasColumnType("date");

                entity.Property(e => e.DateModification)
                    .HasColumnName("DATE_MODIFICATION")
                    .HasColumnType("date");

                entity.Property(e => e.EmailClient)
                    .HasColumnName("EMAIL_CLIENT")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NomClient)
                    .IsRequired()
                    .HasColumnName("NOM_CLIENT")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PrenomClient)
                    .IsRequired()
                    .HasColumnName("PRENOM_CLIENT")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Notation>(entity =>
            {
                entity.HasKey(e => e.IdNotation);

                entity.ToTable("NOTATION");

                entity.Property(e => e.IdNotation).HasColumnName("ID_NOTATION");

                entity.Property(e => e.CommentaireNotation)
                    .HasColumnName("COMMENTAIRE_NOTATION")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.DateCreation)
                    .HasColumnName("DATE_CREATION")
                    .HasColumnType("date");

                entity.Property(e => e.DateModification)
                    .HasColumnName("DATE_MODIFICATION")
                    .HasColumnType("date");

                entity.Property(e => e.IdClient).HasColumnName("ID_CLIENT");

                entity.Property(e => e.IdPrestation).HasColumnName("ID_PRESTATION");

                entity.Property(e => e.Note).HasColumnName("NOTE");

                entity.HasOne(d => d.IdClientNavigation)
                    .WithMany(p => p.Notation)
                    .HasForeignKey(d => d.IdClient)
                    .HasConstraintName("FK__NOTATION__ID_CLI__47DBAE45");

                entity.HasOne(d => d.IdPrestationNavigation)
                    .WithMany(p => p.Notation)
                    .HasForeignKey(d => d.IdPrestation)
                    .HasConstraintName("FK__NOTATION__ID_PRE__46E78A0C");
            });

            modelBuilder.Entity<Prestation>(entity =>
            {
                entity.HasKey(e => e.IdPrestation);

                entity.ToTable("PRESTATION");

                entity.Property(e => e.IdPrestation).HasColumnName("ID_PRESTATION");

                entity.Property(e => e.Commentaire)
                    .HasColumnName("COMMENTAIRE")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DateCreation)
                    .HasColumnName("DATE_CREATION")
                    .HasColumnType("date");

                entity.Property(e => e.DateModification)
                    .HasColumnName("DATE_MODIFICATION")
                    .HasColumnType("date");

                entity.Property(e => e.DateSaisie)
                    .HasColumnName("DATE_SAISIE")
                    .HasColumnType("date");

                entity.Property(e => e.IdClient).HasColumnName("ID_CLIENT");

                entity.Property(e => e.TitrePrestation)
                    .IsRequired()
                    .HasColumnName("TITRE_PRESTATION")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdClientNavigation)
                    .WithMany(p => p.Prestation)
                    .HasForeignKey(d => d.IdClient)
                    .HasConstraintName("FK__PRESTATIO__ID_CL__440B1D61");
            });
        }
    }
}