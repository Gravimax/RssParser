using System.Xml.Serialization;

namespace RssParser
{
    /// <summary>
    /// Source is an optional sub-element of 'item'.
    /// It has one required attribute, url, which links to the XMLization of the source.
    /// </summary>
    [XmlType(TypeName = "source")]
    public class RssSource : RssParserBase, IRssSource
    {
        private string _source;
        /// <summary>
        /// The name of the RSS channel that the item came from, derived from its 'title'
        /// </summary>
        [XmlText]
        public string Source
        {
            get { return _source; }
            set
            {
                _source = value;
                OnPropertyChanged("Source");
            }
        }


        private string _url;
        /// <summary>
        /// The URL of the item.
        /// </summary>
        [XmlAttribute(DataType = "string", AttributeName = "url")]
        public string Url
        {
            get { return _url; }
            set
            {
                _url = value;
                OnPropertyChanged("Url");
            }
        }
    }
}
