using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using PARCIAL._19100520.DOMAIN.Core.Entities;

namespace PARCIAL._19100520.DOMAIN.Infrastructure.Data;

public partial class Parcial202402CodigoDbContext : DbContext
{
    public Parcial202402CodigoDbContext()
    {
    }

    public Parcial202402CodigoDbContext(DbContextOptions<Parcial202402CodigoDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Mechanic> Mechanic { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=DESKTOP-H53CK36\\SQLEXPRESS;Database=Parcial202402CodigoDB;Integrated Security=true;TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Mechanic>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Mechanic__3214EC07E7C24A06");

            entity.Property(e => e.Email).HasMaxLength(100);
            entity.Property(e => e.FirstName).HasMaxLength(50);
            entity.Property(e => e.LastName).HasMaxLength(50);
            entity.Property(e => e.PhoneNumber).HasMaxLength(15);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
