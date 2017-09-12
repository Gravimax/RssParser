using System.Xml.Serialization;

namespace RssParser
{
    /// <summary>
    /// RSS 2.0 Specification: http://cyber.law.harvard.edu/rss/rss.html
    /// http://www.w3schools.com/rss/default.asp
    /// </summary>
    [XmlRoot("rss", IsNullable = false)]
    public class RssFeed : RssParserBase, IRssFeed
    {
        private double _version;
        /// <summary>
        /// The RSS version number.
        /// </summary>
        [XmlAttribute(DataType = "double", AttributeName = "version")]
        public double Version 
        {
            get { return _version; }
            set
            {
                _version = value;
                OnPropertyChanged("Version");
            }
        }


        private RssChannel _channel;
        /// <summary>
        /// The required channel element
        /// </summary>
        [XmlElement(ElementName = "channel", IsNullable = false)]
        public RssChannel Channel 
        {
            get { return _channel; }
            set
            {
                _channel = value;
                OnPropertyChanged("Channel");
            }
        }
    }
}
