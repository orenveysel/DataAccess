﻿using System;
using System.Collections.Generic;

namespace _11_GlobalQueryFilter.Model;

public partial class ProductsAboveAveragePrice
{
    public string ProductName { get; set; } = null!;

    public decimal? UnitPrice { get; set; }
}
