﻿// <auto-generated />
using System;
using Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace API.Migrations
{
    [DbContext(typeof(RepositoryContext))]
    [Migration("20220417060908_generalize")]
    partial class generalize
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.10")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Entities.Models.Company", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("CompanyId");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("nvarchar(60)");

                    b.Property<string>("Country")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CreatedByUser")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTimeOffset>("CreatedDate")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Fax")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ModifiedByUser")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTimeOffset>("ModifiedDate")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("nvarchar(60)");

                    b.Property<string>("PhoneNo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Website")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Companies");

                    b.HasData(
                        new
                        {
                            Id = new Guid("c9d4c053-49b6-410c-bc78-2d54a9991870"),
                            Address = "Aware around Edna Addis Hotel at Agar Building",
                            Country = "Ethiopia",
                            CreatedDate = new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)),
                            Description = "SACCOS Company",
                            Email = "awach@gmail.com",
                            Fax = "34752",
                            ModifiedDate = new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)),
                            Name = "Awach SACCOS",
                            PhoneNo = "+251-118-12-44-44",
                            Website = "https://www.awach.com"
                        });
                });

            modelBuilder.Entity("Entities.Models.Employee", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("EmployeeId");

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<Guid>("CompanyId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CreatedByUser")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTimeOffset>("CreatedDate")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("Department")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ModifiedByUser")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTimeOffset>("ModifiedDate")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("PhoneNo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Position")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("Id");

                    b.HasIndex("CompanyId");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("Entities.Models.Report", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("BookNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BookOwner")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Branch")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CreatedByUser")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTimeOffset>("CreatedDate")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("MemeberPhone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ModifiedByUser")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTimeOffset>("ModifiedDate")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("Service")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Reports");
                });

            modelBuilder.Entity("Entities.Models.RequestHeader", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("RequestHeaderId");

                    b.Property<string>("BudgetBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BudgetCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTimeOffset>("BudgetDate")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("CreatedByUser")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTimeOffset>("CreatedDate")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("ModifiedByUser")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTimeOffset>("ModifiedDate")
                        .HasColumnType("datetimeoffset");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("RequestHeaders");
                });

            modelBuilder.Entity("Entities.Models.RequestItem", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("RequestItemId");

                    b.Property<string>("ApprovedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTimeOffset>("ApprovedDate")
                        .HasColumnType("datetimeoffset");

                    b.Property<int>("ApprovedQuantity")
                        .HasColumnType("int");

                    b.Property<string>("BuyBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTimeOffset>("BuyDate")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("CreatedByUser")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTimeOffset>("CreatedDate")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DistributeBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTimeOffset>("DistributeDate")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("ModifiedByUser")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTimeOffset>("ModifiedDate")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<Guid>("RequestHeaderId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<Guid>("StoreItemId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("TotalPrice")
                        .HasColumnType("int");

                    b.Property<string>("Type")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UnitPrice")
                        .HasColumnType("int");

                    b.Property<string>("Use")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("RequestHeaderId");

                    b.ToTable("RequestItems");
                });

            modelBuilder.Entity("Entities.Models.StoreHeader", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("StoreHeaderId");

                    b.Property<string>("CreatedByUser")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTimeOffset>("CreatedDate")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("GraNo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ModifiedByUser")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTimeOffset>("ModifiedDate")
                        .HasColumnType("datetimeoffset");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<string>("StoreBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTimeOffset>("StoreDate")
                        .HasColumnType("datetimeoffset");

                    b.Property<Guid>("SupplierId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.ToTable("StoreHeaders");
                });

            modelBuilder.Entity("Entities.Models.StoreItem", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("StoreItemId");

                    b.Property<string>("CreatedByUser")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTimeOffset>("CreatedDate")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("ItemSpecification")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ModifiedByUser")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTimeOffset>("ModifiedDate")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("QtyOrdered")
                        .HasColumnType("int");

                    b.Property<int>("QtyReceived")
                        .HasColumnType("int");

                    b.Property<int>("QtyRemain")
                        .HasColumnType("int");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<Guid>("StoreHeaderId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("TotalPrice")
                        .HasColumnType("int");

                    b.Property<string>("Unit")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UnitPrice")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("StoreHeaderId");

                    b.ToTable("StoreItems");
                });

            modelBuilder.Entity("Entities.Models.User", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool?>("IsEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");

                    b.HasData(
                        new
                        {
                            Id = "fa39cdc7-634e-4ef4-9de6-3bd8a0f52085",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "1b644a8f - 70ce - 4bdd - 91af - b6a774fe8f15",
                            Email = "admin@gmail.com",
                            EmailConfirmed = false,
                            FirstName = "Administrator",
                            IsEnabled = true,
                            LastName = "Administrator",
                            LockoutEnabled = true,
                            NormalizedEmail = "ADMIN@GMAIL.COM",
                            NormalizedUserName = "ADMINISTRATOR",
                            PasswordHash = "AQAAAAEAACcQAAAAEI / XRI6ZeV4JdZWqf9cO9 + cy + qchgfTNS8pudCb60OwF4Z77U2r7oU0bIT3KSJ0wPA ==",
                            PhoneNumber = "+251-944-69-69-69",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "AX4V5FQG663Z44N46VMUANNWRVJRMFHW",
                            TwoFactorEnabled = false,
                            UserName = "Administrator"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");

                    b.HasData(
                        new
                        {
                            Id = "424d64f1-271b-4c1e-9b87-843b0d318606",
                            ConcurrencyStamp = "3cbec4d0-0315-401c-b7ea-aa4a795d24ad",
                            Name = "Administrator",
                            NormalizedName = "ADMINISTRATOR"
                        },
                        new
                        {
                            Id = "06e743ba-9043-4bd7-83f5-ab61a2304c48",
                            ConcurrencyStamp = "5adefb5c-bf2e-40aa-87b2-02812bf39af1",
                            Name = "Purchaser",
                            NormalizedName = "PURCHASER"
                        },
                        new
                        {
                            Id = "9a6ea8d8-3a21-4a70-bb38-2f90589aa8ac",
                            ConcurrencyStamp = "29445259-a456-4b63-9088-4a87dd3b1ce0",
                            Name = "StoreMan",
                            NormalizedName = "STOREMAN"
                        },
                        new
                        {
                            Id = "ce6bace9-9a68-4249-b6c6-f7d75de4392b",
                            ConcurrencyStamp = "03e482f7-36d8-4bde-b22b-6a8585da62bb",
                            Name = "DepartmentHead",
                            NormalizedName = "DEPARTMENTHEAD"
                        },
                        new
                        {
                            Id = "1b7f55bd-27b5-4a7e-b394-f1b59f360f32",
                            ConcurrencyStamp = "8599946a-6200-457c-858a-a13b3d6bca06",
                            Name = "FinanceManager",
                            NormalizedName = "FINANCEMANAGER"
                        },
                        new
                        {
                            Id = "6d5ba3cd-ab9d-4784-ba61-73200eeb5899",
                            ConcurrencyStamp = "7c6e0795-03f2-4710-bac6-836c929b0cc6",
                            Name = "ProcurementManager",
                            NormalizedName = "PROCUREMENTMANAGER"
                        },
                        new
                        {
                            Id = "d4a4ab5a-0918-46f5-ae59-d34b7fa55926",
                            ConcurrencyStamp = "18f51c4e-59ab-4ba2-9d2c-e4f8ad263329",
                            Name = "ReportCreater",
                            NormalizedName = "REPORTCREATER"
                        },
                        new
                        {
                            Id = "664609b2-e6d7-4833-b2ba-368d30f54439",
                            ConcurrencyStamp = "d04b1f95-fea2-40db-89ce-3e662312bb8e",
                            Name = "ReportViwer",
                            NormalizedName = "REPORTVIWER"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("Entities.Models.Employee", b =>
                {
                    b.HasOne("Entities.Models.Company", "Company")
                        .WithMany("Employees")
                        .HasForeignKey("CompanyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Company");
                });

            modelBuilder.Entity("Entities.Models.RequestItem", b =>
                {
                    b.HasOne("Entities.Models.RequestHeader", "RequestHeader")
                        .WithMany("RequestItems")
                        .HasForeignKey("RequestHeaderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("RequestHeader");
                });

            modelBuilder.Entity("Entities.Models.StoreItem", b =>
                {
                    b.HasOne("Entities.Models.StoreHeader", "StoreHeader")
                        .WithMany("StoreItems")
                        .HasForeignKey("StoreHeaderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("StoreHeader");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Entities.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Entities.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Entities.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Entities.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Entities.Models.Company", b =>
                {
                    b.Navigation("Employees");
                });

            modelBuilder.Entity("Entities.Models.RequestHeader", b =>
                {
                    b.Navigation("RequestItems");
                });

            modelBuilder.Entity("Entities.Models.StoreHeader", b =>
                {
                    b.Navigation("StoreItems");
                });
#pragma warning restore 612, 618
        }
    }
}