using System;
using System.Collections.Generic;

namespace hrportalNew.Models;

public partial class TblHeartictionPoint
{
    public int Id { get; set; }

    public string EmpId { get; set; } = null!;

    public int Points { get; set; }
}
