using System;
using System.Collections.Generic;

namespace Backend.Models
{
    public partial class Color
    {
        public Color()
        {
            ClothingColor = new HashSet<ClothingColor>();
        }

        public int IdColor { get; set; }
        public string Name { get; set; }

        public virtual ICollection<ClothingColor> ClothingColor { get; set; }
    }
}
