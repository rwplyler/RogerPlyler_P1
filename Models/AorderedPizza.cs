using System;
using System.Collections.Generic;

#nullable disable

namespace Repository.Models
{
    public partial class AorderedPizza
    {
        public int Id { get; set; }
        public int OrderId { get; set; }
        public string PizzaName { get; set; }
        public int? Size { get; set; }
        public int? Crust { get; set; }
        public decimal? Price { get; set; }

        public virtual Acrust CrustNavigation { get; set; }
        public virtual Aorder Order { get; set; }
        public virtual Asize SizeNavigation { get; set; }
    }
}
