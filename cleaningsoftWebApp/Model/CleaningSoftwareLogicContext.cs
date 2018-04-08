using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace cleaningsoftWebApp.Model
{
    public partial class CleaningSoftwareLogicContext : DbContext
    {
        public virtual DbSet<CleaningServiceType> CleaningServiceType { get; set; }

        // Unable to generate entity type for table 'dbo.Cleaning_Service_Providers'. Please see the warning messages.

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer(@"Server=localhost;Database=CleaningSoftwareLogic;User ID=dev2;Password=Dcs1989..");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CleaningServiceType>(entity =>
            {
                entity.ToTable("Cleaning_Service_Type");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.ServiceTypeName)
                    .HasColumnName("Service_Type_Name")
                    .HasMaxLength(300);
            });
        }
    }
}
