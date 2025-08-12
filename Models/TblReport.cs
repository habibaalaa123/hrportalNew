using System;
using System.Collections.Generic;

namespace hrportalNew.Models;

public partial class TblReport
{
    public int Id { get; set; }

    public string? NameAr { get; set; }

    public string? NameEn { get; set; }

    public string? FilePath { get; set; }

    public DateTime? Date { get; set; }

    public int? Category { get; set; }
}
