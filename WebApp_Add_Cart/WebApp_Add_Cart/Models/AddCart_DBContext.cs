using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace WebApp_Add_Cart.Models
{
    public partial class AddCart_DBContext : DbContext
    {
        public AddCart_DBContext()
        {
        }

        public AddCart_DBContext(DbContextOptions<AddCart_DBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Category> Categories { get; set; } = null!;
        public virtual DbSet<Customer> Customers { get; set; } = null!;
        public virtual DbSet<OrderTable> OrderTables { get; set; } = null!;
        public virtual DbSet<Product> Products { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("data source=.;initial catalog=AddCart_DB;user id=sa;password=aptech;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>(entity =>
            {
                entity.HasKey(e => e.Catid);

                entity.ToTable("Category");

                entity.Property(e => e.Catid).HasColumnName("catid");

                entity.Property(e => e.Catname)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("catname");
            });

            modelBuilder.Entity<Customer>(entity =>
            {
                entity.HasKey(e => e.CustId);

                entity.ToTable("Customer");

                entity.Property(e => e.CustId).HasColumnName("cust_id");

                entity.Property(e => e.CustEmail)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("cust_email");

                entity.Property(e => e.CustName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("cust_name");

                entity.Property(e => e.CustPassword)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("cust_password");

                entity.Property(e => e.CustPhone)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("cust_phone");
            });

            modelBuilder.Entity<OrderTable>(entity =>
            {
                entity.HasKey(e => e.OrderId)
                    .HasName("PK_Order");

                entity.ToTable("OrderTable");

                entity.Property(e => e.OrderId).HasColumnName("Order_id");

                entity.Property(e => e.Address)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Fullname)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OrderDate)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Order_Date");

                entity.Property(e => e.PIdFk).HasColumnName("P_id_fk");

                entity.Property(e => e.Phone)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TotalAmount)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Total_Amount");

                entity.HasOne(d => d.PIdFkNavigation)
                    .WithMany(p => p.OrderTables)
                    .HasForeignKey(d => d.PIdFk)
                    .HasConstraintName("FK_OrderTable_Product");
            });

            modelBuilder.Entity<Product>(entity =>
            {
                entity.HasKey(e => e.Proid);

                entity.ToTable("Product");

                entity.Property(e => e.Proid).HasColumnName("proid");

                entity.Property(e => e.CatIdFk).HasColumnName("cat_id_fk");

                entity.Property(e => e.Prodes)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("prodes");

                entity.Property(e => e.Proimage)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("proimage");

                entity.Property(e => e.Proname)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("proname");

                entity.Property(e => e.Proprice).HasColumnName("proprice");

                entity.HasOne(d => d.CatIdFkNavigation)
                    .WithMany(p => p.Products)
                    .HasForeignKey(d => d.CatIdFk)
                    .HasConstraintName("FK_Product_Category");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
