using System;
using System.Collections.Generic;

namespace ApiHandiCrafts.Contract.Models
{
    public partial class PageContentDesign
    {
        public int Id { get; set; }
        public string Content { get; set; }
        public int TemplateId { get; set; }
        public string PageName { get; set; }
        public Nullable<System.DateTime> Created { get; set; }
        public string CreatedBy { get; set; }
        public Nullable<System.DateTime> Modified { get; set; }
        public string ModifiedBy { get; set; }
    }
}
