﻿// <auto-generated />
using System;
using Cylon.Core.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace Cylon.Core.Migrations
{
    [DbContext(typeof(ApplicationContext))]
    [Migration("20181014035539_Init")]
    partial class Init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn)
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("Cylon.Data.Entity.Author", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("AddedDate");

                    b.Property<string>("Email")
                        .IsRequired();

                    b.Property<string>("FirstName")
                        .IsRequired();

                    b.Property<string>("IPAddress");

                    b.Property<string>("LastName")
                        .IsRequired();

                    b.Property<DateTime>("ModifiedDate");

                    b.HasKey("Id");

                    b.ToTable("Author");
                });

            modelBuilder.Entity("Cylon.Data.Entity.Book", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("AddedDate");

                    b.Property<long>("AuthorId");

                    b.Property<string>("IPAddress");

                    b.Property<string>("ISBN")
                        .IsRequired();

                    b.Property<DateTime>("ModifiedDate");

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<string>("Publisher")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("AuthorId");

                    b.ToTable("Book");
                });

            modelBuilder.Entity("Cylon.Data.Entity.Book", b =>
                {
                    b.HasOne("Cylon.Data.Entity.Author", "Author")
                        .WithMany("Books")
                        .HasForeignKey("AuthorId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
