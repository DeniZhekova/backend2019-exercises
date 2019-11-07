﻿// <auto-generated />
using System;
using MbmStore.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace MbmStore.Migrations
{
    [DbContext(typeof(MbmStoreContext))]
    partial class MbmStoreContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MbmStore.Models.Customer", b =>
                {
                    b.Property<int>("CustomerId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address");

                    b.Property<DateTime>("Birthdate")
                        .HasColumnType("datetime2");

                    b.Property<string>("City");

                    b.Property<string>("Email");

                    b.Property<string>("Firstname");

                    b.Property<string>("Lastname");

                    b.Property<string>("Zip");

                    b.HasKey("CustomerId");

                    b.ToTable("Customer");

                    b.HasData(
                        new { CustomerId = 1, Address = "Irisdahlsvej 32", Birthdate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), City = "Århus N", Firstname = "Tina", Lastname = "Petterson", Zip = "8200" },
                        new { CustomerId = 2, Address = "Solsikkevej 32", Birthdate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), City = "Århus C", Firstname = "Thomas", Lastname = "Larsson", Zip = "8000" }
                    );
                });

            modelBuilder.Entity("MbmStore.Models.Invoice", b =>
                {
                    b.Property<int>("InvoiceId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CustomerId");

                    b.Property<DateTime>("OrderDate")
                        .HasColumnType("datetime2");

                    b.HasKey("InvoiceId");

                    b.HasIndex("CustomerId");

                    b.ToTable("Invoice");

                    b.HasData(
                        new { InvoiceId = 1, CustomerId = 1, OrderDate = new DateTime(2018, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                        new { InvoiceId = 2, CustomerId = 2, OrderDate = new DateTime(2018, 9, 18, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                    );
                });

            modelBuilder.Entity("MbmStore.Models.OrderItem", b =>
                {
                    b.Property<int>("OrderItemId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("InvoiceId");

                    b.Property<int>("ProductId");

                    b.Property<int>("Quantity");

                    b.HasKey("OrderItemId");

                    b.HasIndex("InvoiceId");

                    b.HasIndex("ProductId");

                    b.ToTable("OrderItem");

                    b.HasData(
                        new { OrderItemId = 1, InvoiceId = 1, ProductId = 7, Quantity = 1 },
                        new { OrderItemId = 2, InvoiceId = 1, ProductId = 2, Quantity = 1 },
                        new { OrderItemId = 3, InvoiceId = 2, ProductId = 1, Quantity = 1 },
                        new { OrderItemId = 4, InvoiceId = 2, ProductId = 3, Quantity = 1 }
                    );
                });

            modelBuilder.Entity("MbmStore.Models.Phone", b =>
                {
                    b.Property<int>("PhoneId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CustomerId");

                    b.Property<string>("Number");

                    b.HasKey("PhoneId");

                    b.HasIndex("CustomerId");

                    b.ToTable("Phone");
                });

            modelBuilder.Entity("MbmStore.Models.Product", b =>
                {
                    b.Property<int>("ProductId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Category");

                    b.Property<string>("Discriminator")
                        .IsRequired();

                    b.Property<string>("ImageUrl");

                    b.Property<decimal>("Price");

                    b.Property<string>("Title");

                    b.HasKey("ProductId");

                    b.ToTable("Product");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Product");
                });

            modelBuilder.Entity("MbmStore.Models.Track", b =>
                {
                    b.Property<int>("TrackId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Composer");

                    b.Property<TimeSpan>("Length");

                    b.Property<int>("ProductId");

                    b.Property<string>("Title");

                    b.HasKey("TrackId");

                    b.HasIndex("ProductId");

                    b.ToTable("Track");

                    b.HasData(
                        new { TrackId = 1, Composer = "Lennon, McCartney", Length = new TimeSpan(0, 0, 4, 20, 0), ProductId = 3, Title = "Come Together" },
                        new { TrackId = 2, Composer = "Harrison", Length = new TimeSpan(0, 0, 3, 3, 0), ProductId = 3, Title = "Something" },
                        new { TrackId = 3, Composer = "Lennon, McCartney", Length = new TimeSpan(0, 0, 3, 29, 0), ProductId = 3, Title = "Maxwell's Silver Hammer" },
                        new { TrackId = 4, Composer = "Lennon, McCartney", Length = new TimeSpan(0, 0, 3, 26, 0), ProductId = 3, Title = "Oh! Darling" },
                        new { TrackId = 5, Composer = "Starkey", Length = new TimeSpan(0, 0, 2, 51, 0), ProductId = 3, Title = "Octopus's Garden" },
                        new { TrackId = 6, Composer = "Lennon, McCartney", Length = new TimeSpan(0, 0, 7, 47, 0), ProductId = 3, Title = "I Want You (She's So Heavy)" },
                        new { TrackId = 7, Composer = "Harrison", Length = new TimeSpan(0, 0, 3, 5, 0), ProductId = 3, Title = "Here Comes The Sun" },
                        new { TrackId = 8, Composer = "Lennon, McCartney", Length = new TimeSpan(0, 0, 2, 45, 0), ProductId = 3, Title = "Because" },
                        new { TrackId = 9, Composer = "Lennon, McCartney", Length = new TimeSpan(0, 0, 4, 2, 0), ProductId = 3, Title = "You Never Give Me Your Money" },
                        new { TrackId = 10, Composer = "Lennon, McCartney", Length = new TimeSpan(0, 0, 2, 26, 0), ProductId = 3, Title = "Sun King" },
                        new { TrackId = 11, Composer = "Lennon, McCartney", Length = new TimeSpan(0, 0, 1, 6, 0), ProductId = 3, Title = "Mean Mr. Mustard" },
                        new { TrackId = 12, Composer = "Lennon, McCartney", Length = new TimeSpan(0, 0, 1, 12, 0), ProductId = 3, Title = "Polythene Pam" },
                        new { TrackId = 13, Composer = "Lennon, McCartney", Length = new TimeSpan(0, 0, 1, 57, 0), ProductId = 3, Title = "She Came In Through The Bathroom Window" },
                        new { TrackId = 14, Composer = "Lennon, McCartney", Length = new TimeSpan(0, 0, 1, 31, 0), ProductId = 3, Title = "Golden Slumbers" },
                        new { TrackId = 15, Composer = "Lennon, McCartney", Length = new TimeSpan(0, 0, 1, 36, 0), ProductId = 3, Title = "Carry That Weight" },
                        new { TrackId = 16, Composer = "Lennon, McCartney", Length = new TimeSpan(0, 0, 2, 19, 0), ProductId = 3, Title = "The End" },
                        new { TrackId = 17, Composer = "Lennon, McCartney", Length = new TimeSpan(0, 0, 0, 23, 0), ProductId = 3, Title = "Her Majesty" },
                        new { TrackId = 18, Composer = "Harrison", Length = new TimeSpan(0, 0, 2, 28, 0), ProductId = 4, Title = "Taxman" },
                        new { TrackId = 19, Composer = "Lennon, McCartney", Length = new TimeSpan(0, 0, 2, 6, 0), ProductId = 4, Title = "Eleanor Rigby" },
                        new { TrackId = 20, Composer = "Lennon, McCartney", Length = new TimeSpan(0, 0, 3, 0, 0), ProductId = 4, Title = "I'm Only Sleeping" },
                        new { TrackId = 21, Composer = "Harrison", Length = new TimeSpan(0, 0, 2, 59, 0), ProductId = 4, Title = "Love You To" },
                        new { TrackId = 22, Composer = "Harrison", Length = new TimeSpan(0, 0, 2, 23, 0), ProductId = 4, Title = "Here, There And Everywhere" },
                        new { TrackId = 23, Composer = "Lennon, McCartney", Length = new TimeSpan(0, 0, 2, 38, 0), ProductId = 4, Title = "Yellow Submarine" },
                        new { TrackId = 24, Composer = "Lennon, McCartney", Length = new TimeSpan(0, 0, 2, 36, 0), ProductId = 4, Title = "She Said She Said" },
                        new { TrackId = 25, Composer = "Lennon, McCartney", Length = new TimeSpan(0, 0, 2, 9, 0), ProductId = 4, Title = "Good Day Sunshine" },
                        new { TrackId = 26, Composer = "Lennon, McCartney", Length = new TimeSpan(0, 0, 2, 0, 0), ProductId = 4, Title = "And Your Bird Can Sing" },
                        new { TrackId = 27, Composer = "Lennon, McCartney", Length = new TimeSpan(0, 0, 1, 59, 0), ProductId = 4, Title = "For No One" },
                        new { TrackId = 28, Composer = "Lennon, McCartney", Length = new TimeSpan(0, 0, 1, 14, 0), ProductId = 4, Title = "Doctor Robert" },
                        new { TrackId = 29, Composer = "Harrison", Length = new TimeSpan(0, 0, 2, 27, 0), ProductId = 4, Title = "I Want To Tell You" },
                        new { TrackId = 30, Composer = "Lennon, McCartney", Length = new TimeSpan(0, 0, 2, 29, 0), ProductId = 4, Title = "Got To Get You Into My Life" },
                        new { TrackId = 31, Composer = "Lennon, McCartney", Length = new TimeSpan(0, 0, 3, 1, 0), ProductId = 4, Title = "Tomorrow Newer Knows" }
                    );
                });

            modelBuilder.Entity("MbmStore.Models.Book", b =>
                {
                    b.HasBaseType("MbmStore.Models.Product");

                    b.Property<string>("Author");

                    b.Property<string>("ISBN");

                    b.Property<short>("Published");

                    b.Property<string>("Publisher");

                    b.ToTable("Book");

                    b.HasDiscriminator().HasValue("Book");

                    b.HasData(
                        new { ProductId = 1, Category = "Book", ImageUrl = "A_Hard_Days_Write.jpg", Price = 150.00m, Title = "A Hard Day's Write: The Stories Behind Every Beatles Song ", Author = "Steve Turner", ISBN = "978-0060844097", Published = (short)2005, Publisher = "It Books" },
                        new { ProductId = 2, Category = "Book", ImageUrl = "The Making of Sgt. Pepper.jpg", Price = 180.00m, Title = "With a Little Help from My Friends: The Making of Sgt. Pepper", Author = "Georg Martin", ISBN = "0316547832", Published = (short)1995, Publisher = "Little Brown & Co" }
                    );
                });

            modelBuilder.Entity("MbmStore.Models.Movie", b =>
                {
                    b.HasBaseType("MbmStore.Models.Product");

                    b.Property<string>("Director");

                    b.Property<short>("Released");

                    b.ToTable("Movie");

                    b.HasDiscriminator().HasValue("Movie");

                    b.HasData(
                        new { ProductId = 5, Category = "Movie", ImageUrl = "junglebook.jpg", Price = 160.50m, Title = "Jungle Book", Director = "Jon Favreau", Released = (short)0 },
                        new { ProductId = 6, Category = "Movie", ImageUrl = "gladiator.jpg", Price = 49.95m, Title = "Gladiator", Director = "Ridley Scott", Released = (short)0 },
                        new { ProductId = 7, Category = "Movie", ImageUrl = "forrest-gump.jpg", Price = 160.50m, Title = "Forrest Gump", Director = "Robert Zemeckis", Released = (short)0 }
                    );
                });

            modelBuilder.Entity("MbmStore.Models.MusicCD", b =>
                {
                    b.HasBaseType("MbmStore.Models.Product");

                    b.Property<string>("Artist");

                    b.Property<string>("Label");

                    b.Property<short>("Released")
                        .HasColumnName("MusicCD_Released");

                    b.ToTable("MusicCD");

                    b.HasDiscriminator().HasValue("MusicCD");

                    b.HasData(
                        new { ProductId = 3, Category = "Music", ImageUrl = "abbey_road.jpg", Price = 128.00m, Title = "Abbey Road (Remastered)", Artist = "Beatles", Label = "EMI", Released = (short)2009 },
                        new { ProductId = 4, Category = "Music", ImageUrl = "revolver.jpg", Price = 128.00m, Title = "Revolver (Remastered)", Artist = "The Beatles", Label = "EMI", Released = (short)2009 }
                    );
                });

            modelBuilder.Entity("MbmStore.Models.Invoice", b =>
                {
                    b.HasOne("MbmStore.Models.Customer", "Customer")
                        .WithMany("Invoices")
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("MbmStore.Models.OrderItem", b =>
                {
                    b.HasOne("MbmStore.Models.Invoice")
                        .WithMany("OrderItems")
                        .HasForeignKey("InvoiceId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("MbmStore.Models.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("MbmStore.Models.Phone", b =>
                {
                    b.HasOne("MbmStore.Models.Customer", "Customer")
                        .WithMany("PhoneNumbers")
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("MbmStore.Models.Track", b =>
                {
                    b.HasOne("MbmStore.Models.MusicCD")
                        .WithMany("Tracks")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
