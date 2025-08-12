using System;
using System.Collections.Generic;

namespace hrportalNew.Models;

public partial class TblLdtypsSubFolder
{
    public int Id { get; set; }

    public string? SubFolderAr { get; set; }

    public string? SubFolderEn { get; set; }

    public int MainTypId { get; set; }
}
