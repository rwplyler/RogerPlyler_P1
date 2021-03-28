using System;
using System.Collections.Generic;

#nullable disable

namespace Models
{
    public partial class Aorder
    {
        public Aorder()
        {
            AorderDetails = new HashSet<AorderDetail>();
        }

        public int OrderId { get; set; }
        public int? CustomerId { get; set; }
        public int? StoreId { get; set; }
        public DateTime? OrderTime { get; set; }
        public decimal? Total { get; set; }

        public virtual Acustomer Customer { get; set; }
        public virtual Astore Store { get; set; }
        public virtual ICollection<AorderDetail> AorderDetails { get; set; }
    }
}
