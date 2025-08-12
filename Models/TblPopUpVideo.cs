using System;
using System.Collections.Generic;

namespace hrportalNew.Models;

public partial class TblPopUpVideo
{
    public int Id { get; set; }

    public string? VideoName { get; set; }

    public string? VideoPath { get; set; }

    public string? AllowPopUp { get; set; }
}
