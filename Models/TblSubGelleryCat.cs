using System;
using System.Collections.Generic;

namespace hrportalNew.Models;

public partial class TblSubGelleryCat
{
    public int Id { get; set; }

    public string? SubCategoryAr { get; set; }

    public string? SubCategoryEn { get; set; }

    public int? MainCatId { get; set; }

    public int Order { get; set; }
}
