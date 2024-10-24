using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace ItemPortel.Models;

public partial class TrainingDBContext : DbContext
{
    public TrainingDBContext()
    {
    }

    public TrainingDBContext(DbContextOptions<TrainingDBContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Item> Items { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=sg-sqlserver.database.windows.net;Initial Catalog=sgazuredatabase;Persist Security Info=False;User ID=sgadmin;Password=softwaregurukulam@123;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Item>(entity =>
        {
            entity.Property(e => e.ItemId).ValueGeneratedOnAdd();
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
