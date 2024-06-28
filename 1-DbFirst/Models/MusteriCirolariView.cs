using System;
using System.Collections.Generic;

namespace _1_DbFirst.Models;

public partial class MusteriCirolariView
{
    public int OrderId { get; set; }

    public string? CustomerId { get; set; }

    public string Musteri { get; set; } = null!;

    public int? EmployeeId { get; set; }

    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public string? ShipCity { get; set; }

    public string? ShipCountry { get; set; }

    public int? ShipVia { get; set; }

    public string Kargo { get; set; } = null!;
}
