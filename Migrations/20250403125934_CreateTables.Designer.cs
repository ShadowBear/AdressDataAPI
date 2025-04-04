﻿// <auto-generated />
using AdressDataAPI.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace AdressDataAPI.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20250403125934_CreateTables")]
    partial class CreateTables
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("AdressDataAPI.Models.Address", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("AddressStatus")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Aktenzeichen")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("AktuelleAnschrift")
                        .HasColumnType("bit");

                    b.Property<string>("Anrede")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Datenquelle")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("FileID")
                        .HasColumnType("int");

                    b.Property<string>("Hausnummer")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Import")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Land")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nachname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Ort")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PLZ")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Rechtsform")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Straße")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Titel")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Vorname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Addresses");
                });

            modelBuilder.Entity("AdressDataAPI.Models.ContactInfo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Anmerkung")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("FileID")
                        .HasColumnType("int");

                    b.Property<string>("Gehoert")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImportDatum")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Kommunikationsadresse")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Typ")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Contacts");
                });
#pragma warning restore 612, 618
        }
    }
}
