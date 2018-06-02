using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace cleaningsoftWebApp.Models
{
    public partial class CleaningSoftwareLogicContext : DbContext
    {
        public virtual DbSet<CleanerDetail> CleanerDetail { get; set; }
        public virtual DbSet<CleaningServiceProviders> CleaningServiceProviders { get; set; }
        public virtual DbSet<CleaningServiceType> CleaningServiceType { get; set; }
        public virtual DbSet<CleaningTaskDetail> CleaningTaskDetail { get; set; }
        public virtual DbSet<CleaningWorkerType> CleaningWorkerType { get; set; }

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
            modelBuilder.Entity<CleanerDetail>(entity =>
            {
                entity.ToTable("Cleaner_Detail");

                entity.Property(e => e.Id).HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.CleanerDetailName)
                    .HasColumnName("Cleaner_Detail_Name")
                    .HasMaxLength(300);

                entity.Property(e => e.CleanerDetailStartDate)
                    .HasColumnName("Cleaner_Detail_Start_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.CleaningWorkerTypeId).HasColumnName("Cleaning_worker_type_ID");
            });

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

            modelBuilder.Entity<CleaningTaskDetail>(entity =>
            {
                entity.ToTable("Cleaning_Task_Detail");

                entity.Property(e => e.Id).HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.CleanerDetailId).HasColumnName("Cleaner_detail_ID");

                entity.Property(e => e.CleaningTaskAssignedById).HasColumnName("Cleaning_Task_Assigned_By_ID");

                entity.Property(e => e.CleaningTaskDetailId).HasColumnName("Cleaning_Task_Detail_ID");

                entity.Property(e => e.CleaningTaskDifficultyId).HasColumnName("Cleaning_Task_difficulty_ID");

                entity.Property(e => e.CleaningTaskName)
                    .HasColumnName("Cleaning_Task_Name")
                    .HasMaxLength(200);

                entity.Property(e => e.CleaningTaskTaskDetail)
                    .HasColumnName("Cleaning_Task_Task_Detail")
                    .HasMaxLength(400);

                entity.Property(e => e.CleaningTaskTypeId).HasColumnName("Cleaning_task_Type_ID");

                entity.HasOne(d => d.CleanerDetail)
                    .WithMany(p => p.CleaningTaskDetail)
                    .HasForeignKey(d => d.CleanerDetailId)
                    .HasConstraintName("FK_DBO_Cleaning_Task_Detail_01");
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
