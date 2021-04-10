using System;
using System.Collections.Generic;
using System.Text;

namespace MealOrdering.Server.Data.Models
{
    public class User
    {
        public int Id { get; set; }

        public DateTime CreateDate { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EMailAddress { get; set; }
        public string Password { get; set; }
        public bool IsActive { get; set; }


        public virtual ICollection<Order> Orders { get; set; }
        public virtual ICollection<OrderItem> CreatedOrderItems { get; set; }
    }
}
