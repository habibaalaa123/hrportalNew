using System;
using System.Collections.Generic;

namespace hrportalNew.Models;

public partial class Vquotum
{
    public int Id { get; set; }

    public string? EmpId { get; set; }

    public DateTime? Qdate { get; set; }

    public string? Qtype { get; set; }

    public double? Qnt { get; set; }
}
