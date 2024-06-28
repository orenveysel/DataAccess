using System;
using System.Collections.Generic;

namespace _3_MysqlDbFirst.Model;

public partial class Country
{
    public ushort CountryId { get; set; }

    public string Country1 { get; set; } = null!;

    public DateTime LastUpdate { get; set; }

    public virtual ICollection<City> Cities { get; set; } = new List<City>();
}
