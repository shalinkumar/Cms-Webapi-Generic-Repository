﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiHandiCrafts.Model.Comman
{
    public interface IAuditableEntity
    {
        DateTime? Created { get; set; }

        string CreatedBy { get; set; }

        DateTime? Modified { get; set; }

        string ModifiedBy { get; set; }
    }
}
