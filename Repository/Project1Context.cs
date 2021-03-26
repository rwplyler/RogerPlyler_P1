using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Models;

#nullable disable

namespace Repository
{
    public partial class Project1Context : DbContext
    {
        public Project1Context()
        {
        }

        public Project1Context(DbContextOptions<Project1Context> options)
            : base(options)
        {
        }

        public virtual DbSet<Acustomer> Acustomers { get; set; }
        public virtual DbSet<AnItem> AnItems { get; set; }
        public virtual DbSet<Aorder> Aorders { get; set; }
        public virtual DbSet<AorderDetail> AorderDetails { get; set; }
        public virtual DbSet<Astore> Astores { get; set; }
        public virtual DbSet<InventoryDetail> InventoryDetails { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=.\\SQLEXPRESS;Database=Project1;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Acustomer>(entity =>
            {
                entity.ToTable("ACustomer");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Fname)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("FName");

                entity.Property(e => e.Lname)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("LName");
            });

            modelBuilder.Entity<AnItem>(entity =>
            {
                entity.ToTable("AnItem");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.ItemName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Price).HasColumnType("decimal(10, 2)");
            });

            modelBuilder.Entity<Aorder>(entity =>
            {
                entity.HasKey(e => e.OrderId)
                    .HasName("PK__AOrder__C3905BAF92D3F0DC");

                entity.ToTable("AOrder");

                entity.Property(e => e.OrderId)
                    .ValueGeneratedNever()
                    .HasColumnName("OrderID");

                entity.Property(e => e.CustomerId).HasColumnName("CustomerID");

                entity.Property(e => e.OrderTime).HasColumnType("datetime");

                entity.Property(e => e.StoreId).HasColumnName("StoreID");

                entity.Property(e => e.Total).HasColumnType("decimal(10, 2)");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.Aorders)
                    .HasForeignKey(d => d.CustomerId)
                    .HasConstraintName("FK__AOrder__Customer__1920BF5C");

                entity.HasOne(d => d.Store)
                    .WithMany(p => p.Aorders)
                    .HasForeignKey(d => d.StoreId)
                    .HasConstraintName("FK__AOrder__StoreID__1A14E395");
            });

            modelBuilder.Entity<AorderDetail>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("AOrderDetail");

                entity.Property(e => e.ItemId).HasColumnName("ItemID");

                entity.Property(e => e.OrderId).HasColumnName("OrderID");

                entity.Property(e => e.Total).HasColumnType("decimal(10, 2)");

                entity.HasOne(d => d.Item)
                    .WithMany()
                    .HasForeignKey(d => d.ItemId)
                    .HasConstraintName("FK__AOrderDet__ItemI__1CF15040");

                entity.HasOne(d => d.Order)
                    .WithMany()
                    .HasForeignKey(d => d.OrderId)
                    .HasConstraintName("FK__AOrderDet__Order__1BFD2C07");
            });

            modelBuilder.Entity<Astore>(entity =>
            {
                entity.ToTable("AStore");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.StoreName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<InventoryDetail>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("InventoryDetail");

                entity.Property(e => e.ItemId).HasColumnName("ItemID");

                entity.Property(e => e.StoreId).HasColumnName("StoreID");

                entity.HasOne(d => d.Item)
                    .WithMany()
                    .HasForeignKey(d => d.ItemId)
                    .HasConstraintName("FK__Inventory__ItemI__164452B1");

                entity.HasOne(d => d.Store)
                    .WithMany()
                    .HasForeignKey(d => d.StoreId)
                    .HasConstraintName("FK__Inventory__Store__15502E78");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
