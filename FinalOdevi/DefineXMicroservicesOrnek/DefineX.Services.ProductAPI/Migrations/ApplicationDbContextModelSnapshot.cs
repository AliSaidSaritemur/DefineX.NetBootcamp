﻿// <auto-generated />
using DefineX.Services.ProductAPI.dbcontexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DefineX.Services.ProductAPI.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("DefineX.Services.ProductAPI.Models.Product", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<string>("Brand")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Collection")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsHot")
                        .HasColumnType("bit");

                    b.Property<bool>("IsNew")
                        .HasColumnType("bit");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("discount")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("tags")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            id = 1,
                            Brand = "nike",
                            CategoryName = "Women",
                            Collection = "[\"YEN\\u0130 GELEN \\u00DCR\\u00DCNLER\"]",
                            Description = "Vivamus suscipit tortor eget felis porttitor volutpat. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Proin eget tortor risus. Nulla porttitoraccumsan tincidunt. Pellentesque in ipsum id orci porta dapibus.",
                            IsHot = true,
                            IsNew = true,
                            Price = 145.0,
                            Title = "Black T-Shirt For Woman",
                            Type = "fashion",
                            discount = "40",
                            tags = "[\"new\",\"s\",\"m\",\"yellow\",\"white\"]"
                        },
                        new
                        {
                            id = 2,
                            Brand = "geox",
                            CategoryName = "Women",
                            Collection = "[\"TREND\"]",
                            Description = "Vivamus suscipit tortor eget felis porttitor volutpat. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Proin eget tortor risus. Nulla porttitoraccumsan tincidunt. Pellentesque in ipsum id orci porta dapibus.",
                            IsHot = false,
                            IsNew = false,
                            Price = 185.0,
                            Title = "T-Shirt Form Girls",
                            Type = "fashion",
                            discount = "40",
                            tags = "[\"s\",\"m\",\"l\",\"olive\",\"navy\"]"
                        },
                        new
                        {
                            id = 3,
                            Brand = "nike",
                            CategoryName = "Women",
                            Collection = "[\"featured products\"]",
                            Description = "Vivamus suscipit tortor eget felis porttitor volutpat. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Proin eget tortor risus. Nulla porttitoraccumsan tincidunt. Pellentesque in ipsum id orci porta dapibus.",
                            IsHot = false,
                            IsNew = true,
                            Price = 174.0,
                            Title = "White Black Line Dress",
                            Type = "fashion",
                            discount = "20",
                            tags = "[\"nike\",\"l\",\"m\",\"red\",\"black\"]"
                        },
                        new
                        {
                            id = 4,
                            Brand = "geox",
                            CategoryName = "Women",
                            Collection = "[\"on sale\"]",
                            Description = "Vivamus suscipit tortor eget felis porttitor volutpat. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Proin eget tortor risus. Nulla porttitoraccumsan tincidunt. Pellentesque in ipsum id orci porta dapibus.",
                            IsHot = true,
                            IsNew = false,
                            Price = 98.0,
                            Title = "Blue Dress For Woman",
                            Type = "fashion",
                            discount = "0",
                            tags = "[\"s\",\"l\",\"green\",\"skyblue\",\"geox\"]"
                        },
                        new
                        {
                            id = 5,
                            Brand = "biba",
                            CategoryName = "Women",
                            Collection = "[\"featured products\"]",
                            Description = "Vivamus suscipit tortor eget felis porttitor volutpat. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Proin eget tortor risus. Nulla porttitoraccumsan tincidunt. Pellentesque in ipsum id orci porta dapibus.",
                            IsHot = false,
                            IsNew = true,
                            Price = 230.0,
                            Title = "Black T-Shirt For Woman",
                            Type = "fashion",
                            discount = "0",
                            tags = "[\"m\",\"l\",\"green\",\"black\",\"biba\"]"
                        },
                        new
                        {
                            id = 6,
                            Brand = "max",
                            CategoryName = "Women",
                            Collection = "[\"EN \\u00C7OK SATANLAR\"]",
                            Description = "Vivamus suscipit tortor eget felis porttitor volutpat. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Proin eget tortor risus. Nulla porttitoraccumsan tincidunt. Pellentesque in ipsum id orci porta dapibus.",
                            IsHot = false,
                            IsNew = true,
                            Price = 121.0,
                            Title = "Blue Dress For Woman",
                            Type = "fashion",
                            discount = "40",
                            tags = "[\"new\",\"s\",\"m\",\"olive\",\"gray\"]"
                        },
                        new
                        {
                            id = 12,
                            Brand = "nike",
                            CategoryName = "Women",
                            Collection = "[\"best sellers\",\"on sale\"]",
                            Description = "Vivamus suscipit tortor eget felis porttitor volutpat. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Proin eget tortor risus. Nulla porttitoraccumsan tincidunt. Pellentesque in ipsum id orci porta dapibus.",
                            IsHot = false,
                            IsNew = false,
                            Price = 129.0,
                            Title = "boho tops",
                            Type = "fashion",
                            discount = "40",
                            tags = "[\"xs\",\"s\",\"m\",\"red\",\"pink\"]"
                        });
                });

            modelBuilder.Entity("DefineX.Services.ProductAPI.Models.ProductImage", b =>
                {
                    b.Property<int>("image_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("image_id"));

                    b.Property<string>("alt")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("id")
                        .HasColumnType("int");

                    b.Property<string>("src")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("variant_id")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("image_id");

                    b.ToTable("ProductImages");

                    b.HasData(
                        new
                        {
                            image_id = 111,
                            alt = "yellow",
                            id = 1,
                            src = "1.png",
                            variant_id = "[101]"
                        },
                        new
                        {
                            image_id = 112,
                            alt = "white",
                            id = 1,
                            src = "2.png",
                            variant_id = "[102]"
                        },
                        new
                        {
                            image_id = 211,
                            alt = "olive",
                            id = 2,
                            src = "3.png",
                            variant_id = "[201]"
                        },
                        new
                        {
                            image_id = 212,
                            alt = "navy",
                            id = 2,
                            src = "4.png",
                            variant_id = "[202]"
                        },
                        new
                        {
                            image_id = 311,
                            alt = "whredite",
                            id = 3,
                            src = "5.png",
                            variant_id = "[301]"
                        },
                        new
                        {
                            image_id = 312,
                            alt = "red",
                            id = 3,
                            src = "6.png",
                            variant_id = "[302]"
                        },
                        new
                        {
                            image_id = 411,
                            alt = "green",
                            id = 4,
                            src = "7.png",
                            variant_id = "[401]"
                        },
                        new
                        {
                            image_id = 412,
                            alt = "skyblue",
                            id = 4,
                            src = "8.png",
                            variant_id = "[403]"
                        },
                        new
                        {
                            image_id = 511,
                            alt = "green",
                            id = 5,
                            src = "9.png",
                            variant_id = "[501]"
                        },
                        new
                        {
                            image_id = 512,
                            alt = "black",
                            id = 5,
                            src = "10.png",
                            variant_id = "[502]"
                        },
                        new
                        {
                            image_id = 611,
                            alt = "olive",
                            id = 6,
                            src = "11.png",
                            variant_id = "[601]"
                        },
                        new
                        {
                            image_id = 612,
                            alt = "gray",
                            id = 6,
                            src = "12.png",
                            variant_id = "[602]"
                        },
                        new
                        {
                            image_id = 1211,
                            alt = "red",
                            id = 12,
                            src = "8.png",
                            variant_id = "[1201]"
                        },
                        new
                        {
                            image_id = 1212,
                            alt = "pink",
                            id = 12,
                            src = "9.png",
                            variant_id = "[1202]"
                        });
                });

            modelBuilder.Entity("DefineX.Services.ProductAPI.Models.Variant", b =>
                {
                    b.Property<int>("variant_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("variant_id"));

                    b.Property<string>("color")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("id")
                        .HasColumnType("int");

                    b.Property<int>("image_id")
                        .HasColumnType("int");

                    b.Property<string>("size")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("sku")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("variant_id");

                    b.ToTable("Variants");

                    b.HasData(
                        new
                        {
                            variant_id = 101,
                            color = "yellow",
                            id = 1,
                            image_id = 111,
                            size = "s",
                            sku = "sku1"
                        },
                        new
                        {
                            variant_id = 102,
                            color = "white",
                            id = 1,
                            image_id = 112,
                            size = "s",
                            sku = "sku2"
                        },
                        new
                        {
                            variant_id = 201,
                            color = "olive",
                            id = 2,
                            image_id = 211,
                            size = "s",
                            sku = "sku1"
                        },
                        new
                        {
                            variant_id = 202,
                            color = "navy",
                            id = 2,
                            image_id = 212,
                            size = "s",
                            sku = "sku2"
                        },
                        new
                        {
                            variant_id = 301,
                            color = "red",
                            id = 3,
                            image_id = 311,
                            size = "l",
                            sku = "sku3"
                        },
                        new
                        {
                            variant_id = 302,
                            color = "red",
                            id = 3,
                            image_id = 311,
                            size = "m",
                            sku = "skul3"
                        },
                        new
                        {
                            variant_id = 401,
                            color = "green",
                            id = 4,
                            image_id = 411,
                            size = "s",
                            sku = "sku4"
                        },
                        new
                        {
                            variant_id = 402,
                            color = "green",
                            id = 4,
                            image_id = 411,
                            size = "l",
                            sku = "skul4"
                        },
                        new
                        {
                            variant_id = 501,
                            color = "green",
                            id = 5,
                            image_id = 511,
                            size = "m",
                            sku = "sku5"
                        },
                        new
                        {
                            variant_id = 502,
                            color = "green",
                            id = 5,
                            image_id = 511,
                            size = "l",
                            sku = "skul5"
                        },
                        new
                        {
                            variant_id = 601,
                            color = "olive",
                            id = 6,
                            image_id = 611,
                            size = "s",
                            sku = "sku6"
                        },
                        new
                        {
                            variant_id = 602,
                            color = "gray",
                            id = 6,
                            image_id = 612,
                            size = "s",
                            sku = "skul6"
                        },
                        new
                        {
                            variant_id = 1201,
                            color = "red",
                            id = 12,
                            image_id = 1211,
                            size = "xs",
                            sku = "sku12"
                        },
                        new
                        {
                            variant_id = 1202,
                            color = "pink",
                            id = 12,
                            image_id = 1212,
                            size = "xs",
                            sku = "skul12"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
