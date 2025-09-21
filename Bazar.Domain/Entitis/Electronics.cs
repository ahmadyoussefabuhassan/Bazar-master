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
    public class Electronics: BaseEntity
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public override int Id { get; set; }
        [MaxLength(255)]
        public required string TypeOfElectronics { get; set; }
        [MaxLength(255)]
        public override required string Location { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; } = null!;
        public int AdvertisementsId { get; set; }
        public Advertisements Advertisements { get; set; } = null!;
        public override ICollection<Images> Images { get; set; } = new List<Images>();


    }
}
