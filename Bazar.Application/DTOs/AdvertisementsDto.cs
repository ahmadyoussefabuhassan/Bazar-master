using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bazar.Application.DTOs
{
    public class AdvertisementsDto
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [MaxLength(255)]
        public required string Name { get; set; }
        public required int Price { get; set; }
        [MaxLength(1000)]
        public required string Description { get; set; } = null!;
        public required int CategoryId { get; set; }
        public required int UserId { get; set; }
    }
}
