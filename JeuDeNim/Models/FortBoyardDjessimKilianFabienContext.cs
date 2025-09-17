using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace JeuDeNim.Models;

public partial class FortBoyardDjessimKilianFabienContext : DbContext
{
    public FortBoyardDjessimKilianFabienContext()
    {
    }

    public FortBoyardDjessimKilianFabienContext(DbContextOptions<FortBoyardDjessimKilianFabienContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Partie> Parties { get; set; }

    public virtual DbSet<Tour> Tours { get; set; }

    public virtual DbSet<Utilisateur> Utilisateurs { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("SERVER=2a03:5840:111:1024:508f:fc67:4795:f4d3; User ID=sa;Password=erty64%;Database=FortBoyardDjessimKilianFabien; TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Partie>(entity =>
        {
            entity.HasKey(e => e.IdPartie).HasName("PK__Partie__EE3714C59C68E182");

            entity.ToTable("Partie");

            entity.HasIndex(e => e.CodePartie, "UQ__Partie__4BCF45E06C2AFF45").IsUnique();

            entity.Property(e => e.IdPartie).HasColumnName("idPartie");
            entity.Property(e => e.CodePartie)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("codePartie");
            entity.Property(e => e.DateCreation).HasColumnName("dateCreation");
            entity.Property(e => e.EstJoueur1).HasColumnName("estJoueur1");
            entity.Property(e => e.EstTerminee).HasColumnName("estTerminee");
            entity.Property(e => e.IdJoueur1).HasColumnName("idJoueur1");
            entity.Property(e => e.IdJoueur2).HasColumnName("idJoueur2");
            entity.Property(e => e.IdVainqueur).HasColumnName("idVainqueur");
            entity.Property(e => e.NbBatonnetsEnCours).HasColumnName("nbBatonnetsEnCours");
            entity.Property(e => e.NbBatonnetsTotal).HasColumnName("nbBatonnetsTotal");
            entity.Property(e => e.NbJoueur).HasColumnName("nbJoueur");

            entity.HasOne(d => d.IdJoueur1Navigation).WithMany(p => p.PartieIdJoueur1Navigations)
                .HasForeignKey(d => d.IdJoueur1)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Partie__idJoueur__29572725");

            entity.HasOne(d => d.IdJoueur2Navigation).WithMany(p => p.PartieIdJoueur2Navigations)
                .HasForeignKey(d => d.IdJoueur2)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Partie__idJoueur__2A4B4B5E");

            entity.HasOne(d => d.IdVainqueurNavigation).WithMany(p => p.PartieIdVainqueurNavigations)
                .HasForeignKey(d => d.IdVainqueur)
                .HasConstraintName("FK__Partie__idVainqu__286302EC");
        });

        modelBuilder.Entity<Tour>(entity =>
        {
            entity.HasKey(e => e.IdTour).HasName("PK__Tour__BF447DACE38F6A30");

            entity.ToTable("Tour");

            entity.Property(e => e.IdTour).HasColumnName("idTour");
            entity.Property(e => e.IdJoueur).HasColumnName("idJoueur");
            entity.Property(e => e.IdPartie).HasColumnName("idPartie");
            entity.Property(e => e.NbBatonnetsRetires).HasColumnName("nbBatonnetsRetires");

            entity.HasOne(d => d.IdJoueurNavigation).WithMany(p => p.Tours)
                .HasForeignKey(d => d.IdJoueur)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Tour__idJoueur__2D27B809");

            entity.HasOne(d => d.IdPartieNavigation).WithMany(p => p.Tours)
                .HasForeignKey(d => d.IdPartie)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Tour__idPartie__2E1BDC42");
        });

        modelBuilder.Entity<Utilisateur>(entity =>
        {
            entity.HasKey(e => e.IdJoueur).HasName("PK__Utilisat__64E2661B095669C1");

            entity.ToTable("Utilisateur");

            entity.HasIndex(e => e.Pseudo, "UQ__Utilisat__EA0EEA224713BA0B").IsUnique();

            entity.Property(e => e.IdJoueur).HasColumnName("idJoueur");
            entity.Property(e => e.DateCreation).HasColumnName("dateCreation");
            entity.Property(e => e.Mdp)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("mdp");
            entity.Property(e => e.NbVictoire).HasColumnName("nbVictoire");
            entity.Property(e => e.Nom)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("nom");
            entity.Property(e => e.Prenom)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("prenom");
            entity.Property(e => e.Pseudo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("pseudo");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
