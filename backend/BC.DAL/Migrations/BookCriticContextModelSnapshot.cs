﻿// <auto-generated />
using BC.DAL.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BC.DAL.Migrations
{
    [DbContext(typeof(BookCriticContext))]
    partial class BookCriticContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("BC.DAL.Entities.Book", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Author")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Cover")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Genre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("Title", "Author")
                        .IsUnique();

                    b.ToTable("Books");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Author = "Alfonzo Herzog",
                            Content = "laboriosam",
                            Cover = "https://picsum.photos/640/480/?image=61",
                            Genre = "Electronic",
                            Title = "We need to parse the online USB transmitter!"
                        },
                        new
                        {
                            Id = 2,
                            Author = "Laura Leannon",
                            Content = "nobis",
                            Cover = "https://picsum.photos/640/480/?image=749",
                            Genre = "Reggae",
                            Title = "The IB program is down, hack the neural program so we can hack the IB program!"
                        },
                        new
                        {
                            Id = 3,
                            Author = "Green Zboncak",
                            Content = "Nemo occaecati sed ut explicabo quia dignissimos consequatur cumque.\nPlaceat iusto ut ullam est aliquid omnis et nihil.\nUnde assumenda mollitia blanditiis rerum eos autem sit rerum quibusdam.",
                            Cover = "https://picsum.photos/640/480/?image=597",
                            Genre = "Metal",
                            Title = "Use the neural ADP bandwidth, then you can parse the neural bandwidth!"
                        },
                        new
                        {
                            Id = 4,
                            Author = "Dedric Turcotte",
                            Content = "Debitis est eos.",
                            Cover = "https://picsum.photos/640/480/?image=852",
                            Genre = "Pop",
                            Title = "You can't input the matrix without parsing the open-source AGP matrix!"
                        },
                        new
                        {
                            Id = 5,
                            Author = "Julius Hackett",
                            Content = "Nostrum consequatur dolores eveniet fugit a quia dolores rem ut.",
                            Cover = "https://picsum.photos/640/480/?image=78",
                            Genre = "Hip Hop",
                            Title = "You can't compress the capacitor without transmitting the redundant ADP capacitor!"
                        },
                        new
                        {
                            Id = 6,
                            Author = "Reanna Kohler",
                            Content = "autem",
                            Cover = "https://picsum.photos/640/480/?image=551",
                            Genre = "Soul",
                            Title = "The XSS circuit is down, back up the multi-byte circuit so we can back up the XSS circuit!"
                        },
                        new
                        {
                            Id = 7,
                            Author = "Lukas Gulgowski",
                            Content = "Eius vitae ducimus omnis.",
                            Cover = "https://picsum.photos/640/480/?image=551",
                            Genre = "World",
                            Title = "We need to synthesize the online FTP protocol!"
                        },
                        new
                        {
                            Id = 8,
                            Author = "Kameron Boyer",
                            Content = "nostrum",
                            Cover = "https://picsum.photos/640/480/?image=622",
                            Genre = "Rock",
                            Title = "You can't navigate the matrix without copying the multi-byte COM matrix!"
                        },
                        new
                        {
                            Id = 9,
                            Author = "Delaney Medhurst",
                            Content = "Quasi aliquid aperiam temporibus doloribus inventore et. Modi non est temporibus cum officiis sed eos. Natus ut non soluta quia fugit illo dolores. Officiis est exercitationem natus illo omnis eum qui accusantium similique.",
                            Cover = "https://picsum.photos/640/480/?image=3",
                            Genre = "Hip Hop",
                            Title = "We need to program the mobile SMS firewall!"
                        },
                        new
                        {
                            Id = 10,
                            Author = "Felton Stanton",
                            Content = "Cum aut nihil occaecati voluptatem. Libero in voluptatem. Voluptas quia eos qui aliquam rerum exercitationem excepturi. Numquam facilis laborum qui id. Laudantium architecto earum doloribus.",
                            Cover = "https://picsum.photos/640/480/?image=654",
                            Genre = "Electronic",
                            Title = "Use the redundant JBOD system, then you can index the redundant system!"
                        });
                });

            modelBuilder.Entity("BC.DAL.Entities.Rating", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("BookId")
                        .HasColumnType("int");

                    b.Property<byte>("Score")
                        .HasColumnType("tinyint");

                    b.HasKey("Id");

                    b.HasIndex("BookId");

                    b.ToTable("Ratings");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            BookId = 6,
                            Score = (byte)2
                        },
                        new
                        {
                            Id = 2,
                            BookId = 8,
                            Score = (byte)1
                        },
                        new
                        {
                            Id = 3,
                            BookId = 6,
                            Score = (byte)3
                        },
                        new
                        {
                            Id = 4,
                            BookId = 4,
                            Score = (byte)1
                        },
                        new
                        {
                            Id = 5,
                            BookId = 9,
                            Score = (byte)1
                        },
                        new
                        {
                            Id = 6,
                            BookId = 5,
                            Score = (byte)1
                        },
                        new
                        {
                            Id = 7,
                            BookId = 5,
                            Score = (byte)1
                        },
                        new
                        {
                            Id = 8,
                            BookId = 4,
                            Score = (byte)2
                        },
                        new
                        {
                            Id = 9,
                            BookId = 5,
                            Score = (byte)5
                        },
                        new
                        {
                            Id = 10,
                            BookId = 3,
                            Score = (byte)2
                        });
                });

            modelBuilder.Entity("BC.DAL.Entities.Review", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("BookId")
                        .HasColumnType("int");

                    b.Property<string>("Message")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Reviewer")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("BookId");

                    b.ToTable("Reviews");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            BookId = 5,
                            Message = "aut",
                            Reviewer = "Roxanne93"
                        },
                        new
                        {
                            Id = 2,
                            BookId = 4,
                            Message = "distinctio",
                            Reviewer = "Luz_Kemmer"
                        },
                        new
                        {
                            Id = 3,
                            BookId = 7,
                            Message = "Ea doloribus quidem dignissimos aut incidunt dicta doloribus.\nFugiat distinctio consectetur quidem ipsa illum eos neque est ut.\nVoluptatem ut itaque.\nSapiente fuga nihil repellat nobis voluptas mollitia iusto.\nFuga perferendis quis vel fugit enim placeat ad eligendi architecto.",
                            Reviewer = "Gage.Feeney"
                        },
                        new
                        {
                            Id = 4,
                            BookId = 4,
                            Message = "autem",
                            Reviewer = "Jazmin.OKeefe"
                        },
                        new
                        {
                            Id = 5,
                            BookId = 5,
                            Message = "Explicabo quam cum reprehenderit nulla nobis quia.",
                            Reviewer = "Aubrey8"
                        },
                        new
                        {
                            Id = 6,
                            BookId = 9,
                            Message = "nemo",
                            Reviewer = "Trever_Stiedemann"
                        },
                        new
                        {
                            Id = 7,
                            BookId = 5,
                            Message = "Rerum qui molestiae omnis laboriosam totam id. Dolores illo sint maxime temporibus eos ratione. Necessitatibus nihil eligendi esse assumenda qui non expedita. Iste similique rerum quo non et aspernatur nemo. Ullam non ad quaerat dolor sed id.",
                            Reviewer = "Bill91"
                        },
                        new
                        {
                            Id = 8,
                            BookId = 5,
                            Message = "Omnis commodi delectus. Ea totam deleniti mollitia voluptatum ut et fuga quos. Ut rem quia quos. Veritatis vitae et quis temporibus. Est totam sint. Dolorem sit doloribus excepturi architecto reiciendis quasi numquam est ex.",
                            Reviewer = "Vidal31"
                        },
                        new
                        {
                            Id = 9,
                            BookId = 2,
                            Message = "Hic aut deserunt.\nExpedita dolores optio iste omnis corrupti aperiam maiores excepturi.\nEius quia quia cupiditate.\nSint vel nostrum qui animi molestiae porro molestiae.",
                            Reviewer = "Shayna34"
                        },
                        new
                        {
                            Id = 10,
                            BookId = 6,
                            Message = "repudiandae",
                            Reviewer = "Kavon.Fisher79"
                        });
                });

            modelBuilder.Entity("BC.DAL.Entities.Rating", b =>
                {
                    b.HasOne("BC.DAL.Entities.Book", "Book")
                        .WithMany("Ratings")
                        .HasForeignKey("BookId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Book");
                });

            modelBuilder.Entity("BC.DAL.Entities.Review", b =>
                {
                    b.HasOne("BC.DAL.Entities.Book", "Book")
                        .WithMany("Reviews")
                        .HasForeignKey("BookId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Book");
                });

            modelBuilder.Entity("BC.DAL.Entities.Book", b =>
                {
                    b.Navigation("Ratings");

                    b.Navigation("Reviews");
                });
#pragma warning restore 612, 618
        }
    }
}