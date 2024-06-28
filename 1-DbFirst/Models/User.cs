using System;
using System.Collections.Generic;

namespace _1_DbFirst.Models;

public partial class User
{
    public int Id { get; set; }

    public string Email { get; set; } = null!;

    public string Password { get; set; } = null!;

    public string? Name { get; set; }

    public string? SurName { get; set; }

    public string? RefreshToken { get; set; }

    public DateTime? RefreshTokenEndDate { get; set; }
}
