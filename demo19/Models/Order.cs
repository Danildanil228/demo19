using System;
using System.Collections.Generic;

namespace demo19.Models;

public partial class Order
{
    public int Id { get; set; }

    public int OrderNumber { get; set; }

    public DateTime OrderDate { get; set; }

    public DateTime DeliveryDate { get; set; }

    public int PickupPointId { get; set; }

    public string CustomerName { get; set; } = null!;

    public string PickupCode { get; set; } = null!;

    public string Status { get; set; } = null!;

    public virtual ICollection<OrderItem> OrderItems { get; set; } = new List<OrderItem>();

    public virtual Punkt PickupPoint { get; set; } = null!;
}
