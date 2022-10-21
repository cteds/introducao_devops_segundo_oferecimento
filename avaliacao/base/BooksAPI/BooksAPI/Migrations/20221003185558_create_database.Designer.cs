﻿// <auto-generated />
using BooksAPI.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BooksAPI.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20221003185558_create_database")]
    partial class create_database
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("BooksAPI.Domains.Author", b =>
                {
                    b.Property<int>("AuthorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AuthorId"), 1L, 1);

                    b.Property<string>("Birthdate")
                        .IsRequired()
                        .HasColumnType("VARCHAR(150)");

                    b.Property<string>("Deathdate")
                        .IsRequired()
                        .HasColumnType("VARCHAR(150)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("VARCHAR(150)");

                    b.HasKey("AuthorId");

                    b.HasIndex("Name")
                        .IsUnique();

                    b.ToTable("Authors");

                    b.HasData(
                        new
                        {
                            AuthorId = 1,
                            Birthdate = "15/08/1954",
                            Deathdate = "09/11/2004",
                            Name = "Stieg Larsson"
                        },
                        new
                        {
                            AuthorId = 2,
                            Birthdate = "25/06/1903",
                            Deathdate = "21/01/1950",
                            Name = "George Orwell"
                        });
                });

            modelBuilder.Entity("BooksAPI.Domains.Book", b =>
                {
                    b.Property<int>("BookId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("BookId"), 1L, 1);

                    b.Property<int>("AuthorId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("VARCHAR(150)");

                    b.Property<string>("Pages")
                        .IsRequired()
                        .HasColumnType("VARCHAR(10)");

                    b.Property<string>("PublicationYear")
                        .IsRequired()
                        .HasColumnType("VARCHAR(4)");

                    b.HasKey("BookId");

                    b.HasIndex("AuthorId");

                    b.ToTable("Books");

                    b.HasData(
                        new
                        {
                            BookId = 1,
                            AuthorId = 1,
                            Name = "Os homens que não amavam as mulheres (Millennium #1)",
                            Pages = "522",
                            PublicationYear = "2008"
                        },
                        new
                        {
                            BookId = 2,
                            AuthorId = 2,
                            Name = "A Revolução dos Bichos",
                            Pages = "152",
                            PublicationYear = "2007"
                        });
                });

            modelBuilder.Entity("BooksAPI.Domains.Book", b =>
                {
                    b.HasOne("BooksAPI.Domains.Author", "Author")
                        .WithMany("Books")
                        .HasForeignKey("AuthorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Author");
                });

            modelBuilder.Entity("BooksAPI.Domains.Author", b =>
                {
                    b.Navigation("Books");
                });
#pragma warning restore 612, 618
        }
    }
}