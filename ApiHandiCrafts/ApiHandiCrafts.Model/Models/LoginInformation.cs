using System;
using System.Collections.Generic;

namespace ApiHandiCrafts.Contract.Models
{
    public partial class LoginInformation
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }
        public Nullable<System.DateTime> Created { get; set; }
        public Nullable<System.DateTime> Modified { get; set; }
    }
}
