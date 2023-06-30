﻿// <auto-generated />
using System;
using BookManagementSystem.DAL.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BookManagementSystem.Migrations
{
    [DbContext(typeof(BookManagementDB))]
    partial class BookManagementDBModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.19")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("BookManagementSystem.Entities.Concrete.Author", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("AuthorID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeathDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("AuthorName");

                    b.HasKey("ID");

                    b.ToTable("Authors");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            BirthDate = new DateTime(1965, 3, 3, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "J.K.Rowling"
                        },
                        new
                        {
                            ID = 2,
                            BirthDate = new DateTime(1564, 4, 26, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DeathDate = new DateTime(1616, 4, 23, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "William Shakespeare"
                        },
                        new
                        {
                            ID = 3,
                            BirthDate = new DateTime(1775, 11, 16, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DeathDate = new DateTime(1817, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Jane Austen"
                        },
                        new
                        {
                            ID = 4,
                            BirthDate = new DateTime(1892, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DeathDate = new DateTime(1973, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "J.R.R. Tolkien"
                        },
                        new
                        {
                            ID = 5,
                            BirthDate = new DateTime(1890, 9, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DeathDate = new DateTime(1976, 1, 12, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Agatha Christie"
                        },
                        new
                        {
                            ID = 6,
                            BirthDate = new DateTime(1902, 2, 27, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DeathDate = new DateTime(1968, 12, 20, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "John Steinbeck"
                        });
                });

            modelBuilder.Entity("BookManagementSystem.Entities.Concrete.Book", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("BookID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<int?>("AuthorID")
                        .HasColumnType("int");

                    b.Property<int?>("CategoryID")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("BookName");

                    b.Property<int>("PageCount")
                        .HasColumnType("int");

                    b.Property<DateTime>("PublicationDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("PublisherID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("AuthorID");

                    b.HasIndex("CategoryID");

                    b.HasIndex("PublisherID");

                    b.ToTable("Books");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            AuthorID = 2,
                            CategoryID = 1,
                            Name = "Hamlet",
                            PageCount = 320,
                            PublicationDate = new DateTime(1603, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            PublisherID = 1
                        },
                        new
                        {
                            ID = 2,
                            AuthorID = 3,
                            CategoryID = 1,
                            Name = "Pride and Prejudice",
                            PageCount = 432,
                            PublicationDate = new DateTime(1813, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            PublisherID = 1
                        },
                        new
                        {
                            ID = 3,
                            AuthorID = 4,
                            CategoryID = 2,
                            Name = "The Lord of the Rings",
                            PageCount = 1178,
                            PublicationDate = new DateTime(1954, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            PublisherID = 2
                        },
                        new
                        {
                            ID = 4,
                            AuthorID = 5,
                            CategoryID = 3,
                            Name = "Murder on the Orient Express",
                            PageCount = 256,
                            PublicationDate = new DateTime(1934, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            PublisherID = 2
                        },
                        new
                        {
                            ID = 5,
                            AuthorID = 1,
                            CategoryID = 2,
                            Name = "Harry Potter and the Philosopher's Stone",
                            PageCount = 223,
                            PublicationDate = new DateTime(1997, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            PublisherID = 3
                        },
                        new
                        {
                            ID = 6,
                            AuthorID = 6,
                            CategoryID = 1,
                            Name = "The Grapes of Wrath",
                            PageCount = 464,
                            PublicationDate = new DateTime(1939, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            PublisherID = 1
                        });
                });

            modelBuilder.Entity("BookManagementSystem.Entities.Concrete.Category", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("CategoryID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(1000)
                        .HasColumnType("nvarchar(1000)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("CategoryName");

                    b.HasKey("ID");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            Description = "Fictional prose narrative of considerable length, typically representing characters and actions in a realistic way.",
                            Name = "Novel"
                        },
                        new
                        {
                            ID = 2,
                            Description = "Genre of speculative fiction that typically deals with imaginative and futuristic concepts, often incorporating advanced science and technology.",
                            Name = "Science Fiction"
                        },
                        new
                        {
                            ID = 3,
                            Description = "Genre of fiction that involves solving a mysterious event or crime and usually creates a sense of suspense and excitement.",
                            Name = "Mystery and Thriller"
                        },
                        new
                        {
                            ID = 4,
                            Description = "Genre of fiction that takes place in the past and often incorporates real historical events, figures, or settings while incorporating fictional elements.",
                            Name = "Historical Fiction"
                        },
                        new
                        {
                            ID = 5,
                            Description = "Account of a person's life written by someone else, providing a detailed description of the person's experiences, achievements, and challenges.",
                            Name = "Biography"
                        });
                });

            modelBuilder.Entity("BookManagementSystem.Entities.Concrete.Publisher", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("PublisherID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<DateTime>("FoundationDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("PublisherName");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("varchar(15)");

                    b.HasKey("ID");

                    b.ToTable("Publishers");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            Address = "Penguin Classics, 80 Strand, London, WC2R 0RL, United Kingdom",
                            FoundationDate = new DateTime(1946, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Penguin Classics",
                            Phone = "+4402031226000"
                        },
                        new
                        {
                            ID = 2,
                            Address = "HarperCollins Publishers, 195 Broadway, New York, NY 10007, United States",
                            FoundationDate = new DateTime(1817, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "HarperCollins Publishers",
                            Phone = "+12122077000"
                        },
                        new
                        {
                            ID = 3,
                            Address = "Bloomsbury Publishing, 50 Bedford Square, London, WC1B 3DP, United Kingdom",
                            FoundationDate = new DateTime(1986, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Bloomsbury Publishing",
                            Phone = "+4402076315600"
                        });
                });

            modelBuilder.Entity("BookManagementSystem.Entities.Concrete.Book", b =>
                {
                    b.HasOne("BookManagementSystem.Entities.Concrete.Author", "Author")
                        .WithMany("Books")
                        .HasForeignKey("AuthorID")
                        .OnDelete(DeleteBehavior.SetNull);

                    b.HasOne("BookManagementSystem.Entities.Concrete.Category", "Category")
                        .WithMany("Books")
                        .HasForeignKey("CategoryID")
                        .OnDelete(DeleteBehavior.SetNull);

                    b.HasOne("BookManagementSystem.Entities.Concrete.Publisher", "Publisher")
                        .WithMany("Books")
                        .HasForeignKey("PublisherID")
                        .OnDelete(DeleteBehavior.SetNull);

                    b.Navigation("Author");

                    b.Navigation("Category");

                    b.Navigation("Publisher");
                });

            modelBuilder.Entity("BookManagementSystem.Entities.Concrete.Author", b =>
                {
                    b.Navigation("Books");
                });

            modelBuilder.Entity("BookManagementSystem.Entities.Concrete.Category", b =>
                {
                    b.Navigation("Books");
                });

            modelBuilder.Entity("BookManagementSystem.Entities.Concrete.Publisher", b =>
                {
                    b.Navigation("Books");
                });
#pragma warning restore 612, 618
        }
    }
}
