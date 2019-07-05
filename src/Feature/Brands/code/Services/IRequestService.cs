using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCH.Feature.Brands.Services
{
    public interface IRequestService
    {
        Task<T> GetAsync<T>(Uri uri);
    }
}
