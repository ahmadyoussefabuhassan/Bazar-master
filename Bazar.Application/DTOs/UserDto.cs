using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bazar.Application.DTOs
{
    public class UserDto
    {
        public int Id { get; set; }
        public int UserProfileId { get; set; }
        public UserProfilesDto UserProfile { get; set; } = null!;
        public List<AdvertisementsDto> Advertisements { get; set; } = new List<AdvertisementsDto>();

    }
}