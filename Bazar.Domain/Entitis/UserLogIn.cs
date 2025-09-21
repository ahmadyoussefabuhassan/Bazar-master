using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bazar.Domain.Entitis
{
    public class UserLogIn : IdentityUser
    {
        public UserProfiles UserProfiles { get; set; } = null!;
    }
}
