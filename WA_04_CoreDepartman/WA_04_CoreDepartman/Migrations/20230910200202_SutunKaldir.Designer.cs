﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WA_04_CoreDepartman.Models;

namespace WA_04_CoreDepartman.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20230910200202_SutunKaldir")]
    partial class SutunKaldir
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.14-servicing-32113")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("WA_04_CoreDepartman.Models.Departman", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Ad");

                    b.HasKey("ID");

                    b.ToTable("Departmen");
                });

            modelBuilder.Entity("WA_04_CoreDepartman.Models.Personel", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Ad");

                    b.Property<string>("Sehir");

                    b.Property<string>("Soyad");

                    b.HasKey("ID");

                    b.ToTable("Personels");
                });
#pragma warning restore 612, 618
        }
    }
}
