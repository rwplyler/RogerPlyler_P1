using System;
using System.Collections.Generic;

#nullable disable

namespace Repository.Models
{
    public partial class Atopping
    {
        public int Id { get; set; }
        public string ToppingName { get; set; }
        public decimal? ToppingPrice { get; set; }
    }
}
