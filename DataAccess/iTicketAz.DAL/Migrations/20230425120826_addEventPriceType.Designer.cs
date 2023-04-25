﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using iTicketAz.DAL.Contexts;

#nullable disable

namespace iTicketAz.DAL.Migrations
{
    [DbContext(typeof(ITicketAzDbContext))]
    [Migration("20230425120826_addEventPriceType")]
    partial class addEventPriceType
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("EventPriceType", b =>
                {
                    b.Property<int>("EventsId")
                        .HasColumnType("integer");

                    b.Property<int>("PriceTypesId")
                        .HasColumnType("integer");

                    b.HasKey("EventsId", "PriceTypesId");

                    b.HasIndex("PriceTypesId");

                    b.ToTable("EventPriceType");
                });

            modelBuilder.Entity("iTicketAz.DAL.Entities.Cart", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("CartInfo")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("PromoCode")
                        .HasColumnType("text");

                    b.Property<int>("Total")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.ToTable("Carts");

                    b.HasDiscriminator<string>("CartInfo").HasValue("Cart");

                    b.UseTphMappingStrategy();
                });

            modelBuilder.Entity("iTicketAz.DAL.Entities.EnumKey", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Key")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("EnumKeys");
                });

            modelBuilder.Entity("iTicketAz.DAL.Entities.EnumValue", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("KeyId")
                        .HasColumnType("integer");

                    b.Property<string>("Value")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("KeyId");

                    b.ToTable("EnumValues");
                });

            modelBuilder.Entity("iTicketAz.DAL.Entities.Event", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("About")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("AgeRestrictionId")
                        .HasColumnType("integer");

                    b.Property<DateTime>("End")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("LanguageId")
                        .HasColumnType("integer");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("Start")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.HasIndex("AgeRestrictionId");

                    b.HasIndex("LanguageId");

                    b.ToTable("Events");
                });

            modelBuilder.Entity("iTicketAz.DAL.Entities.Place", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("Capacity")
                        .HasColumnType("integer");

                    b.Property<TimeOnly>("Close")
                        .HasColumnType("time without time zone");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<TimeOnly>("Open")
                        .HasColumnType("time without time zone");

                    b.HasKey("Id");

                    b.ToTable("Places");
                });

            modelBuilder.Entity("iTicketAz.DAL.Entities.PriceType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("Price")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.ToTable("PriceTypes");
                });

            modelBuilder.Entity("iTicketAz.DAL.Entities.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("iTicketAz.DAL.Entities.CartUserData", b =>
                {
                    b.HasBaseType("iTicketAz.DAL.Entities.Cart");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("Phone")
                        .HasColumnType("integer");

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasDiscriminator().HasValue("UserData");
                });

            modelBuilder.Entity("iTicketAz.DAL.Entities.CartUserId", b =>
                {
                    b.HasBaseType("iTicketAz.DAL.Entities.Cart");

                    b.Property<int?>("UserId")
                        .HasColumnType("integer");

                    b.HasIndex("UserId");

                    b.HasDiscriminator().HasValue("UserId");
                });

            modelBuilder.Entity("EventPriceType", b =>
                {
                    b.HasOne("iTicketAz.DAL.Entities.Event", null)
                        .WithMany()
                        .HasForeignKey("EventsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("iTicketAz.DAL.Entities.PriceType", null)
                        .WithMany()
                        .HasForeignKey("PriceTypesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("iTicketAz.DAL.Entities.EnumValue", b =>
                {
                    b.HasOne("iTicketAz.DAL.Entities.EnumKey", null)
                        .WithMany()
                        .HasForeignKey("KeyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("iTicketAz.DAL.Entities.Event", b =>
                {
                    b.HasOne("iTicketAz.DAL.Entities.EnumValue", null)
                        .WithMany()
                        .HasForeignKey("AgeRestrictionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("iTicketAz.DAL.Entities.EnumValue", null)
                        .WithMany()
                        .HasForeignKey("LanguageId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("iTicketAz.DAL.Entities.CartUserId", b =>
                {
                    b.HasOne("iTicketAz.DAL.Entities.User", null)
                        .WithMany()
                        .HasForeignKey("UserId");
                });
#pragma warning restore 612, 618
        }
    }
}
