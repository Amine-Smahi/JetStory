﻿// <auto-generated />

using ColorsAPI.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ColorsAPI.Migrations
{
  [DbContext(typeof(ColorsContext))]
  [Migration("20180212120126_init")]
  partial class init
  {
    protected override void BuildTargetModel(ModelBuilder modelBuilder)
    {
#pragma warning disable 612, 618
      modelBuilder
        .HasAnnotation("ProductVersion", "2.0.1-rtm-125");

      modelBuilder.Entity("ColorsAPI.Models.Client", b =>
      {
        b.Property<int>("Id")
          .ValueGeneratedOnAdd();

        b.Property<string>("Email");

        b.Property<string>("Name");

        b.Property<string>("Password");

        b.HasKey("Id");

        b.ToTable("Client");
      });

      modelBuilder.Entity("ColorsAPI.Models.Colors", b =>
      {
        b.Property<int>("Id")
          .ValueGeneratedOnAdd();

        b.Property<string>("BodyColor");

        b.Property<string>("Category");

        b.Property<int?>("ClientId");

        b.Property<string>("NavColor");

        b.Property<string>("Secondery");

        b.Property<string>("SubCategory");

        b.HasKey("Id");

        b.HasIndex("ClientId");

        b.ToTable("colors");
      });

      modelBuilder.Entity("ColorsAPI.Models.Colors", b =>
      {
        b.HasOne("ColorsAPI.Models.Client", "Client")
          .WithMany()
          .HasForeignKey("ClientId");
      });
#pragma warning restore 612, 618
    }
  }
}