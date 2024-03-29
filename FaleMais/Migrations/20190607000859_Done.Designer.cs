﻿// <auto-generated />
using System;
using FaleMais.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace FaleMais.Migrations
{
    [DbContext(typeof(FaleMaisContext))]
    [Migration("20190607000859_Done")]
    partial class Done
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("FaleMais.Models.Plane", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<double>("CallValue");

                    b.Property<string>("Destiny");

                    b.Property<string>("Origin");

                    b.Property<double>("PlaneCallValue");

                    b.Property<double>("PricePerMinute");

                    b.Property<int>("SpeakMorePlane");

                    b.Property<TimeSpan>("Time");

                    b.HasKey("Id");

                    b.ToTable("Plane");
                });
#pragma warning restore 612, 618
        }
    }
}
