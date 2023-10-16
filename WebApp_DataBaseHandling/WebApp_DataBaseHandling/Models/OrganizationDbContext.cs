using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace WebApp_DataBaseHandling.Models
{
    public partial class OrganizationDbContext : DbContext
    {
        public OrganizationDbContext()
        {
        }

        public OrganizationDbContext(DbContextOptions<OrganizationDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<CategoryTbl> CategoryTbls { get; set; } = null!;
        public virtual DbSet<ProductTbl> ProductTbls { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("data source=.;initial catalog=OrganizationDb;user id=sa;password=aptech;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CategoryTbl>(entity =>
            {
                entity.HasKey(e => e.CatId);

                entity.ToTable("category_tbl");

                entity.Property(e => e.CatId).HasColumnName("cat_id");

                entity.Property(e => e.CatName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("cat_name");
            });

            modelBuilder.Entity<ProductTbl>(entity =>
            {
                entity.HasKey(e => e.ProId);

                entity.ToTable("product_tbl");

                entity.Property(e => e.ProId).HasColumnName("pro_id");

                entity.Property(e => e.CatIdFk).HasColumnName("cat_id_fk");

                entity.Property(e => e.ProDes)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("pro_des");

                entity.Property(e => e.ProImage)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("pro_image");

                entity.Property(e => e.ProName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("pro_name");

                entity.Property(e => e.ProPrice).HasColumnName("pro_price");

                entity.HasOne(d => d.CatIdFkNavigation)
                    .WithMany(p => p.ProductTbls)
                    .HasForeignKey(d => d.CatIdFk)
                    .HasConstraintName("FK_product_tbl_category_tbl");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
