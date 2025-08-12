using System;
using System.Collections.Generic;

namespace hrportalNew.Models;

public partial class TblTod
{
    public int Id { get; set; }

    public string? DetailsAr { get; set; }

    public string? DetailsEn { get; set; }

    public string? ImgPath { get; set; }

    public DateTime? Date { get; set; }

    public int? First { get; set; }
}
