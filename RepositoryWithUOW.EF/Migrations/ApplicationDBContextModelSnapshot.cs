﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RepositoryWithUOW.EF;

#nullable disable

namespace RepositoryWithUOW.EF.Migrations
{
    [DbContext(typeof(ApplicationDBContext))]
    partial class ApplicationDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("RepositoryWithUOW.core.Models.Country", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.ToTable("Countries");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Country1"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Country2"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Country3"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Country4"
                        },
                        new
                        {
                            Id = 5,
                            Name = "Country5"
                        },
                        new
                        {
                            Id = 6,
                            Name = "Country6"
                        },
                        new
                        {
                            Id = 7,
                            Name = "Country7"
                        },
                        new
                        {
                            Id = 8,
                            Name = "Country8"
                        },
                        new
                        {
                            Id = 9,
                            Name = "Country9"
                        },
                        new
                        {
                            Id = 10,
                            Name = "Country10"
                        },
                        new
                        {
                            Id = 11,
                            Name = "Country11"
                        },
                        new
                        {
                            Id = 12,
                            Name = "Country12"
                        },
                        new
                        {
                            Id = 13,
                            Name = "Country13"
                        },
                        new
                        {
                            Id = 14,
                            Name = "Country14"
                        },
                        new
                        {
                            Id = 15,
                            Name = "Country15"
                        },
                        new
                        {
                            Id = 16,
                            Name = "Country16"
                        },
                        new
                        {
                            Id = 17,
                            Name = "Country17"
                        },
                        new
                        {
                            Id = 18,
                            Name = "Country18"
                        },
                        new
                        {
                            Id = 19,
                            Name = "Country19"
                        },
                        new
                        {
                            Id = 20,
                            Name = "Country20"
                        },
                        new
                        {
                            Id = 21,
                            Name = "Country21"
                        },
                        new
                        {
                            Id = 22,
                            Name = "Country22"
                        },
                        new
                        {
                            Id = 23,
                            Name = "Country23"
                        },
                        new
                        {
                            Id = 24,
                            Name = "Country24"
                        },
                        new
                        {
                            Id = 25,
                            Name = "Country25"
                        },
                        new
                        {
                            Id = 26,
                            Name = "Country26"
                        },
                        new
                        {
                            Id = 27,
                            Name = "Country27"
                        },
                        new
                        {
                            Id = 28,
                            Name = "Country28"
                        },
                        new
                        {
                            Id = 29,
                            Name = "Country29"
                        },
                        new
                        {
                            Id = 30,
                            Name = "Country30"
                        },
                        new
                        {
                            Id = 31,
                            Name = "Country31"
                        },
                        new
                        {
                            Id = 32,
                            Name = "Country32"
                        },
                        new
                        {
                            Id = 33,
                            Name = "Country33"
                        },
                        new
                        {
                            Id = 34,
                            Name = "Country34"
                        },
                        new
                        {
                            Id = 35,
                            Name = "Country35"
                        },
                        new
                        {
                            Id = 36,
                            Name = "Country36"
                        },
                        new
                        {
                            Id = 37,
                            Name = "Country37"
                        },
                        new
                        {
                            Id = 38,
                            Name = "Country38"
                        },
                        new
                        {
                            Id = 39,
                            Name = "Country39"
                        },
                        new
                        {
                            Id = 40,
                            Name = "Country40"
                        },
                        new
                        {
                            Id = 41,
                            Name = "Country41"
                        },
                        new
                        {
                            Id = 42,
                            Name = "Country42"
                        },
                        new
                        {
                            Id = 43,
                            Name = "Country43"
                        },
                        new
                        {
                            Id = 44,
                            Name = "Country44"
                        },
                        new
                        {
                            Id = 45,
                            Name = "Country45"
                        },
                        new
                        {
                            Id = 46,
                            Name = "Country46"
                        },
                        new
                        {
                            Id = 47,
                            Name = "Country47"
                        },
                        new
                        {
                            Id = 48,
                            Name = "Country48"
                        },
                        new
                        {
                            Id = 49,
                            Name = "Country49"
                        },
                        new
                        {
                            Id = 50,
                            Name = "Country50"
                        },
                        new
                        {
                            Id = 51,
                            Name = "Country51"
                        },
                        new
                        {
                            Id = 52,
                            Name = "Country52"
                        },
                        new
                        {
                            Id = 53,
                            Name = "Country53"
                        },
                        new
                        {
                            Id = 54,
                            Name = "Country54"
                        },
                        new
                        {
                            Id = 55,
                            Name = "Country55"
                        },
                        new
                        {
                            Id = 56,
                            Name = "Country56"
                        },
                        new
                        {
                            Id = 57,
                            Name = "Country57"
                        },
                        new
                        {
                            Id = 58,
                            Name = "Country58"
                        },
                        new
                        {
                            Id = 59,
                            Name = "Country59"
                        },
                        new
                        {
                            Id = 60,
                            Name = "Country60"
                        },
                        new
                        {
                            Id = 61,
                            Name = "Country61"
                        },
                        new
                        {
                            Id = 62,
                            Name = "Country62"
                        },
                        new
                        {
                            Id = 63,
                            Name = "Country63"
                        },
                        new
                        {
                            Id = 64,
                            Name = "Country64"
                        },
                        new
                        {
                            Id = 65,
                            Name = "Country65"
                        },
                        new
                        {
                            Id = 66,
                            Name = "Country66"
                        },
                        new
                        {
                            Id = 67,
                            Name = "Country67"
                        },
                        new
                        {
                            Id = 68,
                            Name = "Country68"
                        },
                        new
                        {
                            Id = 69,
                            Name = "Country69"
                        },
                        new
                        {
                            Id = 70,
                            Name = "Country70"
                        },
                        new
                        {
                            Id = 71,
                            Name = "Country71"
                        },
                        new
                        {
                            Id = 72,
                            Name = "Country72"
                        },
                        new
                        {
                            Id = 73,
                            Name = "Country73"
                        },
                        new
                        {
                            Id = 74,
                            Name = "Country74"
                        },
                        new
                        {
                            Id = 75,
                            Name = "Country75"
                        },
                        new
                        {
                            Id = 76,
                            Name = "Country76"
                        },
                        new
                        {
                            Id = 77,
                            Name = "Country77"
                        },
                        new
                        {
                            Id = 78,
                            Name = "Country78"
                        },
                        new
                        {
                            Id = 79,
                            Name = "Country79"
                        },
                        new
                        {
                            Id = 80,
                            Name = "Country80"
                        },
                        new
                        {
                            Id = 81,
                            Name = "Country81"
                        },
                        new
                        {
                            Id = 82,
                            Name = "Country82"
                        },
                        new
                        {
                            Id = 83,
                            Name = "Country83"
                        },
                        new
                        {
                            Id = 84,
                            Name = "Country84"
                        },
                        new
                        {
                            Id = 85,
                            Name = "Country85"
                        },
                        new
                        {
                            Id = 86,
                            Name = "Country86"
                        },
                        new
                        {
                            Id = 87,
                            Name = "Country87"
                        },
                        new
                        {
                            Id = 88,
                            Name = "Country88"
                        },
                        new
                        {
                            Id = 89,
                            Name = "Country89"
                        },
                        new
                        {
                            Id = 90,
                            Name = "Country90"
                        },
                        new
                        {
                            Id = 91,
                            Name = "Country91"
                        },
                        new
                        {
                            Id = 92,
                            Name = "Country92"
                        },
                        new
                        {
                            Id = 93,
                            Name = "Country93"
                        },
                        new
                        {
                            Id = 94,
                            Name = "Country94"
                        },
                        new
                        {
                            Id = 95,
                            Name = "Country95"
                        },
                        new
                        {
                            Id = 96,
                            Name = "Country96"
                        },
                        new
                        {
                            Id = 97,
                            Name = "Country97"
                        },
                        new
                        {
                            Id = 98,
                            Name = "Country98"
                        },
                        new
                        {
                            Id = 99,
                            Name = "Country99"
                        },
                        new
                        {
                            Id = 100,
                            Name = "Country100"
                        });
                });

            modelBuilder.Entity("RepositoryWithUOW.core.Models.Language", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.ToTable("Languages");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Lang1"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Lang2"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Lang3"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Lang4"
                        },
                        new
                        {
                            Id = 5,
                            Name = "Lang5"
                        },
                        new
                        {
                            Id = 6,
                            Name = "Lang6"
                        },
                        new
                        {
                            Id = 7,
                            Name = "Lang7"
                        },
                        new
                        {
                            Id = 8,
                            Name = "Lang8"
                        },
                        new
                        {
                            Id = 9,
                            Name = "Lang9"
                        },
                        new
                        {
                            Id = 10,
                            Name = "Lang10"
                        },
                        new
                        {
                            Id = 11,
                            Name = "Lang11"
                        },
                        new
                        {
                            Id = 12,
                            Name = "Lang12"
                        },
                        new
                        {
                            Id = 13,
                            Name = "Lang13"
                        },
                        new
                        {
                            Id = 14,
                            Name = "Lang14"
                        },
                        new
                        {
                            Id = 15,
                            Name = "Lang15"
                        },
                        new
                        {
                            Id = 16,
                            Name = "Lang16"
                        },
                        new
                        {
                            Id = 17,
                            Name = "Lang17"
                        },
                        new
                        {
                            Id = 18,
                            Name = "Lang18"
                        },
                        new
                        {
                            Id = 19,
                            Name = "Lang19"
                        },
                        new
                        {
                            Id = 20,
                            Name = "Lang20"
                        },
                        new
                        {
                            Id = 21,
                            Name = "Lang21"
                        },
                        new
                        {
                            Id = 22,
                            Name = "Lang22"
                        },
                        new
                        {
                            Id = 23,
                            Name = "Lang23"
                        },
                        new
                        {
                            Id = 24,
                            Name = "Lang24"
                        },
                        new
                        {
                            Id = 25,
                            Name = "Lang25"
                        },
                        new
                        {
                            Id = 26,
                            Name = "Lang26"
                        },
                        new
                        {
                            Id = 27,
                            Name = "Lang27"
                        },
                        new
                        {
                            Id = 28,
                            Name = "Lang28"
                        },
                        new
                        {
                            Id = 29,
                            Name = "Lang29"
                        },
                        new
                        {
                            Id = 30,
                            Name = "Lang30"
                        },
                        new
                        {
                            Id = 31,
                            Name = "Lang31"
                        },
                        new
                        {
                            Id = 32,
                            Name = "Lang32"
                        },
                        new
                        {
                            Id = 33,
                            Name = "Lang33"
                        },
                        new
                        {
                            Id = 34,
                            Name = "Lang34"
                        },
                        new
                        {
                            Id = 35,
                            Name = "Lang35"
                        },
                        new
                        {
                            Id = 36,
                            Name = "Lang36"
                        },
                        new
                        {
                            Id = 37,
                            Name = "Lang37"
                        },
                        new
                        {
                            Id = 38,
                            Name = "Lang38"
                        },
                        new
                        {
                            Id = 39,
                            Name = "Lang39"
                        },
                        new
                        {
                            Id = 40,
                            Name = "Lang40"
                        },
                        new
                        {
                            Id = 41,
                            Name = "Lang41"
                        },
                        new
                        {
                            Id = 42,
                            Name = "Lang42"
                        },
                        new
                        {
                            Id = 43,
                            Name = "Lang43"
                        },
                        new
                        {
                            Id = 44,
                            Name = "Lang44"
                        },
                        new
                        {
                            Id = 45,
                            Name = "Lang45"
                        },
                        new
                        {
                            Id = 46,
                            Name = "Lang46"
                        },
                        new
                        {
                            Id = 47,
                            Name = "Lang47"
                        },
                        new
                        {
                            Id = 48,
                            Name = "Lang48"
                        },
                        new
                        {
                            Id = 49,
                            Name = "Lang49"
                        },
                        new
                        {
                            Id = 50,
                            Name = "Lang50"
                        },
                        new
                        {
                            Id = 51,
                            Name = "Lang51"
                        },
                        new
                        {
                            Id = 52,
                            Name = "Lang52"
                        },
                        new
                        {
                            Id = 53,
                            Name = "Lang53"
                        },
                        new
                        {
                            Id = 54,
                            Name = "Lang54"
                        },
                        new
                        {
                            Id = 55,
                            Name = "Lang55"
                        },
                        new
                        {
                            Id = 56,
                            Name = "Lang56"
                        },
                        new
                        {
                            Id = 57,
                            Name = "Lang57"
                        },
                        new
                        {
                            Id = 58,
                            Name = "Lang58"
                        },
                        new
                        {
                            Id = 59,
                            Name = "Lang59"
                        },
                        new
                        {
                            Id = 60,
                            Name = "Lang60"
                        },
                        new
                        {
                            Id = 61,
                            Name = "Lang61"
                        },
                        new
                        {
                            Id = 62,
                            Name = "Lang62"
                        },
                        new
                        {
                            Id = 63,
                            Name = "Lang63"
                        },
                        new
                        {
                            Id = 64,
                            Name = "Lang64"
                        },
                        new
                        {
                            Id = 65,
                            Name = "Lang65"
                        },
                        new
                        {
                            Id = 66,
                            Name = "Lang66"
                        },
                        new
                        {
                            Id = 67,
                            Name = "Lang67"
                        },
                        new
                        {
                            Id = 68,
                            Name = "Lang68"
                        },
                        new
                        {
                            Id = 69,
                            Name = "Lang69"
                        },
                        new
                        {
                            Id = 70,
                            Name = "Lang70"
                        },
                        new
                        {
                            Id = 71,
                            Name = "Lang71"
                        },
                        new
                        {
                            Id = 72,
                            Name = "Lang72"
                        },
                        new
                        {
                            Id = 73,
                            Name = "Lang73"
                        },
                        new
                        {
                            Id = 74,
                            Name = "Lang74"
                        },
                        new
                        {
                            Id = 75,
                            Name = "Lang75"
                        },
                        new
                        {
                            Id = 76,
                            Name = "Lang76"
                        },
                        new
                        {
                            Id = 77,
                            Name = "Lang77"
                        },
                        new
                        {
                            Id = 78,
                            Name = "Lang78"
                        },
                        new
                        {
                            Id = 79,
                            Name = "Lang79"
                        },
                        new
                        {
                            Id = 80,
                            Name = "Lang80"
                        },
                        new
                        {
                            Id = 81,
                            Name = "Lang81"
                        },
                        new
                        {
                            Id = 82,
                            Name = "Lang82"
                        },
                        new
                        {
                            Id = 83,
                            Name = "Lang83"
                        },
                        new
                        {
                            Id = 84,
                            Name = "Lang84"
                        },
                        new
                        {
                            Id = 85,
                            Name = "Lang85"
                        },
                        new
                        {
                            Id = 86,
                            Name = "Lang86"
                        },
                        new
                        {
                            Id = 87,
                            Name = "Lang87"
                        },
                        new
                        {
                            Id = 88,
                            Name = "Lang88"
                        },
                        new
                        {
                            Id = 89,
                            Name = "Lang89"
                        },
                        new
                        {
                            Id = 90,
                            Name = "Lang90"
                        },
                        new
                        {
                            Id = 91,
                            Name = "Lang91"
                        },
                        new
                        {
                            Id = 92,
                            Name = "Lang92"
                        },
                        new
                        {
                            Id = 93,
                            Name = "Lang93"
                        },
                        new
                        {
                            Id = 94,
                            Name = "Lang94"
                        },
                        new
                        {
                            Id = 95,
                            Name = "Lang95"
                        },
                        new
                        {
                            Id = 96,
                            Name = "Lang96"
                        },
                        new
                        {
                            Id = 97,
                            Name = "Lang97"
                        },
                        new
                        {
                            Id = 98,
                            Name = "Lang98"
                        },
                        new
                        {
                            Id = 99,
                            Name = "Lang99"
                        },
                        new
                        {
                            Id = 100,
                            Name = "Lang100"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}