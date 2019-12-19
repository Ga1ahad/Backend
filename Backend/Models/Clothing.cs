using System;
using System.Collections.Generic;

namespace Backend.Models
{
    public partial class Clothing
    {
        public Clothing()
        {
            ClothingColor = new HashSet<ClothingColor>();
            ClothingPicture = new HashSet<ClothingPicture>();
            ClothingPurposeClothing = new HashSet<ClothingPurposeClothing>();
            ClothingSetClothing = new HashSet<ClothingSetClothing>();
            ClothingSuitcase = new HashSet<ClothingSuitcase>();
            ClothingTag = new HashSet<ClothingTag>();
        }

        public int IdClothing { get; set; }
        public string Name { get; set; }
        public int IdClothingType { get; set; }
        public string Description { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime DeletedAt { get; set; }
        public int IdBodyPart { get; set; }
        public int IdPattern { get; set; }
        public int IdUser { get; set; }

        public virtual BodyPart IdBodyPartNavigation { get; set; }
        public virtual ClothingType IdClothingTypeNavigation { get; set; }
        public virtual Pattern IdPatternNavigation { get; set; }
        public virtual User IdUserNavigation { get; set; }
        public virtual ICollection<ClothingColor> ClothingColor { get; set; }
        public virtual ICollection<ClothingPicture> ClothingPicture { get; set; }
        public virtual ICollection<ClothingPurposeClothing> ClothingPurposeClothing { get; set; }
        public virtual ICollection<ClothingSetClothing> ClothingSetClothing { get; set; }
        public virtual ICollection<ClothingSuitcase> ClothingSuitcase { get; set; }
        public virtual ICollection<ClothingTag> ClothingTag { get; set; }
    }
}
