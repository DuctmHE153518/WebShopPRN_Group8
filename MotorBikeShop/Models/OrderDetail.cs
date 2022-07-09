using System;
using System.Collections.Generic;

#nullable disable

namespace MotorBikeShop.Models
{
    public partial class OrderDetail
    {
        public int OrderId { get; set; }
        public string ProductId { get; set; }
        public int? Quantity { get; set; }

        public virtual Product Product { get; set; }
        public virtual Order Order { get; set; }
    }
}
