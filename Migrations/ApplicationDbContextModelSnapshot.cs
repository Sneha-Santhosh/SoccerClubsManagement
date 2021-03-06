﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Sneha_S_301096645.Models;

namespace Sneha_S_301096645.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.11-servicing-32099")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Sneha_S_301096645.Models.ClubResponse", b =>
                {
                    b.Property<int>("ClubID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClubName")
                        .IsRequired();

                    b.Property<string>("Location")
                        .IsRequired();

                    b.Property<string>("ManagerName")
                        .IsRequired();

                    b.HasKey("ClubID");

                    b.ToTable("Clubs");
                });

            modelBuilder.Entity("Sneha_S_301096645.Models.PlayerResponse", b =>
                {
                    b.Property<int>("PlayerID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ClubID");

                    b.Property<string>("ClubName")
                        .IsRequired();

                    b.Property<bool?>("Deregister")
                        .IsRequired();

                    b.Property<string>("Email")
                        .IsRequired();

                    b.Property<string>("PlayerName")
                        .IsRequired();

                    b.HasKey("PlayerID");

                    b.ToTable("Players");
                });
#pragma warning restore 612, 618
        }
    }
}
