using System;
using System.Collections.Generic;

namespace ApiHandiCrafts.Contract.Models
{
    public partial class Products
    {
        public int Id { get; set; }
        public string ContentType { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string ImageSrc { get; set; }
        public string ItamName { get; set; }
        public string ItemCode { get; set; }
        public Nullable<decimal> ItemPrice { get; set; }
        public Nullable<int> ItemReview { get; set; }
        public Nullable<System.DateTime> Created { get; set; }
        public string CreatedBy { get; set; }
        public Nullable<System.DateTime> Modified { get; set; }
        public string ModifiedBy { get; set; }
    }
}
