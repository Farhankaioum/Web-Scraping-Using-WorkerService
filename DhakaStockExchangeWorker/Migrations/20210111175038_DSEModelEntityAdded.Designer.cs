﻿// <auto-generated />
using System;
using DhakaStockExchangeWorker;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DhakaStockExchangeWorker.Migrations
{
    [DbContext(typeof(WorkerContext))]
    [Migration("20210111175038_DSEModelEntityAdded")]
    partial class DSEModelEntityAdded
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("DhakaStockExchangeWorker.DSEModel", b =>
                {
                    b.Property<Guid>("SerialNo")
                        .HasColumnType("uniqueidentifier");

                    b.Property<double>("Change")
                        .HasColumnType("float");

                    b.Property<double>("Closep")
                        .HasColumnType("float");

                    b.Property<double>("High")
                        .HasColumnType("float");

                    b.Property<long>("Id")
                        .HasColumnType("bigint");

                    b.Property<double>("LTP")
                        .HasColumnType("float");

                    b.Property<double>("Low")
                        .HasColumnType("float");

                    b.Property<long>("Trade")
                        .HasColumnType("bigint");

                    b.Property<string>("TrandingCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Value")
                        .HasColumnType("float");

                    b.Property<long>("Volume")
                        .HasColumnType("bigint");

                    b.Property<double>("YCP")
                        .HasColumnType("float");

                    b.HasKey("SerialNo");

                    b.ToTable("DSEModels");
                });
#pragma warning restore 612, 618
        }
    }
}
