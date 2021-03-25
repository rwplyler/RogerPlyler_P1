using System;
using System.Collections.Generic;

#nullable disable

namespace Repository.Models
{
    public partial class AorderedTopping
    {
        public int? ToppingId { get; set; }
        public int? PizzaId { get; set; }

        public virtual AorderedPizza Pizza { get; set; }
        public virtual Atopping Topping { get; set; }
    }
}
