using System;
using System.Collections.Generic;

namespace hrportalNew.Models;

public partial class Deduction
{
    public int Id { get; set; }

    public string? EmpId { get; set; }

    public DateTime? Ddate { get; set; }

    public string? WageType { get; set; }

    public string? Amount { get; set; }

    public string? Days { get; set; }

    public string? Notes { get; set; }
}
