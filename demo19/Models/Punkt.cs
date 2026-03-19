using System;
using System.Collections.Generic;

namespace demo19.Models;

public partial class Punkt
{
    public int Id { get; set; }

    public int IndexNumber { get; set; }

    public string City { get; set; } = null!;

    public string Address { get; set; } = null!;

    public virtual ICollection<Order> Orders { get; set; } = new List<Order>();
}
