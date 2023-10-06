﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WA_06_CoreAndFood.Data.Models;

namespace WA_06_CoreAndFood.Migrations
{
    [DbContext(typeof(Context))]
    partial class ContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.14-servicing-32113")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("WA_06_CoreAndFood.Data.Models.Admin", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AdminRole")
                        .HasMaxLength(1);

                    b.Property<string>("Password")
                        .HasMaxLength(20);

                    b.Property<string>("UserName")
                        .HasMaxLength(20);

                    b.HasKey("ID");

                    b.ToTable("Admins");
                });

            modelBuilder.Entity("WA_06_CoreAndFood.Data.Models.Category", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.Property<bool>("Status");

                    b.HasKey("ID");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("WA_06_CoreAndFood.Data.Models.Food", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CategoryID");

                    b.Property<string>("Description");

                    b.Property<string>("ImageURL");

                    b.Property<string>("Name");

                    b.Property<double>("Price");

                    b.Property<int>("Stock");

                    b.HasKey("ID");

                    b.HasIndex("CategoryID");

                    b.ToTable("Foods");
                });

            modelBuilder.Entity("WA_06_CoreAndFood.Data.Models.Food", b =>
                {
                    b.HasOne("WA_06_CoreAndFood.Data.Models.Category", "Category")
                        .WithMany("Foods")
                        .HasForeignKey("CategoryID")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
