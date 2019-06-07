﻿using Sitecore.Data.Fields;
using Sitecore.Data.Items;
using Sitecore.Links;

namespace Sitecore.HabitatHome.Feature.Components.Models
{
    public class Component : ItemBase
    {
        private Site site;

        public string Title { get; set; }
        public string Subtitle { get; set; }
        public string Lead { get; set; }
        public string Content { get; set; }
        public Component TargetPage { get; set; }
        public string TargetUrl { get; set; }
        public MediaItem Image { get; set; }
        public ImageField ImageField { get; set; }



        public Site Site
        {
            get
            {
                if (site == null)
                {
                    site = new Site();
                }
                return site;
            }
        }



        //todo: use Foundation.SitecoreExtensions to resolve link field
        public string Url
        {
            get
            {
                string url = TargetPage?.Url;

                if (string.IsNullOrEmpty(url))
                {
                    url = TargetUrl;
                }
                if (string.IsNullOrEmpty(url))
                {
                    url = LinkManager.GetItemUrl(Item);
                }

                return url;
            }
        }
    }
}