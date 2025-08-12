using System;
using System.Collections.Generic;

namespace hrportalNew.Models;

public partial class TblFaq
{
    public int Id { get; set; }

    public string? QuestionAr { get; set; }

    public string? QuestionEn { get; set; }

    public string? AnswerAr { get; set; }

    public string? AnswerEn { get; set; }
}
