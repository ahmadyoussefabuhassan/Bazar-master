using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bazar.Application.DTOs
{
    public class ImagesDto
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public required byte[] ImageData { get; set; }
        public required string ContentType { get; set; }
        public required string EntityType { get; set; }
        public required int EntityId { get; set; }
    }
}
