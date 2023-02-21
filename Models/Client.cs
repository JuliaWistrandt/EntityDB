using System;
using System.Collections.Generic;

namespace ModelEntityDB.Models;

public partial class Client
{
    public int ClientId { get; set; }

    public string? ClientName { get; set; }

    public virtual ICollection<Project> Projects { get; } = new List<Project>();
}
