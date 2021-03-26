using System;
using System.Collections.Generic;

#nullable disable

namespace Models
{
    public partial class Acustomer
    {
        public Acustomer()
        {
            Aorders = new HashSet<Aorder>();
        }

        public int Id { get; set; }
        public string Fname { get; set; }
        public string Lname { get; set; }

        public virtual ICollection<Aorder> Aorders { get; set; }
    }
}
