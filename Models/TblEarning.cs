using System;
using System.Collections.Generic;

namespace hrportalNew.Models;

public partial class TblEarning
{
    public int Id { get; set; }

    public string? EmpId { get; set; }

    public DateTime? Edate { get; set; }

    public string? WageCode { get; set; }

    public string? Amount { get; set; }

    public string? Bank { get; set; }

    public string? TotalEarninig { get; set; }
}
