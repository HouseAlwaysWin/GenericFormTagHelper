﻿// <auto-generated />
using GenericTagHelperExample.Data;
using GenericTagHelperExample.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;

namespace GenericTagHelperExample.Data.Migrations
{
    [DbContext(typeof(GenericDbContext))]
    [Migration("20170827084448_AddCustomerSeedData")]
    partial class AddCustomerSeedData
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.0-rtm-26452")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("GenericTagHelperExample.Models.Customer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("GenericTagHelperExample.Models.FormModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("CheckBox");

                    b.Property<DateTime>("DateTimeTextBox");

                    b.Property<string>("EmailTextBox");

                    b.Property<int>("LevelSelectList");

                    b.Property<string>("PasswordTextBox");

                    b.Property<int>("SelectRadio");

                    b.Property<string>("TextBox");

                    b.Property<byte[]>("Upload");

                    b.HasKey("Id");

                    b.ToTable("FormModels");
                });

            modelBuilder.Entity("GenericTagHelperExample.Models.RadioBox", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("FormModelId");

                    b.Property<int?>("FormModelId1");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.HasIndex("FormModelId");

                    b.HasIndex("FormModelId1");

                    b.ToTable("RadioBox");
                });

            modelBuilder.Entity("GenericTagHelperExample.Models.RadioBox", b =>
                {
                    b.HasOne("GenericTagHelperExample.Models.FormModel")
                        .WithMany("RadioBoxList")
                        .HasForeignKey("FormModelId");

                    b.HasOne("GenericTagHelperExample.Models.FormModel")
                        .WithMany("RadioBoxList2")
                        .HasForeignKey("FormModelId1");
                });
#pragma warning restore 612, 618
        }
    }
}
