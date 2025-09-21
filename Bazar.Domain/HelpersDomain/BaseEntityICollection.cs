using Bazar.Domain.Entitis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bazar.Domain.Helpers
{
    public abstract class BaseEntityICollection
    {
        public virtual ICollection<Furniture> Furnitures { get; set; } = new List<Furniture>();
        public virtual ICollection<Kitchen> Kitchens { get; set; } = new List<Kitchen>();
        public virtual ICollection<Sports> Sports { get; set; } = new List<Sports>();
        public virtual ICollection<Electronics> Electronics { get; set; } = new List<Electronics>();
        public virtual ICollection<Books> Books { get; set; } = new List<Books>();
        public virtual ICollection<Animals> Animals { get; set; } = new List<Animals>();
    }
}
