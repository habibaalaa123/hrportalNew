using System;
using System.Collections.Generic;

namespace hrportalNew.Models;

public partial class Complaint
{
    public int Id { get; set; }

    public string? Code { get; set; }

    public string? Emp { get; set; }

    public int? TypeCode { get; set; }

    public string? Type { get; set; }

    public DateTime Timestamp { get; set; }

    public string? Status { get; set; }

    public string? Ip { get; set; }

    public string? Updatedby { get; set; }

    public DateTime? Updatedtime { get; set; }

    public string? Uip { get; set; }

    public string? Notes { get; set; }

    public string? NotesHr { get; set; }
}
