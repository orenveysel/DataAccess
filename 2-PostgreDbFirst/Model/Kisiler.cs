using System;
using System.Collections.Generic;

namespace _2_PostgreDbFirst.Model;

public partial class Kisiler
{
    public int Id { get; set; }

    public string? FirstName { get; set; }

    public string? LastName { get; set; }

    public DateOnly CreateDate { get; set; }
}
