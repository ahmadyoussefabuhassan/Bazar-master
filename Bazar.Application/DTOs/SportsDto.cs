using Bazar.Application.HelpersApplication;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bazar.Application.DTOs
{
    public class SportsDto : BaseEntityDto
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public override required int Id { get; set; }
        [MaxLength(255)]
        public required string TypeOfKitchen { get; set; }
        [MaxLength(255)]
        public required string NameTrainer { get; set; }
        [MaxLength(255)]
        public override required string Location { get; set; }
        public override List<ImagesDto> Images { get; set; } = new List<ImagesDto>();

    }
}
