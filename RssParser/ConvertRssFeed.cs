using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

namespace RssParser
{
    /// <summary>
    /// Converts a xml rss feed to a custom rss feed object.
    /// </summary>
    internal class ConvertRssFeed
    {
        /// <summary>
        /// Converts the specified RSS feed.
        /// </summary>
        /// <param name="rssXFeed">The RSS XDocument.</param>
        /// <returns></returns>
        public RssFeed Convert(XDocument rssXFeed)
        {
            RssFeed rssFeed = new RssFeed();

            rssFeed.Version = GetRssVersion(rssXFeed);
            rssFeed.Channel = GetChannel(rssXFeed);

            return rssFeed;
        }


        #region Get Main


        private RssChannel GetChannel(XDocument rssXFeed)
        {
            RssChannel rssChannel = new RssChannel();
            
            rssChannel.Title = GetChannelElement(rssXFeed, "title");
            rssChannel.Link = GetChannelElement(rssXFeed, "link");
            rssChannel.Description = GetChannelElement(rssXFeed, "description");
            rssChannel.Language = GetChannelElement(rssXFeed, "language");
            rssChannel.Copyright = GetChannelElement(rssXFeed, "copyright");
            rssChannel.ManagingEditor = GetChannelElement(rssXFeed, "managingEditor");
            rssChannel.WebMaster = GetChannelElement(rssXFeed, "webMaster");
            rssChannel.PubDate = GetChannelElement(rssXFeed, "pubDate");
            rssChannel.LastBuildDate = GetChannelElement(rssXFeed, "lastBuildDate");
            rssChannel.Generator = GetChannelElement(rssXFeed, "generator");
            rssChannel.Docs = GetChannelElement(rssXFeed, "docs");
            int _ttl;
            int.TryParse(GetChannelElement(rssXFeed, "ttl"), out _ttl);
            rssChannel.Ttl = _ttl;
            rssChannel.Rating = GetChannelElement(rssXFeed, "rating");
            rssChannel.SkipHours = GetChannelElement(rssXFeed, "skipHours");
            rssChannel.SkipDays = GetChannelElement(rssXFeed, "skipDays");

            rssChannel.Categories = GetRssCategories(rssXFeed);
            rssChannel.Cloud = GetRssCloud(rssXFeed);
            rssChannel.Image = GetRssImage(rssXFeed);
            rssChannel.Items = GetItems(rssXFeed);

            return rssChannel;
        }


        private List<RssCategory> GetRssCategories(XDocument rssXFeed)
        {
            List<RssCategory> cats = new List<RssCategory>();      

            var cat = (from channel in rssXFeed.Descendants("channel")
                       from item in channel.Descendants("category")
                       select item).ToList();

            foreach (XElement element in cat)
            {
                if (element.Parent.Name == "channel")
                {
                    cats.Add(new RssCategory { Domain = element.Attribute("domain") != null ? element.Attribute("domain").Value : null, Category = element.Value });
                }
            }

            return cats;
        }


        private RssCloud GetRssCloud(XDocument rssXFeed)
        {
            RssCloud rssCloud = new RssCloud();

            XElement cloudElement = (from channel in rssXFeed.Descendants("channel")
                                   from cloud in channel.Descendants("cloud")
                                   select cloud).SingleOrDefault();

            if (cloudElement != null && cloudElement.HasAttributes)
            {
                rssCloud.Domain = cloudElement.Attribute("domain").Value;
                rssCloud.Port = cloudElement.Attribute("port").Value;
                rssCloud.Path = cloudElement.Attribute("path").Value;
                rssCloud.RegisterProcedure = cloudElement.Attribute("registerProcedure").Value;
                rssCloud.Protocol = cloudElement.Attribute("protocol").Value;
            }

            return rssCloud;
        }


        private RssImage GetRssImage(XDocument rssXFeed)
        {
            RssImage image = new RssImage();

            XElement temp = (from channel in rssXFeed.Descendants("channel")
                         from x in channel.Descendants("image")
                         select x).FirstOrDefault();

            image.Url = GetItemElement(temp, "url");
            image.Title = GetItemElement(temp, "title");
            image.Link = GetItemElement(temp, "link");
            image.Description = GetItemElement(temp, "description");

            int _width;
            int.TryParse(GetItemElement(temp, "width"), out _width);
            image.Width = _width;

            int _height;
            int.TryParse(GetItemElement(temp, "height"), out _height);
            image.Height = _height;

            return image;
        }


        #endregion


        #region Rss Feed Items


        private List<RssItem> GetItems(XDocument rssXFeed)
        {
            List<RssItem> rssItems = new List<RssItem>();

            var items = (from channel in rssXFeed.Descendants("channel")
                         from item in channel.Descendants("item")
                         select item).ToList();

            foreach (XElement element in items)
            {
                rssItems.Add(new RssItem
                {
                    Title = GetItemTitle(element),
                    Link = GetItemElement(element, "link"),
                    Description = GetItemDescription(element),
                    Author = GetItemElement(element, "author"),
                    Comments = GetItemElement(element, "comments"),
                    PubDate = GetItemElement(element, "pubDate"),
                    Categories = GetItemCategories(element),
                    Enclosure = GetItemEnclosure(element),
                    Guid = GetItemGuid(element),
                    Source = GetItemSource(element)
                });
            }

            return rssItems;
        }


        private List<RssCategory> GetItemCategories(XElement element)
        {
            List<RssCategory> cats = new List<RssCategory>();

            var items = element.Elements("category");

            foreach (XElement xElement in items)
            {
                cats.Add(new RssCategory { Domain = xElement.Attribute("domain") != null ? xElement.Attribute("domain").Value : null, Category = xElement.Value });
            }

            return cats;
        }


        private RssEnclosure GetItemEnclosure(XElement element)
        {
            RssEnclosure enclosure = new RssEnclosure();

            enclosure.Url = GetItemElement(element, "url");
            long _length;
            long.TryParse(GetItemElement(element, "length"), out _length);
            enclosure.Length = _length;
            enclosure.Type = GetItemElement(element, "type");

            return enclosure;
        }


        private RssGuid GetItemGuid(XElement element)
        {
            RssGuid guid = new RssGuid();

            bool _isPermaLink;
            bool.TryParse(GetItemElement(element, "isPermaLink"), out _isPermaLink);
            guid.IsPermaLink = _isPermaLink;

            XElement selected = (from channelItem in element.Descendants("guid")
                                 select channelItem).FirstOrDefault();

            if (selected != null) { guid.Guid = selected.Value; }

            return guid;
        }


        private RssSource GetItemSource(XElement element)
        {
            RssSource source = new RssSource();

            source.Url = GetItemElement(element, "url");

            XElement selected = (from channelItem in element.Descendants("source")
                                 select channelItem).FirstOrDefault();

            if (selected != null) { source.Source = selected.Value; }

            return source;
        }


        private string GetItemTitle(XElement element)
        {
            if (element != null)
            {
                XElement selected = (from channelItem in element.Descendants("title")
                                     select channelItem).FirstOrDefault();

                return selected != null ? selected.Value : null;
            }

            return null;
        }


        public string GetItemDescription(XElement element)
        {
            if (element != null)
            {
                XElement selected = (from channelItem in element.Descendants("description")
                                     select channelItem).FirstOrDefault();

                if (selected != null)
                {
                    return selected.Value;
                }

                return null;
            }

            return null;
        }


        #endregion


        #region Convert support methods


        /// <summary>
        /// Gets the RSS feed version number.
        /// </summary>
        /// <returns>Double</returns>
        private double GetRssVersion(XDocument rssXFeed)
        {
            double xVersion = 0.0;
            double.TryParse(GetElementAttribute(rssXFeed, "rss", "version"), out xVersion);
            return xVersion;
        }


        private string GetChannelElement(XDocument rssXFeed, string element)
        {
            XElement selected = (from channel in rssXFeed.Descendants("channel")
                                 from elements in channel.Elements(element)
                                 select elements).FirstOrDefault();

            return selected != null ? selected.Value : string.Empty;
        }


        private string GetElementAttribute(XDocument rssXFeed, string element, string attribute)
        {
            XElement xNode = (from x in rssXFeed.Descendants(element)
                              select x).SingleOrDefault();

            if (xNode != null && xNode.HasAttributes) return xNode.Attribute(attribute).Value;
            return string.Empty;
        }


        private string GetItemElement(XElement xElement, string element)
        {
            if (xElement != null && xElement.HasElements)
            {
                XElement selected = (from channelItem in xElement.Descendants(element)
                                     select channelItem).FirstOrDefault();

                return selected != null ? selected.Value : string.Empty;
            }

            return null;
        }


        #endregion
    }
}
