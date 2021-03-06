﻿using System;
using System.Collections.Generic;

namespace Backend.Models
{
    public partial class ClothingSuitcase
    {
        public int IdSuitcase { get; set; }
        public int IdClothing { get; set; }

        public virtual Clothing IdClothingNavigation { get; set; }
        public virtual Suitcase IdSuitcaseNavigation { get; set; }
    }
}
