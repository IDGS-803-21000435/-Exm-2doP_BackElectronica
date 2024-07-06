using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace BackElectronicos.Models;

public partial class TiendaElectronicaContext : DbContext
{
    public TiendaElectronicaContext()
    {
    }

    public TiendaElectronicaContext(DbContextOptions<TiendaElectronicaContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Producto> Productos { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) { }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Producto>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Producto__3214EC0706E1DFE8");
            entity.ToTable("Productos");

            entity.Property(e => e.Id).HasColumnName("id");

            entity.Property(e => e.Descripcion).HasMaxLength(255);
            entity.Property(e => e.Nombre).HasMaxLength(100);
            entity.Property(e => e.Precio).HasColumnType("decimal(10, 2)");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
