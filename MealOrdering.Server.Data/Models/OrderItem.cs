using System;
using System.Collections.Generic;
using System.Text;

namespace MealOrdering.Server.Data.Models
{
    public class OrderItem
    {
        public int Id { get; set; }
        public DateTime CreateDate  { get; set; }
        public int CreatedUserId { get; set; }
        public int OrderId { get; set; }
        public string  Description  { get; set; }


        public virtual User CreatedUser { get; set; }
        public virtual Order Order { get; set; }
    }
}
