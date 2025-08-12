using System;
using System.Collections.Generic;

namespace hrportalNew.Models;

public partial class TblEvent
{
    public int Id { get; set; }

    public string? HeaderAr { get; set; }

    public string? HeaderEn { get; set; }

    public string? DetailsAr { get; set; }

    public string? DetaisEn { get; set; }

    public string? ImgPath { get; set; }

    public DateTime? Date { get; set; }

    public string? EventTypeEn { get; set; }

    public string? EventTypeAr { get; set; }

    public int EventOrder { get; set; }

    public int Order { get; set; }

    public int? LDId { get; set; }
}
