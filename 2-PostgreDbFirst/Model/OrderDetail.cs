using System;
using System.Collections.Generic;

namespace _2_PostgreDbFirst.Model;

public partial class OrderDetail
{
    public short OrderId { get; set; }

    public short ProductId { get; set; }

    public float UnitPrice { get; set; }

    public short Quantity { get; set; }

    public float Discount { get; set; }

    /// <summary>
    /// 0=&gt;Siparis Giris
    /// 1=&gt;AlisFaturasi
    /// 2=&gt;SatisFaturasi
    /// 3=&gt;AlisFaturaIptal
    /// 4=&gt;SatisFaturaIptal
    /// 5=&gt;Depolar Arasi Transfer
    /// 
    /// </summary>
    public int? HareketTipi { get; set; }

    public virtual Order Order { get; set; } = null!;

    public virtual Product Product { get; set; } = null!;
}
