using System;
using System.Collections.Generic;

namespace Backend.Models
{
    public partial class ClothingType
    {
        public ClothingType()
        {
            Clothing = new HashSet<Clothing>();
        }

        public int IdClothingType { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Clothing> Clothing { get; set; }
    }
}
