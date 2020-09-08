using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using VetChat.Models;

namespace VetChat.Data
{
    public partial class VetChatContext : DbContext
    {
        public VetChatContext()
        {
        }

        public VetChatContext(DbContextOptions<VetChatContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AdminData> AdminData { get; set; }
        public virtual DbSet<GroupData> GroupData { get; set; }
        public virtual DbSet<UserInformation> UserInformation { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AdminData>(entity =>
            {
                entity.HasKey(e => e.AdminId)
                    .HasName("PK_AdminID");

                entity.Property(e => e.AdminId)
                    .HasColumnName("AdminID")
                    .ValueGeneratedNever();

                entity.Property(e => e.GroupId).HasColumnName("GroupID");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.HasOne(d => d.Group)
                    .WithMany(p => p.AdminData)
                    .HasForeignKey(d => d.GroupId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AdminData_GroupID");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AdminData)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AdminData_UserID");
            });

            modelBuilder.Entity<GroupData>(entity =>
            {
                entity.HasKey(e => e.GroupId)
                    .HasName("PK_GroupID");

                entity.Property(e => e.GroupId)
                    .HasColumnName("GroupID")
                    .ValueGeneratedNever();

                entity.Property(e => e.GroupName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.GroupVisibility)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.GroupData)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_GroupData_UserID");
            });

            modelBuilder.Entity<UserInformation>(entity =>
            {
                entity.HasKey(e => e.UserId)
                    .HasName("PK_UserID");

                entity.Property(e => e.UserId)
                    .HasColumnName("UserID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Branch)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.DateOfEntry).HasColumnType("date");

                entity.Property(e => e.Ets)
                    .HasColumnName("ETS")
                    .HasColumnType("date");

                entity.Property(e => e.Firstname)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Lastname)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Username)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
