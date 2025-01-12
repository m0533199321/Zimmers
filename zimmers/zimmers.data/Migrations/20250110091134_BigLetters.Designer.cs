﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using zimmers.data;

#nullable disable

namespace zimmers.data.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20250110091134_BigLetters")]
    partial class BigLetters
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.36")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("zimmers.core.Entities.Cleaner", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Bank_account")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Date_registration")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Total_for_an_hour_of_work")
                        .HasColumnType("int");

                    b.Property<int>("Total_salary")
                        .HasColumnType("int");

                    b.Property<int>("Total_working_hours")
                        .HasColumnType("int");

                    b.Property<string>("Tz")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Cleaners");
                });

            modelBuilder.Entity("zimmers.core.Entities.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("Num_of_nights")
                        .HasColumnType("int");

                    b.Property<DateTime>("Starting_date")
                        .HasColumnType("datetime2");

                    b.Property<int>("Total_sum")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<int>("ZimmerId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.HasIndex("ZimmerId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("zimmers.core.Entities.Owner", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Bank_account")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Date_registration")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Tz")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Owners");
                });

            modelBuilder.Entity("zimmers.core.Entities.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Bank_account")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Date_registration")
                        .HasColumnType("datetime2");

                    b.Property<int>("Max_amount_per_night")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Num_of_orders")
                        .HasColumnType("int");

                    b.Property<int>("Num_of_persons")
                        .HasColumnType("int");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Tz")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("zimmers.core.Entities.Zimmer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CleanerId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Num_of_beds")
                        .HasColumnType("int");

                    b.Property<int>("Num_of_nights_rented")
                        .HasColumnType("int");

                    b.Property<int>("Num_of_rooms")
                        .HasColumnType("int");

                    b.Property<int>("OwnerId")
                        .HasColumnType("int");

                    b.Property<int>("Total_per_night")
                        .HasColumnType("int");

                    b.Property<bool>("Yard_and_pool")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("CleanerId");

                    b.HasIndex("OwnerId");

                    b.ToTable("Zimmers");
                });

            modelBuilder.Entity("zimmers.core.Entities.Order", b =>
                {
                    b.HasOne("zimmers.core.Entities.User", "User")
                        .WithMany("List_orders")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("zimmers.core.Entities.Zimmer", "Zimmer")
                        .WithMany("List_orders")
                        .HasForeignKey("ZimmerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");

                    b.Navigation("Zimmer");
                });

            modelBuilder.Entity("zimmers.core.Entities.Zimmer", b =>
                {
                    b.HasOne("zimmers.core.Entities.Cleaner", "cleaner")
                        .WithMany("List_zimmers")
                        .HasForeignKey("CleanerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("zimmers.core.Entities.Owner", "owner")
                        .WithMany("List_zimmers")
                        .HasForeignKey("OwnerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("cleaner");

                    b.Navigation("owner");
                });

            modelBuilder.Entity("zimmers.core.Entities.Cleaner", b =>
                {
                    b.Navigation("List_zimmers");
                });

            modelBuilder.Entity("zimmers.core.Entities.Owner", b =>
                {
                    b.Navigation("List_zimmers");
                });

            modelBuilder.Entity("zimmers.core.Entities.User", b =>
                {
                    b.Navigation("List_orders");
                });

            modelBuilder.Entity("zimmers.core.Entities.Zimmer", b =>
                {
                    b.Navigation("List_orders");
                });
#pragma warning restore 612, 618
        }
    }
}