using System;
using System.Collections.Generic;

namespace demo19.Models;

public partial class Product
{
    public int Id { get; set; }

    public string Article { get; set; } = null!;

    public string ProductName { get; set; } = null!;

    public string Unit { get; set; } = null!;

    public decimal Price { get; set; }

    public string? Postavshik { get; set; }

    public string? Proisvod { get; set; }

    public string Category { get; set; } = null!;

    public int CurrentDiscount { get; set; }

    public int QuantityInStock { get; set; }

    public string? Description { get; set; }

    public string? Photo { get; set; }

    public virtual ICollection<OrderItem> OrderItems { get; set; } = new List<OrderItem>();
}
