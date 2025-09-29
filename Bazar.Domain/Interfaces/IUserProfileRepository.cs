using Bazar.Domain.Entitis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bazar.Domain.Interfaces
{
    public interface IUserProfileRepository :IRepository<UserProfiles>
    {
        Task<IEnumerable<Advertisements>> GetAdvertisementsByUserAsync();
        Task<UserProfiles> GetByName(string name);

    }
}
