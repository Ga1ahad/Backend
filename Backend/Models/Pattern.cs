using System;
using System.Collections.Generic;

namespace Backend.Models
{
    public partial class Pattern
    {
        public Pattern()
        {
            Clothing = new HashSet<Clothing>();
        }

        public int IdPattern { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Clothing> Clothing { get; set; }
    }
}
