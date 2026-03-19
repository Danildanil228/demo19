using System;
using System.Collections.Generic;

namespace demo19.Models;

public partial class OrderItem
{
    public int Id { get; set; }

    public int OrderNumber { get; set; }

    public string ProductArticle { get; set; } = null!;

    public int Quantity { get; set; }

    public virtual Order OrderNumberNavigation { get; set; } = null!;

    public virtual Product ProductArticleNavigation { get; set; } = null!;
}
