﻿// <auto-generated />
using System;
using Estate_agency.data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Estate_agency.Migrations
{
    [DbContext(typeof(AppDBContent))]
    partial class AppDBContentModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.14-servicing-32113")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Estate_agency.data.Models.Apartments", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address");

                    b.Property<int?>("CategoryNameid");

                    b.Property<string>("Furniture");

                    b.Property<int>("Level");

                    b.Property<decimal>("Price")
                        .HasConversion(new ValueConverter<decimal, decimal>(v => default(decimal), v => default(decimal), new ConverterMappingHints(precision: 20, scale: 0)));

                    b.Property<string>("Square");

                    b.Property<string>("With_animals");

                    b.Property<string>("With_children");

                    b.Property<int>("idCategory");

                    b.Property<string>("img");

                    b.Property<bool>("isFavorite");

                    b.HasKey("id");

                    b.HasIndex("CategoryNameid");

                    b.ToTable("Apartments");
                });

            modelBuilder.Entity("Estate_agency.data.Models.Categorycs", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CategoryDesc");

                    b.Property<string>("CategoryName");

                    b.HasKey("id");

                    b.ToTable("Category");
                });

            modelBuilder.Entity("Estate_agency.data.Models.Apartments", b =>
                {
                    b.HasOne("Estate_agency.data.Models.Categorycs", "CategoryName")
                        .WithMany("Apartment")
                        .HasForeignKey("CategoryNameid");
                });
#pragma warning restore 612, 618
        }
    }
}
