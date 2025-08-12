using System;
using System.Collections.Generic;

namespace hrportalNew.Models;

public partial class TblHeartectionSubFoldr
{
    public int Id { get; set; }

    public string? SubFolderAr { get; set; }

    public string? SubFolderEn { get; set; }

    public int MainCatId { get; set; }

    public int SubCategoryId { get; set; }
}
