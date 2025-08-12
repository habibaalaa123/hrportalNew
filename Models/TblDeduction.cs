using System;
using System.Collections.Generic;

namespace hrportalNew.Models;

public partial class TblDeduction
{
    public int Id { get; set; }

    public string? EmpId { get; set; }

    public DateTime? Ddate { get; set; }

    public string? WageCode { get; set; }

    public string? Amount { get; set; }

    public string? TotalDeduction { get; set; }
}
