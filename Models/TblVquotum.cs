using System;
using System.Collections.Generic;

namespace hrportalNew.Models;

public partial class TblVquotum
{
    public int Id { get; set; }

    public string? EmpId { get; set; }

    public DateTime? Qdate { get; set; }

    public double? Qnt { get; set; }
}
