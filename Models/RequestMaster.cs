using System;
using System.Collections.Generic;

namespace hrportalNew.Models;

public partial class RequestMaster
{
    public int Id { get; set; }

    public string? ReqNameEn { get; set; }

    public int? Duration { get; set; }

    public string? Mail { get; set; }

    public string? ReqNameAr { get; set; }
}
