﻿using System;
using System.Collections.Generic;

namespace _12_GenelTekrar.Model2;

public partial class SummaryOfSalesByQuarter
{
    public DateTime? ShippedDate { get; set; }

    public int OrderId { get; set; }

    public decimal? Subtotal { get; set; }
}
