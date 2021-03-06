﻿using System;
using System.Collections.Generic;

namespace Backend.Models
{
    public partial class User
    {
        public User()
        {
            Clothing = new HashSet<Clothing>();
            Suitcase = new HashSet<Suitcase>();
        }

        public int IdUser { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Salt { get; set; }
        public string AvatarUrl { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime DeletedAt { get; set; }
        public DateTime LastLogin { get; set; }

        public virtual ICollection<Clothing> Clothing { get; set; }
        public virtual ICollection<Suitcase> Suitcase { get; set; }
    }
}
