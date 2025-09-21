using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bazar.Domain.Entitis
{
    public class UserProfiles
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]   
        public int Id { get; set; }
        [MaxLength(255)]
        public required string FirstName { get; set; }
        [MaxLength(255)]
        public required string LastName { get; set; }
        [MaxLength(255)]
        public required string PhoneNumber { get; set; }
        public required string ImageUrl { get; set; }
        public required DateTime dateTime { get; set; }
        public int UserLoginId { get; set; }
        public UserLogIn User { get; set; } = null!;

    }

}
