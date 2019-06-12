﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Phd.Models;

namespace Phd.Migrations
{
    [DbContext(typeof(PhdContext))]
    [Migration("20190610040911_Fifth")]
    partial class Fifth
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
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

                    b.Property<string>("Voice");

                    b.HasKey("Id");

                    b.ToTable("PhdStudent");
                });

            modelBuilder.Entity("Phd.Models.Vote", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("PhdStudentId");

                    b.Property<bool>("Voice");

                    b.HasKey("Id");

                    b.HasIndex("PhdStudentId");

                    b.ToTable("Vote");
                });

            modelBuilder.Entity("Phd.Models.Vote", b =>
                {
                    b.HasOne("Phd.Models.PhdStudent", "PhdStudent")
                        .WithMany()
                        .HasForeignKey("PhdStudentId");
                });
#pragma warning restore 612, 618
        }
    }
}
