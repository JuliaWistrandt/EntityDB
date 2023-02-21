using System;
using System.Collections.Generic;

namespace ModelEntityDB.Models;

public partial class Project
{
    public int ProjectId { get; set; }

    public string? ProjectName { get; set; }

    public decimal? ProjectCost { get; set; }

    public int? DepartmentId { get; set; }

    public int? ClienId { get; set; }

    public DateTime? StartDate { get; set; }

    public DateTime? EndDate { get; set; }

    public virtual Client? Clien { get; set; }

    public virtual Department? Department { get; set; }
}
