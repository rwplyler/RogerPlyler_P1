using System;
using System.Collections.Generic;

#nullable disable

namespace Repository.Models
{
    public partial class ApizzaTopping
    {
        public int? ToppingId { get; set; }
        public int? PizzaId { get; set; }

        public virtual Apizza Pizza { get; set; }
        public virtual Atopping Topping { get; set; }
    }
}
