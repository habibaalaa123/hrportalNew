using System;
using System.Collections.Generic;

namespace hrportalNew.Models;

public partial class EventMaster
{
    public int Id { get; set; }

    public string? EvntTypEn { get; set; }

    public int? Duration { get; set; }

    public string? EvntTypAr { get; set; }
}
