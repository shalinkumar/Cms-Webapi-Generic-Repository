using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiHandiCrafts.Model.Comman
{
    public abstract class AuditableEntity<T> : Entity<T>, IAuditableEntity
    {
        public override T Id { get; set; }

        [ScaffoldColumn(false)]
        public DateTime? Created { get; set; }

        [MaxLength(256)]
        [ScaffoldColumn(false)]
        public string CreatedBy { get; set; }

        [ScaffoldColumn(false)]
        public DateTime? Modified { get; set; }

        [MaxLength(256)]
        [ScaffoldColumn(false)]
        public string ModifiedBy { get; set; }
    }
}
