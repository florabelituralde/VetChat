﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using VetChat.Data;

namespace VetChat.Migrations
{
    [DbContext(typeof(VetChatContext))]
    [Migration("20201103143511_vetchat")]
    partial class vetchat
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("VetChat.Data.AdminData", b =>
                {
                    b.Property<int>("AdminId")
                        .HasColumnName("AdminID")
                        .HasColumnType("int");

                    b.Property<int>("GroupId")
                        .HasColumnName("GroupID")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnName("UserID")
                        .HasColumnType("int");

                    b.HasKey("AdminId")
                        .HasName("PK_AdminID");

                    b.HasIndex("GroupId");

                    b.HasIndex("UserId");

                    b.ToTable("AdminData");
                });

            modelBuilder.Entity("VetChat.Data.GroupData", b =>
                {
                    b.Property<int>("GroupId")
                        .HasColumnName("GroupID")
                        .HasColumnType("int");

                    b.Property<string>("GroupName")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("GroupVisibility")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<int?>("MembersCount")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnName("UserID")
                        .HasColumnType("int");

                    b.HasKey("GroupId")
                        .HasName("PK_GroupID");

                    b.HasIndex("UserId");

                    b.ToTable("GroupData");
                });

            modelBuilder.Entity("VetChat.Data.UserInformation", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnName("UserID")
                        .HasColumnType("int");

                    b.Property<string>("Branch")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("ConfirmPassword")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Contact")
                        .HasColumnType("int");

                    b.Property<DateTime>("DateOfEntry")
                        .HasColumnType("date");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Ets")
                        .HasColumnName("ETS")
                        .HasColumnType("date");

                    b.Property<string>("Firstname")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("Lastname")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.HasKey("UserId")
                        .HasName("PK_UserID");

                    b.ToTable("UserInformation");
                });

            modelBuilder.Entity("VetChat.Data.AdminData", b =>
                {
                    b.HasOne("VetChat.Data.GroupData", "Group")
                        .WithMany("AdminData")
                        .HasForeignKey("GroupId")
                        .HasConstraintName("FK_AdminData_GroupID")
                        .IsRequired();

                    b.HasOne("VetChat.Data.UserInformation", "User")
                        .WithMany("AdminData")
                        .HasForeignKey("UserId")
                        .HasConstraintName("FK_AdminData_UserID")
                        .IsRequired();
                });

            modelBuilder.Entity("VetChat.Data.GroupData", b =>
                {
                    b.HasOne("VetChat.Data.UserInformation", "User")
                        .WithMany("GroupData")
                        .HasForeignKey("UserId")
                        .HasConstraintName("FK_GroupData_UserID")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
