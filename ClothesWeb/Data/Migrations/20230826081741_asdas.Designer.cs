﻿// <auto-generated />
using System;
using ClothesWeb.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ClothesWeb.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20230826081741_asdas")]
    partial class asdas
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ClothesWeb.Data.CategoriesModel.Image", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("CoatsId")
                        .HasColumnType("int");

                    b.Property<byte[]>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("varbinary(max)");

                    b.Property<int?>("PantsId")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<int?>("ShirtId")
                        .HasColumnType("int");

                    b.Property<int>("ShirtsId")
                        .HasColumnType("int");

                    b.Property<int?>("ShoesId")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<int?>("SuitId")
                        .HasColumnType("int");

                    b.Property<int?>("SweaterId")
                        .IsRequired()
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CoatsId");

                    b.HasIndex("PantsId");

                    b.HasIndex("ShirtsId");

                    b.HasIndex("ShoesId");

                    b.HasIndex("SuitId");

                    b.HasIndex("SweaterId");

                    b.ToTable("Image");
                });

            modelBuilder.Entity("ClothesWeb.Data.Entites.types.Coats_jackets", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Colors")
                        .HasColumnType("int");

                    b.Property<int>("DesignerID")
                        .HasColumnType("int");

                    b.Property<int>("DesignersId")
                        .HasColumnType("int");

                    b.Property<int>("Material")
                        .HasColumnType("int");

                    b.Property<int>("Name")
                        .HasColumnType("int");

                    b.Property<int>("Size")
                        .HasColumnType("int");

                    b.Property<DateTime>("registation_date")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("DesignersId");

                    b.ToTable("Coats");
                });

            modelBuilder.Entity("ClothesWeb.Data.Entites.types.Designers", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("designer_name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("registration_date")
                        .HasColumnType("datetime2");

                    b.Property<string>("registration_status")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Designers");
                });

            modelBuilder.Entity("ClothesWeb.Data.Entites.types.Pants", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Colors")
                        .HasColumnType("int");

                    b.Property<int>("DesignerID")
                        .HasColumnType("int");

                    b.Property<int>("DesignersId")
                        .HasColumnType("int");

                    b.Property<int>("Material")
                        .HasColumnType("int");

                    b.Property<int>("Name")
                        .HasColumnType("int");

                    b.Property<int>("Size")
                        .HasColumnType("int");

                    b.Property<DateTime>("registation_date")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("DesignersId");

                    b.ToTable("Pants");
                });

            modelBuilder.Entity("ClothesWeb.Data.Entites.types.Polo_TShirts", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Colors")
                        .HasColumnType("int");

                    b.Property<int>("DesignerID")
                        .HasColumnType("int");

                    b.Property<int>("DesignersId")
                        .HasColumnType("int");

                    b.Property<int>("Material")
                        .HasColumnType("int");

                    b.Property<int>("Name")
                        .HasColumnType("int");

                    b.Property<int>("Size")
                        .HasColumnType("int");

                    b.Property<DateTime>("registration_date")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("DesignersId");

                    b.ToTable("Shirts");
                });

            modelBuilder.Entity("ClothesWeb.Data.Entites.types.Shoes", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Colors")
                        .HasColumnType("int");

                    b.Property<int>("DesignerID")
                        .HasColumnType("int");

                    b.Property<int>("DesignersId")
                        .HasColumnType("int");

                    b.Property<int>("Material")
                        .HasColumnType("int");

                    b.Property<int>("Name")
                        .HasColumnType("int");

                    b.Property<int>("Size")
                        .HasColumnType("int");

                    b.Property<DateTime>("registation_date")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("DesignersId");

                    b.ToTable("Shoes");
                });

            modelBuilder.Entity("ClothesWeb.Data.Entites.types.Suits", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Colors")
                        .HasColumnType("int");

                    b.Property<int>("DesignerID")
                        .HasColumnType("int");

                    b.Property<int>("DesignersId")
                        .HasColumnType("int");

                    b.Property<int>("Material")
                        .HasColumnType("int");

                    b.Property<int>("Size")
                        .HasColumnType("int");

                    b.Property<DateTime>("registration_date")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("DesignersId");

                    b.ToTable("Suits");
                });

            modelBuilder.Entity("ClothesWeb.Data.Entites.types.Sweater", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Colors")
                        .HasColumnType("int");

                    b.Property<DateTime>("DateTime")
                        .HasColumnType("datetime2");

                    b.Property<int>("DesignerID")
                        .HasColumnType("int");

                    b.Property<int>("DesignersId")
                        .HasColumnType("int");

                    b.Property<int>("Material")
                        .HasColumnType("int");

                    b.Property<int>("Name")
                        .HasColumnType("int");

                    b.Property<int>("Size")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("DesignersId");

                    b.ToTable("Sweater");
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

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
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

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Name")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("ClothesWeb.Data.CategoriesModel.Image", b =>
                {
                    b.HasOne("ClothesWeb.Data.Entites.types.Coats_jackets", "Coats")
                        .WithMany("Images")
                        .HasForeignKey("CoatsId");

                    b.HasOne("ClothesWeb.Data.Entites.types.Pants", "Pants")
                        .WithMany("Images")
                        .HasForeignKey("PantsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ClothesWeb.Data.Entites.types.Polo_TShirts", "Shirts")
                        .WithMany("Images")
                        .HasForeignKey("ShirtsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ClothesWeb.Data.Entites.types.Shoes", "Shoes")
                        .WithMany("Images")
                        .HasForeignKey("ShoesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ClothesWeb.Data.Entites.types.Suits", "Suits")
                        .WithMany("Images")
                        .HasForeignKey("SuitId");

                    b.HasOne("ClothesWeb.Data.Entites.types.Sweater", "Sweater")
                        .WithMany("Images")
                        .HasForeignKey("SweaterId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Coats");

                    b.Navigation("Pants");

                    b.Navigation("Shirts");

                    b.Navigation("Shoes");

                    b.Navigation("Suits");

                    b.Navigation("Sweater");
                });

            modelBuilder.Entity("ClothesWeb.Data.Entites.types.Coats_jackets", b =>
                {
                    b.HasOne("ClothesWeb.Data.Entites.types.Designers", "Designers")
                        .WithMany()
                        .HasForeignKey("DesignersId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Designers");
                });

            modelBuilder.Entity("ClothesWeb.Data.Entites.types.Pants", b =>
                {
                    b.HasOne("ClothesWeb.Data.Entites.types.Designers", "Designers")
                        .WithMany()
                        .HasForeignKey("DesignersId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Designers");
                });

            modelBuilder.Entity("ClothesWeb.Data.Entites.types.Polo_TShirts", b =>
                {
                    b.HasOne("ClothesWeb.Data.Entites.types.Designers", "Designers")
                        .WithMany()
                        .HasForeignKey("DesignersId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Designers");
                });

            modelBuilder.Entity("ClothesWeb.Data.Entites.types.Shoes", b =>
                {
                    b.HasOne("ClothesWeb.Data.Entites.types.Designers", "Designers")
                        .WithMany()
                        .HasForeignKey("DesignersId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Designers");
                });

            modelBuilder.Entity("ClothesWeb.Data.Entites.types.Suits", b =>
                {
                    b.HasOne("ClothesWeb.Data.Entites.types.Designers", "Designers")
                        .WithMany()
                        .HasForeignKey("DesignersId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Designers");
                });

            modelBuilder.Entity("ClothesWeb.Data.Entites.types.Sweater", b =>
                {
                    b.HasOne("ClothesWeb.Data.Entites.types.Designers", "Designers")
                        .WithMany()
                        .HasForeignKey("DesignersId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Designers");
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
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
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

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ClothesWeb.Data.Entites.types.Coats_jackets", b =>
                {
                    b.Navigation("Images");
                });

            modelBuilder.Entity("ClothesWeb.Data.Entites.types.Pants", b =>
                {
                    b.Navigation("Images");
                });

            modelBuilder.Entity("ClothesWeb.Data.Entites.types.Polo_TShirts", b =>
                {
                    b.Navigation("Images");
                });

            modelBuilder.Entity("ClothesWeb.Data.Entites.types.Shoes", b =>
                {
                    b.Navigation("Images");
                });

            modelBuilder.Entity("ClothesWeb.Data.Entites.types.Suits", b =>
                {
                    b.Navigation("Images");
                });

            modelBuilder.Entity("ClothesWeb.Data.Entites.types.Sweater", b =>
                {
                    b.Navigation("Images");
                });
#pragma warning restore 612, 618
        }
    }
}