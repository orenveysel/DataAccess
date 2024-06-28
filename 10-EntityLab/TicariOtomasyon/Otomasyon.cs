using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_EntityLab.TicariOtomasyon
{
    public class Otomasyon
    {
    }

    public enum CariTipi:byte
    {
        Alici=1,
        Satici
    }


    // Firmalarla alis veriste bulunan diger 3. taraflara cari denir
    public class Cari
    {
        public int Id { get; set; }
        public string CariKodu { get; set; }
        public string CariAdi { get; set; }
        public CariTipi CariTipi { get; set; }
        public List<Adres> Adresler { get; set; }

    }

    public class Adres
    {
        public int Id { get; set; }
        public string Sehir { get; set; }
        public string Ilce { get; set; }

        #region Bu adres kime ait
        public int CariId { get; set; }
        public Cari Cari { get; set; }
        #endregion
    }

    #region Stok Kategori N-N

    public class Stok
    {
        public int Id { get; set; }
        public string? StokKodu { get; set; }
        public string StokAdi { get; set; }
        public List<Kategori> Kategoriler { get; set; }
        public List<DepoHareket> DepoHareketleri { get; set; }

        public int DepoId { get; set; }
        public Depo Depo { get; set; }
    }

    public class Kategori
    {
        public int Id { get; set; }
        public string KategoriAdi { get; set; }
        public List<Stok> Stoklar { get; set; }
    }

    public class Depo
    {
        public int Id { get; set; }
        public string DepoAdi { get; set; }
        public List<Stok> Stoklar { get; set; }

        public List<DepoHareket> DepoHareketleri { get; set; }
    }


    public class DepoHareket
    {
        public int Id { get; set; }
        public DepoHareketTipi HareketTipi { get; set; }

        public int StokId { get; set; }
        public Stok Stok { get; set; }

        public int DepoId { get; set; }
        public Depo Depo { get; set; }

    }

    public enum DepoHareketTipi:byte
    {
        FaturaileGiris,
        DepolarArasiTransferGirisi,
        KonsiyeGiris,
        FaturaileCikis,
        DepoArasiTrasferCikisi,
        KonsinyeCikis
    }
    #endregion

    #region 1-N Iliski
    // Kasa Tanimlamasi
    public class Kasa
    {
        public int KasaId { get; set; }
        public string KasaAdi { get; set; }

        public List<KasaHareket> Hareketler { get; set; }

    }
    // Kasaya Giren  ve Kasadan Cikan Para Translerinin tutuldugu tablo
    public class KasaHareket
    {
        public int Id { get; set; }
        public int KasaId { get; set; }
        public Kasa Kasa { get; set; }
        public KasaHareketTipi HareketTipi { get; set; }


    }
    public enum KasaHareketTipi : byte
    {
        Giris = 1,
        Cikis = 2
    }
    #endregion

    #region Siparis 
    public class Personel
    {
        public int Id { get; set; }
        public string AdSoyad { get; set; }
        public List<Siparis> Siparisler { get; set; }
    }

    public class Siparis
    {
        public int Id { get; set; }
        public int CariId { get; set; }
        public Cari Cari { get; set; }

        public int PersonelId { get; set; }
        public Personel SiparisiAlan { get; set; }

        /*
         * Hangi urunu yada urunleri siparis etti. 
         * Kac adet ve kaç paradan siparis etti.
         * Indirim oldumu ?
         * 
         */
        public DateTime SiparisTarihi { get; set; }
        public List<SiparisDetay> SiparisDetayi { get; set; }
    }
    public class SiparisDetay
    {
        public int Id { get; set; }
        
        public int SiparisId { get; set; }
        public Siparis Siparis  { get; set; }
        
        public int StokId { get; set; }
        public Stok Stok { get; set; }
        public int Adet { get; set; }
        public double Fiyat { get; set; }
        public double  Indirim{ get; set; }

        [NotMapped]
        public double Tutar { get; set; }

    }
    #endregion
}
