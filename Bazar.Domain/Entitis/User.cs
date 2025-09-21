using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bazar.Domain.Entitis
{
    public class User
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int UserPrfileId { get; set; }
        public UserProfiles UserPrfile { get; set; } = null!;
        public List<Advertisements> Advertisements { get; set; } = new List<Advertisements>();

    }

}
