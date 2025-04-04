﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SmallAplicationWithEF;

#nullable disable

namespace SmallAplicationWithEF.Migrations
{
    [DbContext(typeof(MyDbContext))]
    [Migration("20250404095332_AddedSecondClass1Test")]
    partial class AddedSecondClass1Test
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "9.0.3");

            modelBuilder.Entity("SmallAplicationWithEF.Person", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("PLZ")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int?>("WorkersId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("WorkersId");

                    b.ToTable("Items");
                });

            modelBuilder.Entity("SmallAplicationWithEF.Workers", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("Wrappers");
                });

            modelBuilder.Entity("SmallAplicationWithEF.Person", b =>
                {
                    b.HasOne("SmallAplicationWithEF.Workers", null)
                        .WithMany("workers")
                        .HasForeignKey("WorkersId");
                });

            modelBuilder.Entity("SmallAplicationWithEF.Workers", b =>
                {
                    b.Navigation("workers");
                });
#pragma warning restore 612, 618
        }
    }
}
