using System;
using System.Collections.Generic;

namespace Backend.Models
{
    public partial class ClothingSetTag
    {
        public int IdTag { get; set; }
        public int IdClothingSet { get; set; }

        public virtual ClothingSet IdClothingSetNavigation { get; set; }
        public virtual Tags IdTagNavigation { get; set; }
    }
}
