using System;
using System.Collections.Generic;

namespace hrportalNew.Models;

public partial class TblCareer
{
    public int Id { get; set; }

    public string? Code { get; set; }

    public string? DivisionAr { get; set; }

    public string? DivisionEn { get; set; }

    public string? DepartmentAr { get; set; }

    public string? DepartmentEn { get; set; }

    public string? TitleAr { get; set; }

    public string? TitleEn { get; set; }

    public string? PositionAr { get; set; }

    public string? PositionEn { get; set; }

    public string? ExperienceAr { get; set; }

    public string? ExperienceEn { get; set; }

    public string? EducationAr { get; set; }

    public string? EducationEn { get; set; }

    public DateTime? CreatedDate { get; set; }

    public DateTime? JobDeadline { get; set; }

    public string? JobBranchAr { get; set; }

    public string? JobBranchEn { get; set; }
}
