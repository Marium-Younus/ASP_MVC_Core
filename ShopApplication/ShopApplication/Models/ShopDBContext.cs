using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace ShopApplication.Models
{
    public partial class ShopDBContext : DbContext
    {
        public ShopDBContext()
        {
        }

        public ShopDBContext(DbContextOptions<ShopDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Category> Categories { get; set; } = null!;
        public virtual DbSet<Product> Products { get; set; } = null!;
        public virtual DbSet<ViewPc> ViewPcs { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("data source=.;initial catalog=ShopDB;user id=sa;password=aptech;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>(entity =>
            {
                entity.HasKey(e => e.CId);

                entity.ToTable("Category");

                entity.Property(e => e.CId).HasColumnName("c_id");

                entity.Property(e => e.CName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("c_name");
            });

            modelBuilder.Entity<Product>(entity =>
            {
                entity.HasKey(e => e.PId);

                entity.ToTable("Product");

                entity.Property(e => e.PId).HasColumnName("p_id");

                entity.Property(e => e.CIdFk).HasColumnName("c_id_fk");

                entity.Property(e => e.PDes)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("p_des");

                entity.Property(e => e.PImage)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("p_image");

                entity.Property(e => e.PName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("p_name");

                entity.Property(e => e.PPrice)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("p_price");

                entity.HasOne(d => d.CIdFkNavigation)
                    .WithMany(p => p.Products)
                    .HasForeignKey(d => d.CIdFk)
                    .HasConstraintName("FK_Product_Category");
            });

            modelBuilder.Entity<ViewPc>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_PC");

                entity.Property(e => e.CName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("c_name");

                entity.Property(e => e.PDes)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("p_des");

                entity.Property(e => e.PId).HasColumnName("p_id");

                entity.Property(e => e.PImage)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("p_image");

                entity.Property(e => e.PName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("p_name");

                entity.Property(e => e.PPrice)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("p_price");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
