﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RentFlats.Infrastructure.Persistance;

#nullable disable

namespace RentFlats.Infrastructure.Migrations
{
    [DbContext(typeof(RentFlatsDbContext))]
    [Migration("20240522094405_Init2")]
    partial class Init2
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("RentFlats.Domain.Entities.Flat", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("AddressId")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<int?>("ContactDetailsId")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EncodedTitle")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("FlatArea")
                        .HasColumnType("int");

                    b.Property<int?>("Price")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("AddressId")
                        .IsUnique();

                    b.HasIndex("ContactDetailsId")
                        .IsUnique();

                    b.ToTable("Flats");
                });

            modelBuilder.Entity("RentFlats.Domain.Entities.FlatAddress", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FlatNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PostalCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Street")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("FlatAddress");
                });

            modelBuilder.Entity("RentFlats.Domain.Entities.FlatContactDetails", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("FlatContactDetails");
                });

            modelBuilder.Entity("RentFlats.Domain.Entities.Flat", b =>
                {
                    b.HasOne("RentFlats.Domain.Entities.FlatAddress", "Address")
                        .WithOne("Flat")
                        .HasForeignKey("RentFlats.Domain.Entities.Flat", "AddressId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RentFlats.Domain.Entities.FlatContactDetails", "ContactDetails")
                        .WithOne("Flat")
                        .HasForeignKey("RentFlats.Domain.Entities.Flat", "ContactDetailsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Address");

                    b.Navigation("ContactDetails");
                });

            modelBuilder.Entity("RentFlats.Domain.Entities.FlatAddress", b =>
                {
                    b.Navigation("Flat")
                        .IsRequired();
                });

            modelBuilder.Entity("RentFlats.Domain.Entities.FlatContactDetails", b =>
                {
                    b.Navigation("Flat")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}