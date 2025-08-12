using System;
using System.Collections.Generic;

namespace hrportalNew.Models;

public partial class TblUserProfile
{
    public int Id { get; set; }

    public string? ImgPath { get; set; }

    public int? EmpId { get; set; }
}
