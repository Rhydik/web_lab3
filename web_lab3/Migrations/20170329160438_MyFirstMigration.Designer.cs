using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using web_lab3.Models;

namespace web_lab3.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    [Migration("20170329160438_MyFirstMigration")]
    partial class MyFirstMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.1");

            modelBuilder.Entity("web_lab3.Models.Room", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<double>("cubeSide");

                    b.Property<string>("description")
                        .IsRequired();

                    b.Property<double>("latitude");

                    b.Property<double>("longitude");

                    b.Property<string>("title")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("Rooms");
                });

            modelBuilder.Entity("web_lab3.Models.Wall", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("description")
                        .IsRequired();

                    b.Property<string>("imageURL")
                        .IsRequired();

                    b.Property<int>("roomID");

                    b.Property<int>("roomType");

                    b.Property<string>("title")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("roomID");

                    b.ToTable("Walls");
                });

            modelBuilder.Entity("web_lab3.Models.Wall", b =>
                {
                    b.HasOne("web_lab3.Models.Room", "room")
                        .WithMany()
                        .HasForeignKey("roomID")
                        .OnDelete(DeleteBehavior.Cascade);
                });
        }
    }
}
