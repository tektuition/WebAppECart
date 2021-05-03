using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAppECartDemo.ViewModel
{
    public class ShoppingViewModel
    {
        public Guid ItemId { get; set; }
        public string ItemName { get; set; }
        public decimal ItemPrice { get; set; }
        public string ImagePath { get; set; }
        public string Description { get; set; }
        public string ItemCode { get; set; }
        public string Category { get; set; }
    }
}