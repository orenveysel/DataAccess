﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using _9_ManyToMany.OgrenciDersleri;

#nullable disable

namespace _9_ManyToMany.Migrations
{
    [DbContext(typeof(OkulDBContext))]
    [Migration("20240516120403_AddIletisim")]
    partial class AddIletisim
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("DersOgrenci", b =>
                {
                    b.Property<int>("AldigiDerslerId")
                        .HasColumnType("int");

                    b.Property<int>("OgrencilerId")
                        .HasColumnType("int");

                    b.HasKey("AldigiDerslerId", "OgrencilerId");

                    b.HasIndex("OgrencilerId");

                    b.ToTable("DersOgrenci");
                });

            modelBuilder.Entity("OgrenciOgrenciVeli", b =>
                {
                    b.Property<int>("OgrencilerId")
                        .HasColumnType("int");

                    b.Property<int>("VelilerId")
                        .HasColumnType("int");

                    b.HasKey("OgrencilerId", "VelilerId");

                    b.HasIndex("VelilerId");

                    b.ToTable("OgrenciOgrenciVeli");
                });

            modelBuilder.Entity("_9_ManyToMany.OgrenciDersleri.Adress", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Ilce")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("OgrenciId")
                        .HasColumnType("int");

                    b.Property<string>("Sehir")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Ulke")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("OgrenciId");

                    b.ToTable("Adress");
                });

            modelBuilder.Entity("_9_ManyToMany.OgrenciDersleri.Ders", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("DersAdi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Dersler");
                });

            modelBuilder.Entity("_9_ManyToMany.OgrenciDersleri.Iletisim", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Gsm")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("OgrenciId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("OgrenciId");

                    b.ToTable("Iletisim");
                });

            modelBuilder.Entity("_9_ManyToMany.OgrenciDersleri.Ogrenci", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("AdSoyad")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Ogrenciler");
                });

            modelBuilder.Entity("_9_ManyToMany.OgrenciDersleri.OgrenciVeli", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Ad")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Soyad")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("OgrenciVeli");
                });

            modelBuilder.Entity("DersOgrenci", b =>
                {
                    b.HasOne("_9_ManyToMany.OgrenciDersleri.Ders", null)
                        .WithMany()
                        .HasForeignKey("AldigiDerslerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("_9_ManyToMany.OgrenciDersleri.Ogrenci", null)
                        .WithMany()
                        .HasForeignKey("OgrencilerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("OgrenciOgrenciVeli", b =>
                {
                    b.HasOne("_9_ManyToMany.OgrenciDersleri.Ogrenci", null)
                        .WithMany()
                        .HasForeignKey("OgrencilerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("_9_ManyToMany.OgrenciDersleri.OgrenciVeli", null)
                        .WithMany()
                        .HasForeignKey("VelilerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("_9_ManyToMany.OgrenciDersleri.Adress", b =>
                {
                    b.HasOne("_9_ManyToMany.OgrenciDersleri.Ogrenci", "Ogrenci")
                        .WithMany("Adresler")
                        .HasForeignKey("OgrenciId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Ogrenci");
                });

            modelBuilder.Entity("_9_ManyToMany.OgrenciDersleri.Iletisim", b =>
                {
                    b.HasOne("_9_ManyToMany.OgrenciDersleri.Ogrenci", "Ogrenci")
                        .WithMany("Iletisim")
                        .HasForeignKey("OgrenciId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Ogrenci");
                });

            modelBuilder.Entity("_9_ManyToMany.OgrenciDersleri.Ogrenci", b =>
                {
                    b.Navigation("Adresler");

                    b.Navigation("Iletisim");
                });
#pragma warning restore 612, 618
        }
    }
}
