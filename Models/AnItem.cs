using System;
using System.Collections.Generic;

#nullable disable

namespace Models
{
    public partial class AnItem
    {
        public int Id { get; set; }
        public string ItemName { get; set; }
        public decimal? Price { get; set; }
    }
}
