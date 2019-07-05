using System;
using Sitecore.Data.Items;
using System.Web.Mvc;
using Sitecore.XA.Foundation.Mvc.Controllers;
using Sitecore.Mvc.Presentation;

namespace MCH.Feature.Brands.Controllers
{
    public class BrandsOverviewController : StandardController
    {
        private Item dataSourceItem;

        public override ActionResult Index()
        {
            return base.Index();
        }

        protected Item DataSourceItem
        {
            get
            {
                var dataSource = RenderingContext.CurrentOrNull.Rendering.DataSource;
                if (dataSourceItem == null &&
                    !string.IsNullOrEmpty(dataSource))
                    dataSourceItem = Sitecore.Context.Database.GetItem(dataSource);
                return dataSourceItem;
            }
        }
    }
}