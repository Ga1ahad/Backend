using System;
using System.Collections.Generic;

namespace Backend.Models
{
    public partial class ClothingSetClothing
    {
        public int IdClothing { get; set; }
        public int IdClothingSet { get; set; }

        public virtual Clothing IdClothingNavigation { get; set; }
        public virtual ClothingSet IdClothingSetNavigation { get; set; }
    }
}
