using Microsoft.EntityFrameworkCore;
using Test.Library.Domain.Entities;

namespace Test.Library.Infrastructure.Persistence;

public partial class DbLibraryContext : DbContext
{
    public DbLibraryContext()
    {
    }

    public DbLibraryContext(DbContextOptions<DbLibraryContext> options)
        : base(options)
    {
    }

    public virtual DbSet<UsuarioEntity> Usuarios { get; set; }
    public virtual DbSet<LibroEntity> Libros { get; set; }
    public virtual DbSet<ClienteEntity> Clientes { get; set; }
    public virtual DbSet<PrestamoEntity> Prestamos { get; set; }
    public virtual DbSet<DetPrestamoEntity> DetPrestamos { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<UsuarioEntity>(entity =>
        {
            entity.HasKey(e => e.Id);

            entity.ToTable("TbUsuario");

            entity.Property(e => e.FechaReg)
                .HasDefaultValueSql("(getdate())");
        });

        modelBuilder.Entity<LibroEntity>(entity =>
        {
            entity.HasKey(e => e.Id);

            entity.ToTable("TbLibro");

            entity.Property(e => e.FechaReg)
                .HasDefaultValueSql("(getdate())");
        });

        modelBuilder.Entity<ClienteEntity>(entity =>
        {
            entity.HasKey(e => e.Id);

            entity.ToTable("TbCliente");

            entity.Property(e => e.FechaReg)
                .HasDefaultValueSql("(getdate())");
        });

        modelBuilder.Entity<PrestamoEntity>(entity =>
        {
            entity.ToTable("TbPrestamo");

            entity.HasKey(e => e.Id);

            entity.Property(e => e.FechaReg)
                .HasDefaultValueSql("GETDATE()");

            entity.HasOne(e => e.Cliente)
                .WithMany()
                .HasForeignKey(e => e.IdCliente)
                .OnDelete(DeleteBehavior.Restrict);
        });

        modelBuilder.Entity<DetPrestamoEntity>(entity =>
        {
            entity.ToTable("DetPrestamo");

            entity.HasKey(e => new { e.IdPrestamo, e.IdLibro });

            entity.HasOne(e => e.Prestamo)
                .WithMany(p => p.Detalle)
                .HasForeignKey(e => e.IdPrestamo)
                .OnDelete(DeleteBehavior.Cascade);

            entity.HasOne(e => e.Libro)
                .WithMany()
                .HasForeignKey(e => e.IdLibro)
                .OnDelete(DeleteBehavior.Restrict);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
