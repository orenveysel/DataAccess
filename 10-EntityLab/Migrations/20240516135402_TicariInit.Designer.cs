﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using _10_EntityLab.TicariOtomasyon;

#nullable disable

namespace _10_EntityLab.Migrations
{
    [DbContext(typeof(TicariDbContext))]
    [Migration("20240516135402_TicariInit")]
    partial class TicariInit
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("KategoriStok", b =>
                {
                    b.Property<int>("KategorilerId")
                        .HasColumnType("int");

                    b.Property<int>("StoklarId")
                        .HasColumnType("int");

                    b.HasKey("KategorilerId", "StoklarId");

                    b.HasIndex("StoklarId");

                    b.ToTable("KategoriStok");
                });

            modelBuilder.Entity("_10_EntityLab.TicariOtomasyon.Adres", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CariId")
                        .HasColumnType("int");

                    b.Property<string>("Ilce")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Sehir")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CariId");

                    b.ToTable("Adresler");
                });

            modelBuilder.Entity("_10_EntityLab.TicariOtomasyon.Cari", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("CariAdi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CariKodu")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte>("CariTipi")
                        .HasColumnType("tinyint");

                    b.HasKey("Id");

                    b.ToTable("CariKartlar");
                });

            modelBuilder.Entity("_10_EntityLab.TicariOtomasyon.Depo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("DepoAdi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Depolar");
                });

            modelBuilder.Entity("_10_EntityLab.TicariOtomasyon.DepoHareket", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("DepoId")
                        .HasColumnType("int");

                    b.Property<byte>("HareketTipi")
                        .HasColumnType("tinyint");

                    b.Property<int>("StokId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("DepoId");

                    b.HasIndex("StokId");

                    b.ToTable("DepoHareketleri");
                });

            modelBuilder.Entity("_10_EntityLab.TicariOtomasyon.Kasa", b =>
                {
                    b.Property<int>("KasaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("KasaId"));

                    b.Property<string>("KasaAdi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("KasaId");

                    b.ToTable("Kasalar");
                });

            modelBuilder.Entity("_10_EntityLab.TicariOtomasyon.KasaHareket", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<byte>("HareketTipi")
                        .HasColumnType("tinyint");

                    b.Property<int>("KasaId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("KasaId");

                    b.ToTable("KasaHareketleri");
                });

            modelBuilder.Entity("_10_EntityLab.TicariOtomasyon.Kategori", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("KategoriAdi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Kategoriler");
                });

            modelBuilder.Entity("_10_EntityLab.TicariOtomasyon.Personel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("AdSoyad")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Personeller");
                });

            modelBuilder.Entity("_10_EntityLab.TicariOtomasyon.Siparis", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CariId")
                        .HasColumnType("int");

                    b.Property<int>("PersonelId")
                        .HasColumnType("int");

                    b.Property<DateTime>("SiparisTarihi")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("CariId");

                    b.HasIndex("PersonelId");

                    b.ToTable("Siparisler");
                });

            modelBuilder.Entity("_10_EntityLab.TicariOtomasyon.SiparisDetay", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Adet")
                        .HasColumnType("int");

                    b.Property<double>("Fiyat")
                        .HasColumnType("float");

                    b.Property<double>("Indirim")
                        .HasColumnType("float");

                    b.Property<int>("SiparisId")
                        .HasColumnType("int");

                    b.Property<int>("StokId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("SiparisId");

                    b.HasIndex("StokId");

                    b.ToTable("SiparisDetaylari");
                });

            modelBuilder.Entity("_10_EntityLab.TicariOtomasyon.Stok", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("DepoId")
                        .HasColumnType("int");

                    b.Property<string>("StokAdi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StokKodu")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("DepoId");

                    b.ToTable("Stoklar");
                });

            modelBuilder.Entity("KategoriStok", b =>
                {
                    b.HasOne("_10_EntityLab.TicariOtomasyon.Kategori", null)
                        .WithMany()
                        .HasForeignKey("KategorilerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("_10_EntityLab.TicariOtomasyon.Stok", null)
                        .WithMany()
                        .HasForeignKey("StoklarId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("_10_EntityLab.TicariOtomasyon.Adres", b =>
                {
                    b.HasOne("_10_EntityLab.TicariOtomasyon.Cari", "Cari")
                        .WithMany("Adresler")
                        .HasForeignKey("CariId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cari");
                });

            modelBuilder.Entity("_10_EntityLab.TicariOtomasyon.DepoHareket", b =>
                {
                    b.HasOne("_10_EntityLab.TicariOtomasyon.Depo", "Depo")
                        .WithMany("DepoHareketleri")
                        .HasForeignKey("DepoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("_10_EntityLab.TicariOtomasyon.Stok", "Stok")
                        .WithMany("DepoHareketleri")
                        .HasForeignKey("StokId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Depo");

                    b.Navigation("Stok");
                });

            modelBuilder.Entity("_10_EntityLab.TicariOtomasyon.KasaHareket", b =>
                {
                    b.HasOne("_10_EntityLab.TicariOtomasyon.Kasa", "Kasa")
                        .WithMany("Hareketler")
                        .HasForeignKey("KasaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Kasa");
                });

            modelBuilder.Entity("_10_EntityLab.TicariOtomasyon.Siparis", b =>
                {
                    b.HasOne("_10_EntityLab.TicariOtomasyon.Cari", "Cari")
                        .WithMany()
                        .HasForeignKey("CariId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("_10_EntityLab.TicariOtomasyon.Personel", "SiparisiAlan")
                        .WithMany("Siparisler")
                        .HasForeignKey("PersonelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cari");

                    b.Navigation("SiparisiAlan");
                });

            modelBuilder.Entity("_10_EntityLab.TicariOtomasyon.SiparisDetay", b =>
                {
                    b.HasOne("_10_EntityLab.TicariOtomasyon.Siparis", "Siparis")
                        .WithMany("SiparisDetayi")
                        .HasForeignKey("SiparisId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("_10_EntityLab.TicariOtomasyon.Stok", "Stok")
                        .WithMany()
                        .HasForeignKey("StokId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Siparis");

                    b.Navigation("Stok");
                });

            modelBuilder.Entity("_10_EntityLab.TicariOtomasyon.Stok", b =>
                {
                    b.HasOne("_10_EntityLab.TicariOtomasyon.Depo", "Depo")
                        .WithMany("Stoklar")
                        .HasForeignKey("DepoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Depo");
                });

            modelBuilder.Entity("_10_EntityLab.TicariOtomasyon.Cari", b =>
                {
                    b.Navigation("Adresler");
                });

            modelBuilder.Entity("_10_EntityLab.TicariOtomasyon.Depo", b =>
                {
                    b.Navigation("DepoHareketleri");

                    b.Navigation("Stoklar");
                });

            modelBuilder.Entity("_10_EntityLab.TicariOtomasyon.Kasa", b =>
                {
                    b.Navigation("Hareketler");
                });

            modelBuilder.Entity("_10_EntityLab.TicariOtomasyon.Personel", b =>
                {
                    b.Navigation("Siparisler");
                });

            modelBuilder.Entity("_10_EntityLab.TicariOtomasyon.Siparis", b =>
                {
                    b.Navigation("SiparisDetayi");
                });

            modelBuilder.Entity("_10_EntityLab.TicariOtomasyon.Stok", b =>
                {
                    b.Navigation("DepoHareketleri");
                });
#pragma warning restore 612, 618
        }
    }
}
