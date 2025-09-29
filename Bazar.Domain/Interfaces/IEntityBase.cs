using Bazar.Domain.Entitis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bazar.Domain.Interfaces
{
    public interface IEntityBase<T> : IRepository<T> where T : class
    {
        Task<IEnumerable<T>> GetBooksByImageAsync(string Image);

    }
}
