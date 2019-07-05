using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MCH.Feature.Brands.Contract.ExternalApi
{
    public class BrandSearchResults
    {
        public int NumberOfEntries { get; set; }
        public int TotalNumberOfEntries { get; set; }
        public IEnumerable<BaseBrandInfo> Entries { get; set; }
    }
}