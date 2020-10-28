﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TravelApi.Models;

namespace TravelApi.Migrations
{
    [DbContext(typeof(TravelApiContext))]
    [Migration("20201028181748_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("TravelApi.Models.Review", b =>
                {
                    b.Property<int>("ReviewId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("City")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.Property<string>("Country")
                        .IsRequired();

                    b.Property<string>("Destination");

                    b.Property<int>("Rating");

                    b.Property<string>("ReviewDetails")
                        .IsRequired();

                    b.HasKey("ReviewId");

                    b.ToTable("Reviews");

                    b.HasData(
                        new
                        {
                            ReviewId = 1,
                            City = "Seattle",
                            Country = "USA",
                            Destination = "Pike Place Market",
                            Rating = 3,
                            ReviewDetails = "Eh"
                        },
                        new
                        {
                            ReviewId = 2,
                            City = "Portland",
                            Country = "USA",
                            Destination = "Rose Garden",
                            Rating = 3,
                            ReviewDetails = "Crazy people"
                        },
                        new
                        {
                            ReviewId = 6,
                            City = "Portland",
                            Country = "USA",
                            Destination = "Rose Garden",
                            Rating = 2,
                            ReviewDetails = "Crazy people"
                        },
                        new
                        {
                            ReviewId = 3,
                            City = "Maui",
                            Country = "USA",
                            Destination = "Sandy beaches",
                            Rating = 5,
                            ReviewDetails = "Fun"
                        },
                        new
                        {
                            ReviewId = 4,
                            City = "Cape Town",
                            Country = "South Africa",
                            Destination = "soccer stadium",
                            Rating = 4,
                            ReviewDetails = "Nice"
                        },
                        new
                        {
                            ReviewId = 5,
                            City = "Beijing",
                            Country = "China",
                            Destination = "Forbidden City",
                            Rating = 1,
                            ReviewDetails = "Ugh"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
