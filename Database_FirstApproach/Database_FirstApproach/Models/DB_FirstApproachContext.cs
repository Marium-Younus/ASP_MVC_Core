using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Database_FirstApproach.Models
{
    public partial class DB_FirstApproachContext : DbContext
    {
        public DB_FirstApproachContext()
        {
        }

        public DB_FirstApproachContext(DbContextOptions<DB_FirstApproachContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Employee> Employees { get; set; } = null!;
        public virtual DbSet<Student> Students { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("data source=.;initial catalog=DB_FirstApproach;user id=sa;password=aptech;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>(entity =>
            {
                entity.HasKey(e => e.EId);

                entity.ToTable("Employee");

                entity.Property(e => e.EId).HasColumnName("e_id");

                entity.Property(e => e.EImage)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("e_image");

                entity.Property(e => e.EName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("e_name");
            });

            modelBuilder.Entity<Student>(entity =>
            {
                entity.HasKey(e => e.SId);

                entity.ToTable("Student");

                entity.Property(e => e.SId).HasColumnName("s_id");

                entity.Property(e => e.SAge).HasColumnName("s_age");

                entity.Property(e => e.SCity)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("s_city");

                entity.Property(e => e.SEmail)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("s_email");

                entity.Property(e => e.SGender)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("s_gender");

                entity.Property(e => e.SName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("s_name");

                entity.Property(e => e.SPhone)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("s_phone");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
