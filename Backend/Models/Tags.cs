using System;
using System.Collections.Generic;

namespace Backend.Models
{
    public partial class Tags
    {
        public Tags()
        {
            ClothingTag = new HashSet<ClothingTag>();
        }

        public int IdTag { get; set; }
        public string Name { get; set; }

        public virtual ClothingSetTag ClothingSetTag { get; set; }
        public virtual ICollection<ClothingTag> ClothingTag { get; set; }
    }
}
