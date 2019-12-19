using System;
using System.Collections.Generic;

namespace Backend.Models
{
    public partial class ClothingSetPicture
    {
        public int IdClothingSetPicture { get; set; }
        public string Title { get; set; }
        public string ImageUrl { get; set; }
        public int IdClothingSet { get; set; }
        public int IdClothingPurpose { get; set; }

        public virtual ClothingPurpose IdClothingPurposeNavigation { get; set; }
        public virtual ClothingSet IdClothingSetNavigation { get; set; }
    }
}
