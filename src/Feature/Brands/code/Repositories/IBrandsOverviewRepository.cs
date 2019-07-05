using MCH.Feature.Brands.Contract.ExternalApi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MCH.Feature.Brands.Repositories
{
    public interface IBrandsOverviewRepository
    {
        BrandSearchResults GetBrandEntries(
            IBrandsOverviewItem brandsOverview,
            string searchTerm,
            int? categoryId,
            int? sectorId,
            int? hallId,
            int? offset,
            int? numberOfEntries = null);
    }
}