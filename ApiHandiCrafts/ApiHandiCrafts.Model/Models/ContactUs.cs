using System;
using System.Collections.Generic;

namespace ApiHandiCrafts.Contract.Models
{
    public partial class ContactUs
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Subject { get; set; }
        public string Department { get; set; }
        public bool EmailSentToDepartment { get; set; }
        public System.DateTime Created { get; set; }
        public string CreatedBy { get; set; }
    }
}
