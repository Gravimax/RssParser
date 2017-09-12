using System.Xml.Serialization;

namespace RssParser
{
    /// <summary>
    /// Enclosure is an optional sub-element of 'item'.
    /// </summary>
    [XmlType(TypeName = "enclosure")]
    public class RssEnclosure : RssParserBase, IRssEnclosure
    {
        private string _url;
        /// <summary>
        /// The url of the media.
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


        private long _length;
        /// <summary>
        /// The length of the media in bytes.
        /// </summary>
        [XmlAttribute(DataType = "long", AttributeName = "length")]
        public long Length
        {
            get { return _length; }
            set
            {
                _length = value;
                OnPropertyChanged("Length");
            }
        }


        private string _type;
        /// <summary>
        /// The type of media as a standard MIME type.
        /// </summary>
        [XmlAttribute(DataType = "string", AttributeName = "type")]
        public string Type
        {
            get { return _type; }
            set
            {
                _type = value;
                OnPropertyChanged("Type");
            }
        }
    }
}
