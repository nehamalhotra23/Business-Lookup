﻿// <auto-generated />
using Business.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Business.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079");

            modelBuilder.Entity("Business.Models.Restaurant", b =>
                {
                    b.Property<int>("RestaurantId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("RestaurantAddress");

                    b.Property<string>("RestaurantName");

                    b.HasKey("RestaurantId");

                    b.ToTable("Restaurants");
                });

            modelBuilder.Entity("Business.Models.Review", b =>
                {
                    b.Property<int>("ReviewId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Blurb")
                        .HasMaxLength(255);

                    b.Property<int>("RestaurantId");

                    b.Property<int>("ShopId");

                    b.Property<int>("UserId");

                    b.HasKey("ReviewId");

                    b.HasIndex("RestaurantId");

                    b.HasIndex("ShopId");

                    b.HasIndex("UserId");

                    b.ToTable("Reviews");
                });

            modelBuilder.Entity("Business.Models.Shop", b =>
                {
                    b.Property<int>("ShopId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ShopAddress");

                    b.Property<string>("ShopName");

                    b.HasKey("ShopId");

                    b.ToTable("Shop");
                });

            modelBuilder.Entity("Business.Models.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("UserName")
                        .IsRequired();

                    b.HasKey("UserId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Business.Models.Review", b =>
                {
                    b.HasOne("Business.Models.Restaurant")
                        .WithMany("Reviews")
                        .HasForeignKey("RestaurantId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Business.Models.Shop")
                        .WithMany("Reviews")
                        .HasForeignKey("ShopId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Business.Models.User")
                        .WithMany("Reviews")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}