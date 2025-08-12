using System;
using System.Collections.Generic;

namespace hrportalNew.Models;

public partial class TblEventImage
{
    public int Id { get; set; }

    public string? ImgPath { get; set; }

    public DateTime? Date { get; set; }

    public int EventId { get; set; }

    public int EvntImg { get; set; }
}
