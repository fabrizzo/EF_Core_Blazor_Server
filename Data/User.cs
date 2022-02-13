using System;
using System.Collections.Generic;

#nullable disable

namespace EF_Core_Blazor_Server
{
    public partial class User
    {
        public User()
        {
            Products = new HashSet<Product>();
        }

        public int PersonId { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public int? Age { get; set; }
        public string Phone { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }
}
