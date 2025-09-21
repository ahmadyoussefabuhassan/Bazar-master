using Bazar.Application.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bazar.Application.HelpersApplication
{
    public abstract class BaseEntityDto
    { 
       public abstract required int Id { get; set; }
       public abstract required string Location { get; set; }
       public virtual List<ImagesDto> Images { get; set; } = new List<ImagesDto>();

    }
}
