using System;
using System.Collections.Generic;

#nullable disable

namespace Models
{
    public partial class InventoryDetail
    {
        public int? StoreId { get; set; }
        public int? ItemId { get; set; }
        public int? Amount { get; set; }

        public virtual AnItem Item { get; set; }
        public virtual Astore Store { get; set; }
    }
}
