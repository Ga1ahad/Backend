using System;
using System.Collections.Generic;

namespace Backend.Models
{
    public partial class ClothingSet
    {
        public ClothingSet()
        {
            ClothingSetClothing = new HashSet<ClothingSetClothing>();
            ClothingSetPicture = new HashSet<ClothingSetPicture>();
            ClothingSetTag = new HashSet<ClothingSetTag>();
        }

        public int IdClothingSet { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public DateTime DeletedAt { get; set; }

        public virtual ICollection<ClothingSetClothing> ClothingSetClothing { get; set; }
        public virtual ICollection<ClothingSetPicture> ClothingSetPicture { get; set; }
        public virtual ICollection<ClothingSetTag> ClothingSetTag { get; set; }
    }
}
