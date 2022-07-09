using System;
using System.Collections.Generic;

#nullable disable

namespace MotorBikeShop.Models
{
    public partial class Order
    {
        public int OrderId { get; set; }
        public int? UserId { get; set; }
        public string OrderDate { get; set; }
        public string Total { get; set; }

        public virtual OrderDetail OrderNavigation { get; set; }
        public virtual User User { get; set; }
    }
}
