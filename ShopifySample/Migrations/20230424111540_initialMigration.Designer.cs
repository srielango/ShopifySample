﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ShopifySample.Entities;

#nullable disable

namespace ShopifySample.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20230424111540_initialMigration")]
    partial class initialMigration
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ShopifySample.Entities.Shopify_Product", b =>
                {
                    b.Property<long>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("ID"));

                    b.HasKey("ID");

                    b.ToTable("Shopify_Products");
                });

            modelBuilder.Entity("ShopifySample.Entities.Shopify_ProductImage", b =>
                {
                    b.Property<long>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("ID"));

                    b.Property<long>("Shopify_ProductID")
                        .HasColumnType("bigint");

                    b.HasKey("ID");

                    b.HasIndex("Shopify_ProductID");

                    b.ToTable("Shopify_ProductImages");
                });

            modelBuilder.Entity("ShopifySample.Entities.Shopify_ProductOption", b =>
                {
                    b.Property<long>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("ID"));

                    b.Property<long>("Shopify_ProductID")
                        .HasColumnType("bigint");

                    b.HasKey("ID");

                    b.HasIndex("Shopify_ProductID");

                    b.ToTable("Shopify_ProductOptions");
                });

            modelBuilder.Entity("ShopifySample.Entities.Shopify_Product_Variant", b =>
                {
                    b.Property<long>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("ID"));

                    b.Property<long>("Shopify_ProductID")
                        .HasColumnType("bigint");

                    b.HasKey("ID");

                    b.HasIndex("Shopify_ProductID");

                    b.ToTable("Shopify_Product_Variants");
                });

            modelBuilder.Entity("ShopifySample.Entities.Shopify_ProductImage", b =>
                {
                    b.HasOne("ShopifySample.Entities.Shopify_Product", "Shopify_Product")
                        .WithMany("Images")
                        .HasForeignKey("Shopify_ProductID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Shopify_Product");
                });

            modelBuilder.Entity("ShopifySample.Entities.Shopify_ProductOption", b =>
                {
                    b.HasOne("ShopifySample.Entities.Shopify_Product", "Shopify_Product")
                        .WithMany("Options")
                        .HasForeignKey("Shopify_ProductID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Shopify_Product");
                });

            modelBuilder.Entity("ShopifySample.Entities.Shopify_Product_Variant", b =>
                {
                    b.HasOne("ShopifySample.Entities.Shopify_Product", "Shopify_Product")
                        .WithMany("Variants")
                        .HasForeignKey("Shopify_ProductID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Shopify_Product");
                });

            modelBuilder.Entity("ShopifySample.Entities.Shopify_Product", b =>
                {
                    b.Navigation("Images");

                    b.Navigation("Options");

                    b.Navigation("Variants");
                });
#pragma warning restore 612, 618
        }
    }
}