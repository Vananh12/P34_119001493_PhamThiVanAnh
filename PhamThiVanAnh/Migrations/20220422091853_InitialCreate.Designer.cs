// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace PhamThiVanAnh.Migrations
{
    [DbContext(typeof(CategoryContext))]
    [Migration("20220422091853_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.4");

            modelBuilder.Entity("PhamThiVanAnh.Models.Category", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("TEXT");

                    b.HasKey("ID");

                    b.ToTable("Category");
                });

            modelBuilder.Entity("PhamThiVanAnh.Models.Comment", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Author")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("CreatedAt")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int?>("NewsID")
                        .HasColumnType("INTEGER");

                    b.HasKey("ID");

                    b.HasIndex("NewsID");

                    b.ToTable("Comment");
                });

            modelBuilder.Entity("PhamThiVanAnh.Models.News", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Author")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int?>("CategoryID")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("TEXT");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("TEXT");

                    b.HasKey("ID");

                    b.HasIndex("CategoryID");

                    b.ToTable("News");
                });

            modelBuilder.Entity("PhamThiVanAnh.Models.Comment", b =>
                {
                    b.HasOne("PhamThiVanAnh.Models.News", null)
                        .WithMany("comments")
                        .HasForeignKey("NewsID");
                });

            modelBuilder.Entity("PhamThiVanAnh.Models.News", b =>
                {
                    b.HasOne("PhamThiVanAnh.Models.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryID");

                    b.Navigation("Category");
                });

            modelBuilder.Entity("PhamThiVanAnh.Models.News", b =>
                {
                    b.Navigation("comments");
                });
#pragma warning restore 612, 618
        }
    }
}
