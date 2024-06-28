using System.ComponentModel.DataAnnotations

#region Relationships (Iliskiler) Terimleri
#region Principal Entity (Asail entity-Bagimzis entity)
//Kendi başına var olabilen tabloyu modelleyen entity'e denir.
//Departmanlar tablosunu modelleyen 'Departman' entity'sidir.
// Kategori Entity'ide buna ornek verilebilir
#endregion

#region Dependent entity ( Bagimli Entity)
//Kendi başına var olamayan, bir başka tabloya bağımlı(ilişkisel olarak bğaımlı)
//olan tabloyu modelleyen entity'e denir.
//Calisanlar tablosunu modelleyen 'Calisan' entity'sidir. Bu table departmanlar tablosuna bagimlidir
// Yada Product Entity'si Kategori Entity'sine bagimlidir
#endregion

#region Principal Key (Primary Key)
//Principal Entity'deki id'nin kendisidir.
//Principal Entity'nin kimliği olan kolonu ifade eden propertydir.
#endregion
#region Foreign Key
//Principal Entity ile Dependent Entity arasındaki ilişkiyi sağlayan key'dir.

//Dependent Entity'de tanımlanır.
//Principal Entity'de ki Principal Key'i tutar.
//Ornegin Kategori entity'si icindeki KategoriId principal key iken 
// product entity'si icerisindeki KategoriID ise Foreign Key dir
#endregion


#region  Navigation Property
//İlişkisel tablolar arasındaki fiziksel erişimi entity class'ları üzerinden
//sağlayan property'lerdir.

//Bir property'nin navigation property olabilmesi için kesinlikle entity türünden olması gerekiyor.

//Navigation property'ler entity'lerdeki tanımlarına göre n'e n yahut 1'e n şeklinde ilişki türlerini ifade etmektedirler. 
#endregion
#endregion


#region Iliski Turleri

#region One to One
//Çalışan ile adresi arasındaki ilişki,
//Karı koca arasındaki ilişki.
#endregion
#region One to Many
//Çalışan ile departman arasındaki ilişki,
//Anne ve çocukları arasındaki ilişki.
#endregion
#region Many to Many
//Çalışanlar ile projeler arasındaki ilişki,
//Kardeşler arasındaki ilişki.
#endregion
#endregion


#region EF Core da iliski yapilandirma Yontemleri

#region Default Conventions
//Varsayılan entity kurallarını kullanarak yapılan ilişki yapılandırma yöntemleridir.

//Navigation property'leri kullanarak ilişki şablonlarını çıkarmaktadır.
#endregion

#region Data Annotations Attributes
//Entity'nin niteliklerine göre ince ayarlar yapmamızı sağlayan attribute'lardır. [Key], [ForeignKey]

//[ToTable("Personeller")]
//public class Persone
//{
//    [Key()]
//    public int Id { get; set; }
//    [Maxlength(50)]
//    public string AdSoyad { get; set; }
//}
#endregion



#region Fluent API

//Entity modellerindeki ilişkileri yapılandırırken daha detaylı çalışmamızı sağlayan yöntemdir.
#region HasOne
//İlgili entity'nin ilişkisel entity'ye birebir ya da bire çok olacak şekilde ilişkisini yapılandırmaya başlayan metottur.
#endregion

#region HasMany
//İlgili entity'nin ilişkisel entity'ye çoka bir ya da çoka çok olacak şekilde ilişkisini yapılandırmaya başlayan metottur.
#endregion

#region WithOne
//HasOne ya da HasMany'den sonra bire bir ya da çoka bir olacak şekilde ilişki yapılandırmasını tamamlayan metottur.
#endregion

#region WithMany
//HasOne ya da HasMany'den sonra bire çok ya da çoka çok olacak şekilde ilişki yapılandırmasını tamamlayan metottur.
#endregion


#endregion




#endregion