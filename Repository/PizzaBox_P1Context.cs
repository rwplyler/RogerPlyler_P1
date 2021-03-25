using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Models;

#nullable disable

namespace Repository.Models
{
    public partial class PizzaBox_P1Context : DbContext
    {
        public PizzaBox_P1Context()
        {
        }

        public PizzaBox_P1Context(DbContextOptions<PizzaBox_P1Context> options)
            : base(options)
        {
        }

        public virtual DbSet<Acrust> Acrusts { get; set; }
        public virtual DbSet<Acustomer> Acustomers { get; set; }
        public virtual DbSet<Aorder> Aorders { get; set; }
        public virtual DbSet<AorderedPizza> AorderedPizzas { get; set; }
        public virtual DbSet<AorderedTopping> AorderedToppings { get; set; }
        public virtual DbSet<Apizza> Apizzas { get; set; }
        public virtual DbSet<ApizzaTopping> ApizzaToppings { get; set; }
        public virtual DbSet<Asize> Asizes { get; set; }
        public virtual DbSet<Astore> Astores { get; set; }
        public virtual DbSet<Atopping> Atoppings { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {

                optionsBuilder.UseSqlServer("Server=.\\SQLEXPRESS;Database=PizzaBox_P1;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Acrust>(entity =>
            {
                entity.ToTable("ACrust");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.CrustName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CrustPrice).HasColumnType("decimal(5, 2)");
            });

            modelBuilder.Entity<Acustomer>(entity =>
            {
                entity.ToTable("ACustomer");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.CustomerName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LocationId).HasColumnName("LocationID");
            });

            modelBuilder.Entity<Aorder>(entity =>
            {
                entity.HasKey(e => e.OrderId)
                    .HasName("PK__AOrder__C3905BAF97002A65");

                entity.ToTable("AOrder");

                entity.Property(e => e.OrderId).HasColumnName("OrderID");

                entity.Property(e => e.CustomerId).HasColumnName("CustomerID");

                entity.Property(e => e.StoreId).HasColumnName("StoreID");

                entity.Property(e => e.TimeOrdered).HasColumnType("datetime");

                entity.Property(e => e.Total).HasColumnType("decimal(5, 2)");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.Aorders)
                    .HasForeignKey(d => d.CustomerId)
                    .HasConstraintName("FK__AOrder__Customer__21B6055D");

                entity.HasOne(d => d.Store)
                    .WithMany(p => p.Aorders)
                    .HasForeignKey(d => d.StoreId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__AOrder__StoreID__20C1E124");
            });

            modelBuilder.Entity<AorderedPizza>(entity =>
            {
                entity.ToTable("AOrderedPizza");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.OrderId).HasColumnName("OrderID");

                entity.Property(e => e.PizzaName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Price).HasColumnType("decimal(5, 2)");

                entity.HasOne(d => d.CrustNavigation)
                    .WithMany(p => p.AorderedPizzas)
                    .HasForeignKey(d => d.Crust)
                    .HasConstraintName("FK__AOrderedP__Crust__267ABA7A");

                entity.HasOne(d => d.Order)
                    .WithMany(p => p.AorderedPizzas)
                    .HasForeignKey(d => d.OrderId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__AOrderedP__Order__24927208");

                entity.HasOne(d => d.SizeNavigation)
                    .WithMany(p => p.AorderedPizzas)
                    .HasForeignKey(d => d.Size)
                    .HasConstraintName("FK__AOrderedPi__Size__25869641");
            });

            modelBuilder.Entity<AorderedTopping>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("AOrderedTopping");

                entity.Property(e => e.PizzaId).HasColumnName("PizzaID");

                entity.Property(e => e.ToppingId).HasColumnName("ToppingID");

                entity.HasOne(d => d.Pizza)
                    .WithMany()
                    .HasForeignKey(d => d.PizzaId)
                    .HasConstraintName("FK__AOrderedT__Pizza__286302EC");

                entity.HasOne(d => d.Topping)
                    .WithMany()
                    .HasForeignKey(d => d.ToppingId)
                    .HasConstraintName("FK__AOrderedT__Toppi__29572725");
            });

            modelBuilder.Entity<Apizza>(entity =>
            {
                entity.ToTable("APizza");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.PizzaName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Price).HasColumnType("decimal(5, 2)");

                entity.HasOne(d => d.CrustNavigation)
                    .WithMany(p => p.Apizzas)
                    .HasForeignKey(d => d.Crust)
                    .HasConstraintName("FK__APizza__Crust__1B0907CE");

                entity.HasOne(d => d.SizeNavigation)
                    .WithMany(p => p.Apizzas)
                    .HasForeignKey(d => d.Size)
                    .HasConstraintName("FK__APizza__Size__1A14E395");
            });

            modelBuilder.Entity<ApizzaTopping>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("APizzaTopping");

                entity.Property(e => e.PizzaId).HasColumnName("PizzaID");

                entity.Property(e => e.ToppingId).HasColumnName("ToppingID");

                entity.HasOne(d => d.Pizza)
                    .WithMany()
                    .HasForeignKey(d => d.PizzaId)
                    .HasConstraintName("FK__APizzaTop__Pizza__1CF15040");

                entity.HasOne(d => d.Topping)
                    .WithMany()
                    .HasForeignKey(d => d.ToppingId)
                    .HasConstraintName("FK__APizzaTop__Toppi__1DE57479");
            });

            modelBuilder.Entity<Asize>(entity =>
            {
                entity.ToTable("ASize");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.SizeName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SizePrice).HasColumnType("decimal(5, 2)");
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

            modelBuilder.Entity<Atopping>(entity =>
            {
                entity.ToTable("ATopping");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.ToppingName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ToppingPrice).HasColumnType("decimal(5, 2)");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
