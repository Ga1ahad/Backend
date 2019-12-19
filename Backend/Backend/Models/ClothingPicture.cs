using System;
using System.Collections.Generic;

namespace Backend.Models
{
    public partial class ClothingPicture
    {
        public int IdClothingPicture { get; set; }
        public string Title { get; set; }
        public string ImageUrl { get; set; }
        public int IdClothin { get; set; }

        public virtual Clothing IdClothinNavigation { get; set; }
    }
}
