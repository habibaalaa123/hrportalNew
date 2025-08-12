using System;
using System.Collections.Generic;

namespace hrportalNew.Models;

public partial class Employee
{
    public int Id { get; set; }

    public string? EmpId { get; set; }

    public string? EmpName { get; set; }

    public string? EmpFullName { get; set; }

    public DateTime? HireDate { get; set; }

    public string? Area { get; set; }

    public string? SubArea { get; set; }

    public string? EmpGroup { get; set; }

    public string? SubGroup { get; set; }

    public string? OrgUnit { get; set; }

    public string? Job { get; set; }

    public string? Position { get; set; }

    public DateTime? BirthDate { get; set; }

    public string? Nationality { get; set; }

    public string? AddressEn { get; set; }

    public string? AddressAr { get; set; }

    public string? NationalId { get; set; }

    public string? Mobile { get; set; }

    public string? Pernr { get; set; }

    public string? EmpFullNameAr { get; set; }

    public string? NationalityAr { get; set; }

    public string? JobAr { get; set; }

    public string? PositionAr { get; set; }

    public string? OrgUnitAr { get; set; }

    public string? Sino { get; set; }

    public string? Mrn { get; set; }

    public string? Institute { get; set; }

    public string? InstDegree { get; set; }

    public string? InstBranch { get; set; }

    public string? GradDate { get; set; }

    public string? OtherDegree { get; set; }

    public string? OtherDegDte { get; set; }

    /// <summary>
    /// (&apos;&apos;)
    /// </summary>
    public string? EMail { get; set; }
}
