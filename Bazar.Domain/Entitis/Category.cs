using Bazar.Domain.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bazar.Domain.Entitis
{
    public class Category : BaseEntityICollection
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [MaxLength(255)]
        public required string Name { get; set; }
        public List<string> Items { get; set; } = new List<string>();
        public ICollection<Advertisements> Advertisements { get; set; } = new List<Advertisements>();
        public override ICollection<Furniture> Furnitures { get; set; } = new List<Furniture>();
        public override ICollection<Kitchen> Kitchens { get; set; } = new List<Kitchen>();
        public override ICollection<Sports> Sports { get; set ; } = new List<Sports>();
        public override ICollection<Electronics> Electronics { get; set; } = new List<Electronics>();
        public override ICollection<Books> Books { get; set; } = new List<Books>();
        public override ICollection<Animals> Animals { get; set; } = new List<Animals>();

    }
}
