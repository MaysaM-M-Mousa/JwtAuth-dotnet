﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PBAC.DB;

#nullable disable

namespace PBAC.Migrations
{
    [DbContext(typeof(PbacContext))]
    [Migration("20240213214621_Updating_users_emails")]
    partial class Updating_users_emails
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.26")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("PBAC.Models.Db.Permission", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Permissions");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "product:create"
                        },
                        new
                        {
                            Id = 2,
                            Name = "product:update"
                        },
                        new
                        {
                            Id = 3,
                            Name = "product:delete"
                        },
                        new
                        {
                            Id = 4,
                            Name = "product:read"
                        },
                        new
                        {
                            Id = 5,
                            Name = "item:create"
                        },
                        new
                        {
                            Id = 6,
                            Name = "item:update"
                        },
                        new
                        {
                            Id = 7,
                            Name = "item:delete"
                        },
                        new
                        {
                            Id = 8,
                            Name = "item:read"
                        },
                        new
                        {
                            Id = 9,
                            Name = "user.permissions:write"
                        });
                });

            modelBuilder.Entity("PBAC.Models.Db.Role", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Roles");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Admin"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Moderator"
                        },
                        new
                        {
                            Id = 3,
                            Name = "User"
                        });
                });

            modelBuilder.Entity("PBAC.Models.Db.RolePermission", b =>
                {
                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.Property<int>("PermissionId")
                        .HasColumnType("int");

                    b.HasKey("RoleId", "PermissionId");

                    b.HasIndex("PermissionId");

                    b.ToTable("RolesPermissions");

                    b.HasData(
                        new
                        {
                            RoleId = 1,
                            PermissionId = 1
                        },
                        new
                        {
                            RoleId = 1,
                            PermissionId = 2
                        },
                        new
                        {
                            RoleId = 1,
                            PermissionId = 3
                        },
                        new
                        {
                            RoleId = 1,
                            PermissionId = 4
                        },
                        new
                        {
                            RoleId = 1,
                            PermissionId = 5
                        },
                        new
                        {
                            RoleId = 1,
                            PermissionId = 6
                        },
                        new
                        {
                            RoleId = 1,
                            PermissionId = 7
                        },
                        new
                        {
                            RoleId = 1,
                            PermissionId = 8
                        },
                        new
                        {
                            RoleId = 1,
                            PermissionId = 9
                        },
                        new
                        {
                            RoleId = 2,
                            PermissionId = 1
                        },
                        new
                        {
                            RoleId = 2,
                            PermissionId = 4
                        },
                        new
                        {
                            RoleId = 2,
                            PermissionId = 5
                        },
                        new
                        {
                            RoleId = 2,
                            PermissionId = 8
                        },
                        new
                        {
                            RoleId = 3,
                            PermissionId = 4
                        },
                        new
                        {
                            RoleId = 3,
                            PermissionId = 8
                        });
                });

            modelBuilder.Entity("PBAC.Models.Db.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = new Guid("a8315f05-f401-4589-b976-61d129d3b1d7"),
                            Email = "admin@gmail.com",
                            Password = "easyPass",
                            UserName = "Maysam Mousa"
                        },
                        new
                        {
                            Id = new Guid("54bfc54e-386b-455f-b627-5b8800d7fc1a"),
                            Email = "moderator@gmail.com",
                            Password = "easyPass",
                            UserName = "Some random person"
                        },
                        new
                        {
                            Id = new Guid("8db76dd5-c7ff-4550-b471-38d3f73446bb"),
                            Email = "user@gmail.com",
                            Password = "easyPass",
                            UserName = "regular user"
                        },
                        new
                        {
                            Id = new Guid("ffb2061b-815e-4f4a-a981-7846f76954ef"),
                            Email = "mix@gmail.com",
                            Password = "easyPass",
                            UserName = "mix user"
                        });
                });

            modelBuilder.Entity("PBAC.Models.Db.UserRole", b =>
                {
                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("UsersRoles");

                    b.HasData(
                        new
                        {
                            UserId = new Guid("a8315f05-f401-4589-b976-61d129d3b1d7"),
                            RoleId = 1
                        },
                        new
                        {
                            UserId = new Guid("54bfc54e-386b-455f-b627-5b8800d7fc1a"),
                            RoleId = 2
                        },
                        new
                        {
                            UserId = new Guid("8db76dd5-c7ff-4550-b471-38d3f73446bb"),
                            RoleId = 3
                        },
                        new
                        {
                            UserId = new Guid("ffb2061b-815e-4f4a-a981-7846f76954ef"),
                            RoleId = 2
                        },
                        new
                        {
                            UserId = new Guid("ffb2061b-815e-4f4a-a981-7846f76954ef"),
                            RoleId = 3
                        });
                });

            modelBuilder.Entity("PBAC.Models.Db.RolePermission", b =>
                {
                    b.HasOne("PBAC.Models.Db.Permission", null)
                        .WithMany()
                        .HasForeignKey("PermissionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PBAC.Models.Db.Role", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("PBAC.Models.Db.UserRole", b =>
                {
                    b.HasOne("PBAC.Models.Db.Role", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PBAC.Models.Db.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}