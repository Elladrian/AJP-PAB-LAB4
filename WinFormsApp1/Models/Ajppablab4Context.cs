using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace WinFormsApp1.Models;

public partial class Ajppablab4Context : DbContext
{
    public Ajppablab4Context()
    {
    }

    public Ajppablab4Context(DbContextOptions<Ajppablab4Context> options)
        : base(options)
    {
    }

    public virtual DbSet<KodyPocztowe> KodyPocztowes { get; set; }

    public virtual DbSet<Localization> Localizations { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=GORWPC0008\\SQLDEVELOPER;Database=AJPPABLAB4;User ID=Administrator;Password=cisco123!L;TrustServerCertificate=True;Encrypt=False");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<KodyPocztowe>(entity =>
        {
            entity.ToTable("Kody_Pocztowe");

            entity.Property(e => e.Adres).HasColumnType("text");
            entity.Property(e => e.KodPocztowy)
                .HasColumnType("text")
                .HasColumnName("Kod_pocztowy");
            entity.Property(e => e.Miejscowosc).HasColumnType("text");
            entity.Property(e => e.Powiat).HasColumnType("text");
            entity.Property(e => e.Uwagi)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.Wojewodztwo).HasColumnType("text");
        });

        modelBuilder.Entity<Localization>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Localiza__3214EC07A67ADA2D");

            entity.ToTable("Localization");

            entity.Property(e => e.Description)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.KodyPocztoweId).HasColumnName("Kody_PocztoweId");
            entity.Property(e => e.Name)
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.HasOne(d => d.KodyPocztowe).WithMany(p => p.Localizations)
                .HasForeignKey(d => d.KodyPocztoweId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Localizations_ToTable");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
