﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using categorysubCategoryTreeview.Models;

namespace categorysubCategoryTreeview.Migrations
{
    [DbContext(typeof(CatDbContext))]
    [Migration("20210831085948_init")]
    partial class init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.9")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("categorysubCategoryTreeview.Models.Category", b =>
                {
                    b.Property<int>("CatId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CategoryName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ParentCategory")
                        .HasColumnType("int");

                    b.HasKey("CatId");

                    b.HasIndex("ParentCategory");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("categorysubCategoryTreeview.Models.Category", b =>
                {
                    b.HasOne("categorysubCategoryTreeview.Models.Category", "category")
                        .WithMany("Categories")
                        .HasForeignKey("ParentCategory");

                    b.Navigation("category");
                });

            modelBuilder.Entity("categorysubCategoryTreeview.Models.Category", b =>
                {
                    b.Navigation("Categories");
                });
#pragma warning restore 612, 618
        }
    }
}
