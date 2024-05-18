﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TemplateApi.Persistence.Context;

#nullable disable

namespace TemplateApi.Persistence.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20240512174924_update1")]
    partial class update1
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("TemplateApi.Domain.Entities.Brand", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.ToTable("Brands");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedDate = new DateTime(2024, 5, 12, 20, 49, 21, 966, DateTimeKind.Local).AddTicks(7133),
                            IsDeleted = false,
                            Name = "Electronics"
                        },
                        new
                        {
                            Id = 2,
                            CreatedDate = new DateTime(2024, 5, 12, 20, 49, 21, 966, DateTimeKind.Local).AddTicks(7278),
                            IsDeleted = false,
                            Name = "Automotive, Movies & Kids"
                        },
                        new
                        {
                            Id = 3,
                            CreatedDate = new DateTime(2024, 5, 12, 20, 49, 21, 966, DateTimeKind.Local).AddTicks(7316),
                            IsDeleted = true,
                            Name = "Garden & Home"
                        });
                });

            modelBuilder.Entity("TemplateApi.Domain.Entities.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ParentId")
                        .HasColumnType("int");

                    b.Property<int>("Priorty")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedDate = new DateTime(2024, 5, 12, 20, 49, 21, 967, DateTimeKind.Local).AddTicks(4895),
                            IsDeleted = false,
                            Name = "Elektronik",
                            ParentId = 0,
                            Priorty = 1
                        },
                        new
                        {
                            Id = 2,
                            CreatedDate = new DateTime(2024, 5, 12, 20, 49, 21, 967, DateTimeKind.Local).AddTicks(4898),
                            IsDeleted = false,
                            Name = "Moda",
                            ParentId = 0,
                            Priorty = 2
                        },
                        new
                        {
                            Id = 3,
                            CreatedDate = new DateTime(2024, 5, 12, 20, 49, 21, 967, DateTimeKind.Local).AddTicks(4901),
                            IsDeleted = false,
                            Name = "Bilgisayar",
                            ParentId = 1,
                            Priorty = 1
                        },
                        new
                        {
                            Id = 4,
                            CreatedDate = new DateTime(2024, 5, 12, 20, 49, 21, 967, DateTimeKind.Local).AddTicks(4904),
                            IsDeleted = false,
                            Name = "Kadın",
                            ParentId = 2,
                            Priorty = 1
                        });
                });

            modelBuilder.Entity("TemplateApi.Domain.Entities.Detail", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Details");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryId = 1,
                            CreatedDate = new DateTime(2024, 5, 12, 20, 49, 21, 973, DateTimeKind.Local).AddTicks(6606),
                            Description = "Sokaklarda kalemi çobanın adipisci aperiam.",
                            IsDeleted = false,
                            Title = "Qui."
                        },
                        new
                        {
                            Id = 2,
                            CategoryId = 3,
                            CreatedDate = new DateTime(2024, 5, 12, 20, 49, 21, 973, DateTimeKind.Local).AddTicks(6709),
                            Description = "Minima quam qui gitti voluptatem.",
                            IsDeleted = true,
                            Title = "Qui dolayı."
                        },
                        new
                        {
                            Id = 3,
                            CategoryId = 4,
                            CreatedDate = new DateTime(2024, 5, 12, 20, 49, 21, 973, DateTimeKind.Local).AddTicks(6782),
                            Description = "Makinesi patlıcan çarpan ve mutlu.",
                            IsDeleted = false,
                            Title = "Layıkıyla."
                        });
                });

            modelBuilder.Entity("TemplateApi.Domain.Entities.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("BrandId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Discount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("BrandId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            BrandId = 1,
                            CreatedDate = new DateTime(2024, 5, 12, 20, 49, 21, 983, DateTimeKind.Local).AddTicks(657),
                            Description = "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit",
                            Discount = 2.949099923474650m,
                            IsDeleted = false,
                            Price = 560.64m,
                            Title = "Sleek Rubber Car"
                        },
                        new
                        {
                            Id = 2,
                            BrandId = 3,
                            CreatedDate = new DateTime(2024, 5, 12, 20, 49, 21, 983, DateTimeKind.Local).AddTicks(765),
                            Description = "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit",
                            Discount = 8.6775840422910m,
                            IsDeleted = false,
                            Price = 639.11m,
                            Title = "Practical Wooden Pizza"
                        });
                });

            modelBuilder.Entity("TemplateApi.Domain.Entities.ProductCategory", b =>
                {
                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.HasKey("ProductId", "CategoryId");

                    b.HasIndex("CategoryId");

                    b.ToTable("ProductCategories");
                });

            modelBuilder.Entity("TemplateApi.Domain.Entities.Detail", b =>
                {
                    b.HasOne("TemplateApi.Domain.Entities.Category", "Category")
                        .WithMany("Details")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("TemplateApi.Domain.Entities.Product", b =>
                {
                    b.HasOne("TemplateApi.Domain.Entities.Brand", "Brand")
                        .WithMany()
                        .HasForeignKey("BrandId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Brand");
                });

            modelBuilder.Entity("TemplateApi.Domain.Entities.ProductCategory", b =>
                {
                    b.HasOne("TemplateApi.Domain.Entities.Category", "Category")
                        .WithMany("ProductCategories")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TemplateApi.Domain.Entities.Product", "Product")
                        .WithMany("ProductCategories")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("TemplateApi.Domain.Entities.Category", b =>
                {
                    b.Navigation("Details");

                    b.Navigation("ProductCategories");
                });

            modelBuilder.Entity("TemplateApi.Domain.Entities.Product", b =>
                {
                    b.Navigation("ProductCategories");
                });
#pragma warning restore 612, 618
        }
    }
}