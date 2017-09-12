using System.Xml;
using System.Xml.Serialization;

namespace RssParser
{
    /// <summary>
    /// Guid is an optional sub-element of 'item'.
    /// A string that uniquely identifies the item.
    /// </summary>
    [XmlType(TypeName = "guid")]
    public class RssGuid : RssParserBase, IRssGuid
    {
        private string _guid;
        /// <summary>
        /// The guid.
        /// </summary>
        [XmlText]
        public string Guid
        {
            get { return _guid; }
            set
            {
                _guid = value;
                OnPropertyChanged("Guid");
            }
        }


        private bool _isPermaLink;
        /// <summary>
        /// isPermaLink is optional, its default value is true. If its value is false, 
        /// the guid may not be assumed to be a url, or a url to anything in particular.
        /// </summary>
        [XmlAttribute(DataType = "boolean", AttributeName = "isPermalink")]
        public bool IsPermaLink
        {
            get { return _isPermaLink; }
            set
            {
                _isPermaLink = value;
                OnPropertyChanged("IsPermaLink");
            }
        }
    }
}
