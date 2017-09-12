using System.Collections.Generic;
using System.Xml;
using System.Xml.Serialization;

namespace RssParser
{
    /// <summary>
    /// Channel is a required element that contains all the feed data.
    /// </summary>
    [XmlType(TypeName = "channel")]
    public class RssChannel : RssParserBase, IRssChannel
    {
        #region Required Rss channel fields


        private string _title;
        /// <summary>
        /// The name of the channel.
        /// </summary>
        [XmlElement(DataType = "string", ElementName = "title")]
        public string Title
        {
            get { return _title; }
            set
            {
                _title = value;
                OnPropertyChanged("Title");
            }
        }


        private string _link;
        /// <summary>
        /// The URL to the HTML website corresponding to the channel.
        /// </summary>
        [XmlElement(ElementName = "link")]
        public string Link
        {
            get { return _link; }
            set
            {
                _link = value;
                OnPropertyChanged("Link");
            }
        }


        private string _description;
        /// <summary>
        /// Phrase or sentence describing the channel.
        /// </summary>
        [XmlElement(DataType = "string", ElementName = "description")]
        public string Description
        {
            get { return _description; }
            set
            {
                _description = value;
                OnPropertyChanged("Description");
            }
        }


        #endregion


        #region Optional Rss channel fields


        private string _language;
        /// <summary>
        /// The language the channel is written in.
        /// </summary>
        [XmlElement(DataType = "string", ElementName = "language")]
        public string Language
        {
            get { return _language; }
            set
            {
                _language = value;
                OnPropertyChanged("Language");
            }
        }


        private string _copyright;
        /// <summary>
        /// Copyright notice for content in the channel.
        /// </summary>
        [XmlElement(ElementName = "copyright")]
        public string Copyright
        {
            get { return _copyright; }
            set
            {
                _copyright = value;
                OnPropertyChanged("Copyright");
            }
        }


        private string _managingEditor;
        /// <summary>
        /// Email address for person responsible for editorial content.
        /// </summary>
        [XmlElement(DataType = "string", ElementName = "managingEditor")]
        public string ManagingEditor
        {
            get { return _managingEditor; }
            set
            {
                _managingEditor = value;
                OnPropertyChanged("ManagingEditor");
            }
        }


        private string _webMaster;
        /// <summary>
        /// Email address for person responsible for technical issues relating to channel.
        /// </summary>
        [XmlElement(DataType = "string", ElementName = "webMaster")]
        public string WebMaster
        {
            get { return _webMaster; }
            set
            {
                _webMaster = value;
                OnPropertyChanged("WebMaster");
            }
        }


        private string _pubDate;
        /// <summary>
        /// The publication date for the content in the channel.
        /// </summary>
        [XmlElement(DataType = "string", ElementName = "pubDate")]
        public string PubDate
        {
            get { return _pubDate; }
            set
            {
                _pubDate = value;
                OnPropertyChanged("PubDate");
            }
        }


        private string _lastBuildDate;
        /// <summary>
        /// The last time the content of the channel changed.
        /// </summary>
        [XmlElement(DataType = "string", ElementName = "lastBuildDate")]
        public string LastBuildDate
        {
            get { return _lastBuildDate; }
            set
            {
                _lastBuildDate = value;
                OnPropertyChanged("LastBuildDate");
            }
        }


        private List<RssCategory> _categories;
        /// <summary>
        /// Specify one or more categories that the channel belongs to.
        /// </summary>
        [XmlElement("category")]
        public List<RssCategory> Categories
        {
            get { return _categories; }
            set
            {
                _categories = value;
                OnPropertyChanged("Categories");
            }
        }


        private string _generator;
        /// <summary>
        /// A string indicating the program used to generate the channel.
        /// </summary>
        [XmlElement(DataType = "string", ElementName = "generator")]
        public string Generator
        {
            get { return _generator; }
            set
            {
                _generator = value;
                OnPropertyChanged("Generator");
            }
        }


        private string _docs;
        /// <summary>
        /// A URL that points to the documentation for the format used in the RSS file.
        /// </summary>
        [XmlElement(DataType = "string", ElementName = "docs")]
        public string Docs
        {
            get { return _docs; }
            set
            {
                _docs = value;
                OnPropertyChanged("Docs");
            }
        }


        private RssCloud _cloud;
        /// <summary>
        /// Allows processes to register with a cloud to be notified of updates to the channel, 
        /// implementing a lightweight publish-subscribe protocol for RSS feeds.
        /// </summary>
        [XmlElement(ElementName = "cloud")]
        public RssCloud Cloud
        {
            get { return _cloud; }
            set
            {
                _cloud = value;
                OnPropertyChanged("Cloud");
            }
        }


        private int _ttl;
        /// <summary>
        /// The number of minutes that indicates how long a channel can be cached before refreshing.
        /// </summary>
        [XmlElement(DataType = "int", ElementName = "ttl")]
        public int Ttl
        {
            get { return _ttl; }
            set
            {
                _ttl = value;
                OnPropertyChanged("Ttl");
            }
        }


        private string _rating;
        /// <summary>
        /// The PICS rating for the channel.
        /// </summary>
        [XmlElement(DataType = "string", ElementName = "rating")]
        public string Rating
        {
            get { return _rating; }
            set
            {
                _rating = value;
                OnPropertyChanged("Rating");
            }
        }


        private string _skipHours;
        /// <summary>
        /// A hint for aggregators telling them which hours they can skip.
        /// </summary>
        [XmlElement(DataType = "string", ElementName = "skipHours")]
        public string SkipHours
        {
            get { return _skipHours; }
            set
            {
                _skipHours = value;
                OnPropertyChanged("SkipHours");
            }
        }


        private string _skipDays;
        /// <summary>
        /// A hint for aggregators telling them which days they can skip.
        /// </summary>
        [XmlElement(DataType = "string", ElementName = "skipDays")]
        public string SkipDays
        {
            get { return _skipDays; }
            set
            {
                _skipDays = value;
                OnPropertyChanged("SkipDays");
            }
        }


        private RssImage _image;
        /// <summary>
        /// Specifies a GIF, JPEG or PNG image that can be displayed with the channel.
        /// </summary>
        [XmlElement(ElementName = "image")]
        public RssImage Image
        {
            get { return _image; }
            set
            {
                _image = value;
                OnPropertyChanged("Image");
            }
        }


        private List<RssItem> _items;
        /// <summary>
        /// The list of news items.
        /// </summary>
        [XmlElement("item")]
        public List<RssItem> Items
        {
            get { return _items; }
            set
            {
                _items = value;
                OnPropertyChanged("Items");
            }
        }


        #endregion
    }
}
