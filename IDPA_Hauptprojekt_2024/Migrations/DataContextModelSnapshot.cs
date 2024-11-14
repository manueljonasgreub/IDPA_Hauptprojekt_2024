﻿// <auto-generated />
using IDPA_Hauptprojekt_2024.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace IDPA_Hauptprojekt_2024.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "9.0.0");

            modelBuilder.Entity("IDPA_Hauptprojekt_2024.Database.Model.Article", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ArticleLaw")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Articles");
                });

            modelBuilder.Entity("IDPA_Hauptprojekt_2024.Database.Model.ArticleKeyword", b =>
                {
                    b.Property<int>("ArticleId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("KeywordId")
                        .HasColumnType("INTEGER");

                    b.HasKey("ArticleId", "KeywordId");

                    b.HasIndex("KeywordId");

                    b.ToTable("Article_Keywords");
                });

            modelBuilder.Entity("IDPA_Hauptprojekt_2024.Database.Model.Keyword", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Keywords")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Keywords");
                });

            modelBuilder.Entity("IDPA_Hauptprojekt_2024.Database.Model.ArticleKeyword", b =>
                {
                    b.HasOne("IDPA_Hauptprojekt_2024.Database.Model.Article", "Article")
                        .WithMany("Article_Keywords")
                        .HasForeignKey("ArticleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("IDPA_Hauptprojekt_2024.Database.Model.Keyword", "Keyword")
                        .WithMany("Article_Keywords")
                        .HasForeignKey("KeywordId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Article");

                    b.Navigation("Keyword");
                });

            modelBuilder.Entity("IDPA_Hauptprojekt_2024.Database.Model.Article", b =>
                {
                    b.Navigation("Article_Keywords");
                });

            modelBuilder.Entity("IDPA_Hauptprojekt_2024.Database.Model.Keyword", b =>
                {
                    b.Navigation("Article_Keywords");
                });
#pragma warning restore 612, 618
        }
    }
}
