using System;
using System.Collections.Generic;

namespace Backend.Models
{
    public partial class ClothingPurposeClothing
    {
        public int IdClothingPurpose { get; set; }
        public int IdClothing { get; set; }

        public virtual Clothing IdClothingNavigation { get; set; }
        public virtual ClothingPurpose IdClothingPurposeNavigation { get; set; }
    }
}
