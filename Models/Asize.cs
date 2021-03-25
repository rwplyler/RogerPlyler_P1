using System;
using System.Collections.Generic;

#nullable disable

namespace Repository.Models
{
    public partial class Asize
    {
        public Asize()
        {
            AorderedPizzas = new HashSet<AorderedPizza>();
            Apizzas = new HashSet<Apizza>();
        }

        public int Id { get; set; }
        public string SizeName { get; set; }
        public decimal? SizePrice { get; set; }

        public virtual ICollection<AorderedPizza> AorderedPizzas { get; set; }
        public virtual ICollection<Apizza> Apizzas { get; set; }
    }
}
