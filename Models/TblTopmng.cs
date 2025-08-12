using System;
using System.Collections.Generic;

namespace hrportalNew.Models;

public partial class TblTopmng
{
    public int Id { get; set; }

    public string? ImgPath { get; set; }

    public DateTime? Date { get; set; }

    public int? Na { get; set; }

    public string? NameAr { get; set; }

    public string? NameEn { get; set; }

    public string? PositionAr { get; set; }

    public string? PositionEn { get; set; }

    public string? DetailsAr { get; set; }

    public string? DetailsEn { get; set; }

    public int? Order { get; set; }
}
