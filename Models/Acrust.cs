using System;
using System.Collections.Generic;

#nullable disable

namespace Repository.Models
{
    public partial class Acrust
    {
        public Acrust()
        {
            AorderedPizzas = new HashSet<AorderedPizza>();
            Apizzas = new HashSet<Apizza>();
        }

        public int Id { get; set; }
        public string CrustName { get; set; }
        public decimal? CrustPrice { get; set; }

        public virtual ICollection<AorderedPizza> AorderedPizzas { get; set; }
        public virtual ICollection<Apizza> Apizzas { get; set; }
    }
}
