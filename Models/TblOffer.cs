using System;
using System.Collections.Generic;

namespace hrportalNew.Models;

public partial class TblOffer
{
    public int Id { get; set; }

    public string? HeaderEn { get; set; }

    public string? HeaderAr { get; set; }

    public string? DetailsEn { get; set; }

    public string? DetailsAr { get; set; }

    public int OfferOrder { get; set; }

    public string? ImgPath { get; set; }

    public int PopUp { get; set; }

    public int? LDId { get; set; }
}
