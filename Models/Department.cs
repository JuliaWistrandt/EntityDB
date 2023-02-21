using System;
using System.Collections.Generic;

namespace ModelEntityDB.Models;

public partial class Department
{
    public int DepartmentId { get; set; }

    public string? DepartmantName { get; set; }

    public virtual ICollection<Employee> Employees { get; } = new List<Employee>();

    public virtual ICollection<Project> Projects { get; } = new List<Project>();
}
