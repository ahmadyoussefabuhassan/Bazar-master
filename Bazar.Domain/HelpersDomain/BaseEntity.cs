using Bazar.Domain.Entitis;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bazar.Domain.Helpers
{
    public abstract class BaseEntity 
    {
        public abstract int Id { get; set; }
        public abstract required string Location { get; set; }
        public virtual ICollection<Images> Images { get; set; }  = new List<Images>();
    }

}
