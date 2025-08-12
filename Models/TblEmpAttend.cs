using System;
using System.Collections.Generic;

namespace hrportalNew.Models;

public partial class TblEmpAttend
{
    public int? EmpId { get; set; }

    public string? Pernr { get; set; }

    public string? Name { get; set; }

    public string? Position { get; set; }

    public string? Department { get; set; }

    public string? Date { get; set; }

    public string? Dws { get; set; }

    public DateTime? CheckIn { get; set; }

    public DateTime? CheckOut { get; set; }

    public string? OverTime { get; set; }

    public string? WorkingHours { get; set; }

    public string? LateIn { get; set; }

    public string? EarlyOut { get; set; }

    public string? AttAbs { get; set; }

    public string? PlannedDays { get; set; }

    public string? PlanWorkHours { get; set; }

    public string? TotWorkHours { get; set; }

    public string? TotLateIn { get; set; }

    public string? ActualDays { get; set; }

    public string? ActualWorkHours { get; set; }

    public string? Leaves { get; set; }

    public string? TotEarlyOut { get; set; }

    public string? Average { get; set; }

    public int Id { get; set; }
}
