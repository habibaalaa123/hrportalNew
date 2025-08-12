using System;
using System.Collections.Generic;

namespace hrportalNew.Models;

public partial class Leaf
{
    public int Id { get; set; }

    public string? EmpId { get; set; }

    public string? Ltype { get; set; }

    public DateTime? StartD { get; set; }

    public DateTime? EndD { get; set; }

    public int? Days { get; set; }
}
