using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MCH.Feature.Brands.Contract.ExternalApi
{
    public class BaseBrandInfo
    {
        public int? EntryId { get; set; }
        public string CompanyNameSort { get; set; }
        public string CompanyName { get; set; }
        public string MainCategoryName { get; set; }
        public string BrandImageLargeUrl { get; set; }
        public string BrandImageSmallUrl { get; set; }
    }
}