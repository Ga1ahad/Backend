using System;
using System.Collections.Generic;

namespace Backend.Models
{
    public partial class Trip
    {
        public Trip()
        {
            Suitcase = new HashSet<Suitcase>();
        }

        public int IdTrip { get; set; }
        public string Name { get; set; }
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime DeletedAt { get; set; }

        public virtual ICollection<Suitcase> Suitcase { get; set; }
    }
}
