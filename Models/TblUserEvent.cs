using System;
using System.Collections.Generic;

namespace hrportalNew.Models;

public partial class TblUserEvent
{
    public int Id { get; set; }

    public string? Header { get; set; }

    public string? Details { get; set; }

    public DateTime? Date { get; set; }

    public int? EmpId { get; set; }

    public string? EvntType { get; set; }
}
