﻿// <auto-generated />
using GuillermoAlvarez_EjercicioCF1.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace GuillermoAlvarez_EjercicioCF1.Migrations
{
    [DbContext(typeof(GuillermoAlvarez_EjercicioCF1Context))]
    partial class GuillermoAlvarez_EjercicioCF1ContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.21")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("GuillermoAlvarez_EjercicioCF1.Models.Burger", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<bool>("WithCheese")
                        .HasColumnType("bit");

                    b.HasKey("ID");

                    b.ToTable("Burger");
                });
#pragma warning restore 612, 618
        }
    }
}