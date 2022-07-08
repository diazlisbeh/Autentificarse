using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Autentificarse.Models
{
    public partial class AUTENTICARContext : DbContext
    {
        public AUTENTICARContext()
        {
        }

        public AUTENTICARContext(DbContextOptions<AUTENTICARContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Autentic> Autentics { get; set; } = null!;
        public virtual DbSet<TypeLogin> TypeLogins { get; set; } = null!;
        public virtual DbSet<Usuario> Usuarios { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=DESKTOP-43DVFJ7\\SQLEXPRESS; Database=AUTENTICAR; Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Autentic>(entity =>
            {
                entity.ToTable("Autentic");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Validador)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("validador");

                entity.HasOne(d => d.IdTypeNavigation)
                    .WithMany(p => p.Autentics)
                    .HasForeignKey(d => d.IdType)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_IdLogin");
            });

            modelBuilder.Entity<TypeLogin>(entity =>
            {
                entity.ToTable("TypeLogin");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.TypeLogin1)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("TypeLogin");

                entity.HasOne(d => d.IdUserNavigation)
                    .WithMany(p => p.TypeLogins)
                    .HasForeignKey(d => d.IdUser)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_IduEe");
            });

            modelBuilder.Entity<Usuario>(entity =>
            {
                entity.ToTable("usuario");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Apellido)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Clave)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Nombre)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Rool)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Usuario1)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("Usuario");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
