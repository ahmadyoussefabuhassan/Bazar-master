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
    public class Advertisements : BaseEntityICollection
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [MaxLength(255)]
        public required string Name { get; set; }
        public required int Price { get; set; }
        public required string Description { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; } = null!;
        public int UserId { get; set; }
        public User? User { get; set; }
        public override ICollection<Furniture> Furnitures { get; set; } = new List<Furniture>();
        public override ICollection<Kitchen> Kitchens { get; set; } = new List<Kitchen>();
        public override ICollection<Sports> Sports { get; set; } = new List<Sports>();
        public override ICollection<Electronics> Electronics { get; set; } = new List<Electronics>();
        public override ICollection<Books> Books { get; set; } = new List<Books>();
        public override ICollection<Animals> Animals { get; set; } = new List<Animals>();
    }

}
