using System;
using System.Collections.Generic;

namespace Backend.Models
{
    public partial class ClothingPurpose
    {
        public ClothingPurpose()
        {
            ClothingPurposeClothing = new HashSet<ClothingPurposeClothing>();
            ClothingSetPicture = new HashSet<ClothingSetPicture>();
        }

        public int IdClothingPurpose { get; set; }
        public string Name { get; set; }

        public virtual ICollection<ClothingPurposeClothing> ClothingPurposeClothing { get; set; }
        public virtual ICollection<ClothingSetPicture> ClothingSetPicture { get; set; }
    }
}
