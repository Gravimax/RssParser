using System.Collections.Generic;
using System.Xml;
using System.Xml.Serialization;

namespace RssParser
{
    /// <summary>
    /// All elements of an item are optional, 
    /// however at least one of title or description must be present. 
    /// </summary>
    [XmlType(TypeName = "item")]
    public class RssItem : RssParserBase, IRssItem
    {
        private string _title;
        /// <summary>
        /// The title of the item.
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
        /// The URL of the item.
        /// </summary>
        [XmlElement(DataType = "string", ElementName = "link")]
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
        /// The item synopsis.
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


        private string _author;
        /// <summary>
        /// Email address of the author of the item.
        /// </summary>
        [XmlElement(DataType = "string", ElementName = "author")]
        public string Author
        {
            get { return _author; }
            set
            {
                _author = value;
                OnPropertyChanged("Author");
            }
        }


        private List<RssCategory> _categories;
        /// <summary>
        /// Includes the item in one or more categories.
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


        private string _comments;
        /// <summary>
        /// URL of a page for comments relating to the item.
        /// </summary>
        [XmlElement(DataType = "string", ElementName = "comments")]
        public string Comments
        {
            get { return _comments; }
            set
            {
                _comments = value;
                OnPropertyChanged("Comments");
            }
        }


        private RssEnclosure _enclosure;
        /// <summary>
        /// Describes a media object that is attached to the item.
        /// </summary>
        [XmlElement(ElementName = "enclosure")]
        public RssEnclosure Enclosure
        {
            get { return _enclosure; }
            set
            {
                _enclosure = value;
                OnPropertyChanged("Enclosure");
            }
        }


        private RssGuid _guid;
        /// <summary>
        /// A string that uniquely identifies the item.
        /// </summary>
        [XmlElement(ElementName = "guid")]
        public RssGuid Guid
        {
            get { return _guid; }
            set
            {
                _guid = value;
                OnPropertyChanged("Guid");
            }
        }


        private string _pubDate;
        /// <summary>
        /// The publication date for the item.
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


        private RssSource _source;
        /// <summary>
        /// The RSS channel that the item came from.
        /// </summary>
        [XmlElement(ElementName = "source")]
        public RssSource Source
        {
            get { return _source; }
            set
            {
                _source = value;
                OnPropertyChanged("Source");
            }
        }
    }
}
