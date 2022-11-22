using System;
using System.Collections.Generic;

namespace BootsAndCats
{
    public partial class User
    {
        public User()
        {
            Reviews = new HashSet<Review>();
        }

        public int Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? UserName { get; set; }
        public string? Password { get; set; }

        public virtual ICollection<Review> Reviews { get; set; }
    }
}
