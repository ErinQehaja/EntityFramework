﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SmallAplicationWithEF;

#nullable disable

namespace SmallAplicationWithEF.Migrations
{
    [DbContext(typeof(MyDbContext))]
    partial class MyDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
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

                    b.ToTable("Workers");
                });

            modelBuilder.Entity("SmallAplicationWithEF.Person", b =>
                {
                    b.HasOne("SmallAplicationWithEF.Workers", "Workers")
                        .WithMany("Persons")
                        .HasForeignKey("WorkersId");

                    b.Navigation("Workers");
                });

            modelBuilder.Entity("SmallAplicationWithEF.Workers", b =>
                {
                    b.Navigation("Persons");
                });
#pragma warning restore 612, 618
        }
    }
}
