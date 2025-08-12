using System;
using System.Collections.Generic;

namespace hrportalNew.Models;

public partial class TblNews
{
    public int Id { get; set; }

    public string? HeaderAr { get; set; }

    public string? HeaderEn { get; set; }

    public string? DetailsAr { get; set; }

    public string? DetailsEn { get; set; }

    public string? ImgPath { get; set; }

    public string? Type { get; set; }

    public DateTime? Date { get; set; }
}
