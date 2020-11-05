﻿// <auto-generated />
using System;
using AsinTransientAndApartment.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace AsinTransientAndApartment.Migrations
{
    [DbContext(typeof(ReservationDBContext))]
    [Migration("20200217161724_contactNumberUpdate")]
    partial class contactNumberUpdate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.14-servicing-32113")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("AsinTransientAndApartment.Models.Guest", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    //b.Property<string>("Comment");

                    b.Property<string>("ContactNumber");

                    b.Property<int>("NumberOfHead");

                    b.Property<string>("FirstName");

                    b.Property<string>("LastName");

                    b.Property<int>("NumberOfNight");

                    b.HasKey("Id");

                    b.ToTable("guests");
                });

            modelBuilder.Entity("AsinTransientAndApartment.Models.Reservation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CheckInDate");

                    b.Property<DateTime>("CheckInTime");

                    b.Property<DateTime>("CheckOutDate");

                    b.Property<DateTime>("CheckOutTime");

                    b.Property<string>("Comment");

                    b.Property<int>("CustomerId");

                    b.Property<int>("NumberOfGuest");

                    b.Property<int>("ProcessedBy");

                    b.Property<DateTime>("ProcessedDate");

                    b.Property<int>("RoomId");

                    b.HasKey("Id");

                    b.ToTable("reservations");
                });

            modelBuilder.Entity("AsinTransientAndApartment.Models.Room", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Amount");

                    b.Property<int>("Capacity");

                    b.Property<int>("RoomNo");

                    b.Property<int>("Status");

                    b.Property<int>("Type");

                    b.Property<DateTime>("VacantDate");

                    b.HasKey("Id");

                    b.ToTable("rooms");
                });

            modelBuilder.Entity("AsinTransientAndApartment.Models.Status", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("statuses");
                });

            modelBuilder.Entity("AsinTransientAndApartment.Models.Type", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("types");
                });

            modelBuilder.Entity("AsinTransientAndApartment.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Comment");

                    b.Property<string>("Password");

                    b.Property<int>("Role");

                    b.Property<int>("Status");

                    b.Property<string>("UserName");

                    b.HasKey("Id");

                    b.ToTable("users");
                });

            modelBuilder.Entity("UserRole", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("userRoles");
                });
#pragma warning restore 612, 618
        }
    }
}
