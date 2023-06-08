﻿// <auto-generated />
using System;
using M2W5Assessment.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace M2W5Assessment.Migrations
{
    [DbContext(typeof(ConcertContext))]
    partial class ConcertContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.15")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("ConcertPerformer", b =>
                {
                    b.Property<int>("ConcertsId")
                        .HasColumnType("integer")
                        .HasColumnName("concerts_id");

                    b.Property<int>("PerformersId")
                        .HasColumnType("integer")
                        .HasColumnName("performers_id");

                    b.HasKey("ConcertsId", "PerformersId")
                        .HasName("pk_concert_performer");

                    b.HasIndex("PerformersId")
                        .HasDatabaseName("ix_concert_performer_performers_id");

                    b.ToTable("concert_performer", (string)null);
                });

            modelBuilder.Entity("M2W5Assessment.Concert", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("name");

                    b.Property<DateTime>("ShowDate")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("show_date");

                    b.HasKey("Id")
                        .HasName("pk_concerts");

                    b.ToTable("concerts", (string)null);
                });

            modelBuilder.Entity("M2W5Assessment.Performer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("ActDescription")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("act_description");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("name");

                    b.HasKey("Id")
                        .HasName("pk_performer");

                    b.ToTable("performer", (string)null);
                });

            modelBuilder.Entity("ConcertPerformer", b =>
                {
                    b.HasOne("M2W5Assessment.Concert", null)
                        .WithMany()
                        .HasForeignKey("ConcertsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_concert_performer_concerts_concerts_id");

                    b.HasOne("M2W5Assessment.Performer", null)
                        .WithMany()
                        .HasForeignKey("PerformersId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_concert_performer_performer_performers_id");
                });
#pragma warning restore 612, 618
        }
    }
}
