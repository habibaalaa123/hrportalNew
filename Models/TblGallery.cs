using System;
using System.Collections.Generic;

namespace hrportalNew.Models;

public partial class TblGallery
{
    public int Id { get; set; }

    public string? ImgPath { get; set; }

    public DateTime? Date { get; set; }

    public int? Current { get; set; }

    public string? HeaderAr { get; set; }

    public string? HeaderEn { get; set; }

    public int? MainCatId { get; set; }

    public int? SubCatId { get; set; }

    public string? AllowPopUp { get; set; }

    public int HeartSubFolderId { get; set; }
}
