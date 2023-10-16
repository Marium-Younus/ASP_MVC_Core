using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace sc.Models
{
    public partial class TutorialDbContext : DbContext
    {
        public TutorialDbContext()
        {
        }

        public TutorialDbContext(DbContextOptions<TutorialDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Student> Students { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("data source=.;initial catalog=TutorialDb;user id=sa;password=aptech;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>(entity =>
            {
                entity.HasKey(e => e.SId);

                entity.ToTable("Student");

                entity.Property(e => e.SId).HasColumnName("s_id");

                entity.Property(e => e.SBc).HasColumnName("s_bc");

                entity.Property(e => e.SEmail).HasColumnName("s_email");

                entity.Property(e => e.SName).HasColumnName("s_name");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
