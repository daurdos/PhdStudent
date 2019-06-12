﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Phd.Models;

namespace Phd.Migrations
{
    [DbContext(typeof(PhdContext))]
    partial class PhdContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.11-servicing-32099")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Phd.Models.PhdStudent", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("DisNameEng");

                    b.Property<string>("DisNameKaz");

                    b.Property<string>("DisNameRus");

                    b.Property<string>("Fname");

                    b.Property<string>("Lname");

                    b.Property<string>("MajName");

                    b.Property<string>("MajorCode");

                    b.Property<string>("Mname");

                    b.Property<DateTime>("ReleaseDate");

                    b.HasKey("Id");

                    b.ToTable("PhdStudent");
                });

            modelBuilder.Entity("Phd.Models.Vote", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("PhdStudentId");

                    b.Property<int?>("PhdStudentId1");

                    b.Property<string>("Voice");

                    b.HasKey("Id");

                    b.HasIndex("PhdStudentId1");

                    b.ToTable("Vote");
                });

            modelBuilder.Entity("Phd.Models.Vote", b =>
                {
                    b.HasOne("Phd.Models.PhdStudent", "PhdStudent")
                        .WithMany("Vote")
                        .HasForeignKey("PhdStudentId1");
                });
#pragma warning restore 612, 618
        }
    }
}
