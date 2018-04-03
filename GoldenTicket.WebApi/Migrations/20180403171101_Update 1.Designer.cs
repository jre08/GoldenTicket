﻿// <auto-generated />
using GoldenTicket.WebApi.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;

namespace GoldenTicket.WebApi.Migrations
{
    [DbContext(typeof(GoldenTicketContext))]
    [Migration("20180403171101_Update 1")]
    partial class Update1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.1-rtm-125");

            modelBuilder.Entity("GoldenTicket.WebApi.Models.Client", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Address");

                    b.Property<string>("Company");

                    b.Property<DateTime>("DateAdded");

                    b.Property<string>("EmailAddress");

                    b.Property<string>("FirstName");

                    b.Property<string>("LastName");

                    b.Property<string>("PhoneNumber");

                    b.HasKey("Id");

                    b.ToTable("Clients");
                });

            modelBuilder.Entity("GoldenTicket.WebApi.Models.Technician", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("DateAdded");

                    b.Property<bool>("IsAdmin");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Technicians");
                });

            modelBuilder.Entity("GoldenTicket.WebApi.Models.TechnicianTicketTime", b =>
                {
                    b.Property<Guid>("TechnicianId");

                    b.Property<Guid>("TicketId");

                    b.Property<DateTime>("End");

                    b.Property<DateTime>("Start");

                    b.HasKey("TechnicianId", "TicketId");

                    b.ToTable("TechnicianTicketTimes");
                });

            modelBuilder.Entity("GoldenTicket.WebApi.Models.Ticket", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid>("ClientId");

                    b.Property<int>("Complexity");

                    b.Property<DateTime>("DateAdded");

                    b.Property<string>("Description");

                    b.Property<bool>("IsUrgent");

                    b.Property<string>("Notes");

                    b.Property<bool>("Open");

                    b.Property<string>("Title");

                    b.HasKey("Id");

                    b.ToTable("Tickets");
                });
#pragma warning restore 612, 618
        }
    }
}
