using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace cleaningsoftWebApp.Models
{
    public partial class CleaningSoftwareLogicContext : DbContext
    {
        public virtual DbSet<CleaningServiceProviders> CleaningServiceProviders { get; set; }
        public virtual DbSet<CleaningServiceType> CleaningServiceType { get; set; }
        public virtual DbSet<CleaningWorkerType> CleaningWorkerType { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer(@"Data Source=Shivangini;Initial Catalog=CleaningSoftwareLogic;Integrated Security=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CleaningServiceProviders>(entity =>
            {
                entity.ToTable("Cleaning_Service_Providers");

                entity.Property(e => e.Id).HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.CompanyName)
                    .HasColumnName("Company_Name")
                    .HasMaxLength(300);
            });

            modelBuilder.Entity<CleaningServiceType>(entity =>
            {
                entity.ToTable("Cleaning_Service_Type");

                entity.HasIndex(e => e.ServiceTypeName)
                    .HasName("UNIQUE_Cleaning_Service_Type_Name")
                    .IsUnique();

                entity.Property(e => e.Id).HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.ServiceTypeName)
                    .HasColumnName("Service_Type_Name")
                    .HasMaxLength(300);
            });

            modelBuilder.Entity<CleaningWorkerType>(entity =>
            {
                entity.ToTable("Cleaning_Worker_Type");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.EmploumentType)
                    .HasColumnName("Emploument_Type")
                    .HasMaxLength(300);
            });
        }
    }
}
