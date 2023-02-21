using System;
using System.Collections.Generic;

namespace ModelEntityDB.Models;

public partial class Employee
{
    public int EmployeeId { get; set; }

    public string? EmployeeName { get; set; }

    public int? DepartmentId { get; set; }

    public decimal? Salary { get; set; }

    public DateTime? HireDate { get; set; }

    public int? SuccessProjects { get; set; }

    public virtual Department? Department { get; set; }
}
