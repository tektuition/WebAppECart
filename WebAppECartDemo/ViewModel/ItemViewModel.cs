using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebAppECartDemo.ViewModel
{
    public class ItemViewModel
    {
        public Guid ItemId { get; set; }
        public int CategoryId { get; set; }
        public string ItemCode { get; set; }
        public string ItemName { get; set; }
        public string Description { get; set; }
        public decimal ItemPrice { get; set; }
        public HttpPostedFileBase ImagePath { get; set; }

        public IEnumerable<SelectListItem> CategorySelectListItem { get; set; }
    }
}