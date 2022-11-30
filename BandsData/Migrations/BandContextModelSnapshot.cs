﻿// <auto-generated />
using System;
using BandsData.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BandsData.Migrations
{
    [DbContext(typeof(BandContext))]
    partial class BandContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("BandsData.Models.Band", b =>
                {
                    b.Property<int?>("BandId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("founded")
                        .HasColumnType("int");

                    b.Property<string>("genre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("members")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("notableWorks")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("origin")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("BandId");

                    b.ToTable("Bands");

                    b.HasData(
                        new
                        {
                            BandId = 1,
                            founded = 1965,
                            genre = "Progressive Rock",
                            members = "Syd Barrett, Roger Waters, Richard Wright, David Gilmour, Nick Mason",
                            name = "Pink Floyd",
                            notableWorks = "Dark Side of the Moon, Another Brick in the Wall, Wish You Were Here",
                            origin = "London, England"
                        },
                        new
                        {
                            BandId = 2,
                            founded = 1968,
                            genre = "Hard Rock",
                            members = "Jimmy Page, Robert Plant, John Bonham, John Paul Jones",
                            name = "Led Zeppelin",
                            notableWorks = "Stairway to Heaven, Immigrant Song, Kashmir",
                            origin = "London, England"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
