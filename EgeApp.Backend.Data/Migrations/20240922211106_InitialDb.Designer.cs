﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using EgeApp.Backend.Data;

#nullable disable

namespace EgeApp.Backend.Data.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20240922211106_InitialDb")]
    partial class InitialDb
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.7");

            modelBuilder.Entity("EgeApp.Backend.Entity.Concrete.Cart", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Carts");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedDate = new DateTime(2024, 9, 23, 0, 11, 6, 212, DateTimeKind.Local).AddTicks(1100),
                            UserId = "1"
                        },
                        new
                        {
                            Id = 2,
                            CreatedDate = new DateTime(2024, 9, 23, 0, 11, 6, 212, DateTimeKind.Local).AddTicks(1100),
                            UserId = "2"
                        },
                        new
                        {
                            Id = 3,
                            CreatedDate = new DateTime(2024, 9, 23, 0, 11, 6, 212, DateTimeKind.Local).AddTicks(1110),
                            UserId = "3"
                        },
                        new
                        {
                            Id = 4,
                            CreatedDate = new DateTime(2024, 9, 23, 0, 11, 6, 212, DateTimeKind.Local).AddTicks(1110),
                            UserId = "4"
                        },
                        new
                        {
                            Id = 5,
                            CreatedDate = new DateTime(2024, 9, 23, 0, 11, 6, 212, DateTimeKind.Local).AddTicks(1110),
                            UserId = "5"
                        },
                        new
                        {
                            Id = 6,
                            CreatedDate = new DateTime(2024, 9, 23, 0, 11, 6, 212, DateTimeKind.Local).AddTicks(1110),
                            UserId = "6"
                        });
                });

            modelBuilder.Entity("EgeApp.Backend.Entity.Concrete.CartItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("CartId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("TEXT");

                    b.Property<int>("ProductId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Quantity")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("CartId");

                    b.HasIndex("ProductId");

                    b.ToTable("CartItems");
                });

            modelBuilder.Entity("EgeApp.Backend.Entity.Concrete.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("CreatedDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT")
                        .HasDefaultValueSql("date('now')");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("TEXT");

                    b.Property<bool>("IsActive")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("ModifiedDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT")
                        .HasDefaultValueSql("date('now')");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("TEXT");

                    b.Property<string>("Url")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Categories", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedDate = new DateTime(2024, 9, 23, 0, 11, 6, 212, DateTimeKind.Local).AddTicks(2450),
                            Description = "Genel kategori",
                            IsActive = true,
                            ModifiedDate = new DateTime(2024, 9, 23, 0, 11, 6, 212, DateTimeKind.Local).AddTicks(2450),
                            Name = "Genel",
                            Url = "genel"
                        },
                        new
                        {
                            Id = 2,
                            CreatedDate = new DateTime(2024, 9, 23, 0, 11, 6, 212, DateTimeKind.Local).AddTicks(2460),
                            Description = "Telefonlar",
                            IsActive = true,
                            ModifiedDate = new DateTime(2024, 9, 23, 0, 11, 6, 212, DateTimeKind.Local).AddTicks(2460),
                            Name = "Telefon",
                            Url = "telefon"
                        },
                        new
                        {
                            Id = 3,
                            CreatedDate = new DateTime(2024, 9, 23, 0, 11, 6, 212, DateTimeKind.Local).AddTicks(2460),
                            Description = "Elektronik ürünler",
                            IsActive = true,
                            ModifiedDate = new DateTime(2024, 9, 23, 0, 11, 6, 212, DateTimeKind.Local).AddTicks(2460),
                            Name = "Elektronik",
                            Url = "elektronik"
                        },
                        new
                        {
                            Id = 4,
                            CreatedDate = new DateTime(2024, 9, 23, 0, 11, 6, 212, DateTimeKind.Local).AddTicks(2460),
                            Description = "Bilgisayarlar",
                            IsActive = true,
                            ModifiedDate = new DateTime(2024, 9, 23, 0, 11, 6, 212, DateTimeKind.Local).AddTicks(2460),
                            Name = "Bilgisayar",
                            Url = "bilgisayar"
                        },
                        new
                        {
                            Id = 5,
                            CreatedDate = new DateTime(2024, 9, 23, 0, 11, 6, 212, DateTimeKind.Local).AddTicks(2470),
                            Description = "Beyaz Eşyalar",
                            IsActive = true,
                            ModifiedDate = new DateTime(2024, 9, 23, 0, 11, 6, 212, DateTimeKind.Local).AddTicks(2470),
                            Name = "Beyaz Eşya",
                            Url = "beyaz-esya"
                        },
                        new
                        {
                            Id = 6,
                            CreatedDate = new DateTime(2024, 9, 23, 0, 11, 6, 212, DateTimeKind.Local).AddTicks(2470),
                            Description = "Yurt dışından gelen ürünler",
                            IsActive = false,
                            ModifiedDate = new DateTime(2024, 9, 23, 0, 11, 6, 212, DateTimeKind.Local).AddTicks(2470),
                            Name = "Yurt Dışı",
                            Url = "yurt-disi"
                        });
                });

            modelBuilder.Entity("EgeApp.Backend.Entity.Concrete.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("OrderDate")
                        .HasColumnType("TEXT");

                    b.Property<int>("OrderState")
                        .HasColumnType("INTEGER");

                    b.Property<int>("PaymentType")
                        .HasColumnType("INTEGER");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("EgeApp.Backend.Entity.Concrete.OrderItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("OrderId")
                        .HasColumnType("INTEGER");

                    b.Property<decimal>("Price")
                        .HasColumnType("TEXT");

                    b.Property<int>("ProductId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Quantity")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("OrderId");

                    b.HasIndex("ProductId");

                    b.ToTable("OrderItems");
                });

            modelBuilder.Entity("EgeApp.Backend.Entity.Concrete.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("CategoryId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<bool>("IsActive")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("IsHome")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("TEXT");

                    b.Property<decimal>("Price")
                        .HasColumnType("TEXT");

                    b.Property<string>("Properties")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Url")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Products", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryId = 2,
                            CreatedDate = new DateTime(2024, 9, 23, 0, 11, 6, 212, DateTimeKind.Local).AddTicks(3230),
                            ImageUrl = "http://localhost:5200/images/products/1.png",
                            IsActive = true,
                            IsHome = true,
                            ModifiedDate = new DateTime(2024, 9, 23, 0, 11, 6, 212, DateTimeKind.Local).AddTicks(3230),
                            Name = "IPhone 14",
                            Price = 59000m,
                            Properties = "Harika bir telefon",
                            Url = "iphone-14"
                        },
                        new
                        {
                            Id = 2,
                            CategoryId = 2,
                            CreatedDate = new DateTime(2024, 9, 23, 0, 11, 6, 212, DateTimeKind.Local).AddTicks(3230),
                            ImageUrl = "http://localhost:5200/images/products/2.png",
                            IsActive = true,
                            IsHome = false,
                            ModifiedDate = new DateTime(2024, 9, 23, 0, 11, 6, 212, DateTimeKind.Local).AddTicks(3230),
                            Name = "IPhone 14 Pro",
                            Price = 69000m,
                            Properties = "Bu da harika bir telefon",
                            Url = "iphone-14-pro"
                        },
                        new
                        {
                            Id = 3,
                            CategoryId = 2,
                            CreatedDate = new DateTime(2024, 9, 23, 0, 11, 6, 212, DateTimeKind.Local).AddTicks(3240),
                            ImageUrl = "http://localhost:5200/images/products/3.png",
                            IsActive = true,
                            IsHome = true,
                            ModifiedDate = new DateTime(2024, 9, 23, 0, 11, 6, 212, DateTimeKind.Local).AddTicks(3240),
                            Name = "Samsung S23",
                            Price = 49000m,
                            Properties = "İdare eder",
                            Url = "samsung-s23"
                        },
                        new
                        {
                            Id = 4,
                            CategoryId = 2,
                            CreatedDate = new DateTime(2024, 9, 23, 0, 11, 6, 212, DateTimeKind.Local).AddTicks(3240),
                            ImageUrl = "http://localhost:5200/images/products/4.png",
                            IsActive = true,
                            IsHome = true,
                            ModifiedDate = new DateTime(2024, 9, 23, 0, 11, 6, 212, DateTimeKind.Local).AddTicks(3240),
                            Name = "Xaomi Note 4",
                            Price = 39000m,
                            Properties = "Harika bir telefon",
                            Url = "xaomi-note-4"
                        },
                        new
                        {
                            Id = 5,
                            CategoryId = 4,
                            CreatedDate = new DateTime(2024, 9, 23, 0, 11, 6, 212, DateTimeKind.Local).AddTicks(3250),
                            ImageUrl = "http://localhost:5200/images/products/5.png",
                            IsActive = true,
                            IsHome = true,
                            ModifiedDate = new DateTime(2024, 9, 23, 0, 11, 6, 212, DateTimeKind.Local).AddTicks(3250),
                            Name = "MacBook Air M2",
                            Price = 52000m,
                            Properties = "M2nin gücü",
                            Url = "macbook-air-m2"
                        },
                        new
                        {
                            Id = 6,
                            CategoryId = 4,
                            CreatedDate = new DateTime(2024, 9, 23, 0, 11, 6, 212, DateTimeKind.Local).AddTicks(3250),
                            ImageUrl = "http://localhost:5200/images/products/6.png",
                            IsActive = true,
                            IsHome = false,
                            ModifiedDate = new DateTime(2024, 9, 23, 0, 11, 6, 212, DateTimeKind.Local).AddTicks(3250),
                            Name = "MacBook Pro M3",
                            Price = 79000m,
                            Properties = "16 Gb ram",
                            Url = "macbook-pro-m3"
                        },
                        new
                        {
                            Id = 7,
                            CategoryId = 5,
                            CreatedDate = new DateTime(2024, 9, 23, 0, 11, 6, 212, DateTimeKind.Local).AddTicks(3260),
                            ImageUrl = "http://localhost:5200/images/products/7.png",
                            IsActive = true,
                            IsHome = true,
                            ModifiedDate = new DateTime(2024, 9, 23, 0, 11, 6, 212, DateTimeKind.Local).AddTicks(3260),
                            Name = "Vestel Çamaşır Makinesi X65",
                            Price = 19000m,
                            Properties = "Akıllı makine",
                            Url = "vestel-camasir-makinesi-x65"
                        },
                        new
                        {
                            Id = 8,
                            CategoryId = 5,
                            CreatedDate = new DateTime(2024, 9, 23, 0, 11, 6, 212, DateTimeKind.Local).AddTicks(3260),
                            ImageUrl = "http://localhost:5200/images/products/8.png",
                            IsActive = true,
                            IsHome = false,
                            ModifiedDate = new DateTime(2024, 9, 23, 0, 11, 6, 212, DateTimeKind.Local).AddTicks(3260),
                            Name = "Arçelik Çamaşır Makinesi A-4",
                            Price = 21000m,
                            Properties = "Süper hızlı makine",
                            Url = "arcelik-camasir-makinesi-a-4"
                        },
                        new
                        {
                            Id = 9,
                            CategoryId = 3,
                            CreatedDate = new DateTime(2024, 9, 23, 0, 11, 6, 212, DateTimeKind.Local).AddTicks(3270),
                            ImageUrl = "http://localhost:5200/images/products/9.png",
                            IsActive = true,
                            IsHome = true,
                            ModifiedDate = new DateTime(2024, 9, 23, 0, 11, 6, 212, DateTimeKind.Local).AddTicks(3270),
                            Name = "Hoop Dijital Radyo X96",
                            Price = 1250m,
                            Properties = "Klasik radyo keyfi",
                            Url = "hoop-dijital-radyo-x96"
                        },
                        new
                        {
                            Id = 10,
                            CategoryId = 3,
                            CreatedDate = new DateTime(2024, 9, 23, 0, 11, 6, 212, DateTimeKind.Local).AddTicks(3270),
                            ImageUrl = "http://localhost:5200/images/products/10.png",
                            IsActive = true,
                            IsHome = true,
                            ModifiedDate = new DateTime(2024, 9, 23, 0, 11, 6, 212, DateTimeKind.Local).AddTicks(3270),
                            Name = "Xaomi Dijital Baskül",
                            Price = 2100m,
                            Properties = "Kilonuzu kontrol edin",
                            Url = "xaomi-dijital-baskul"
                        },
                        new
                        {
                            Id = 11,
                            CategoryId = 3,
                            CreatedDate = new DateTime(2024, 9, 23, 0, 11, 6, 212, DateTimeKind.Local).AddTicks(3280),
                            ImageUrl = "http://localhost:5200/images/products/11.png",
                            IsActive = true,
                            IsHome = true,
                            ModifiedDate = new DateTime(2024, 9, 23, 0, 11, 6, 212, DateTimeKind.Local).AddTicks(3280),
                            Name = "Blaupunkt AC69 Led TV",
                            Price = 9800m,
                            Properties = "Android tv",
                            Url = "blaupunkt-ac69-led-tv"
                        });
                });

            modelBuilder.Entity("EgeApp.Backend.Entity.Concrete.CartItem", b =>
                {
                    b.HasOne("EgeApp.Backend.Entity.Concrete.Cart", null)
                        .WithMany("CartItems")
                        .HasForeignKey("CartId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EgeApp.Backend.Entity.Concrete.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");
                });

            modelBuilder.Entity("EgeApp.Backend.Entity.Concrete.OrderItem", b =>
                {
                    b.HasOne("EgeApp.Backend.Entity.Concrete.Order", "Order")
                        .WithMany("OrderItems")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EgeApp.Backend.Entity.Concrete.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Order");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("EgeApp.Backend.Entity.Concrete.Product", b =>
                {
                    b.HasOne("EgeApp.Backend.Entity.Concrete.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("EgeApp.Backend.Entity.Concrete.Cart", b =>
                {
                    b.Navigation("CartItems");
                });

            modelBuilder.Entity("EgeApp.Backend.Entity.Concrete.Order", b =>
                {
                    b.Navigation("OrderItems");
                });
#pragma warning restore 612, 618
        }
    }
}
