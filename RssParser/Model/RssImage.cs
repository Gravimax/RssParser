using System.Xml.Serialization;

namespace RssParser
{
    /// <summary>
    /// Image is an optional sub-element of 'channel', 
    /// which contains three required and three optional sub-elements.
    /// </summary>
    [XmlType(TypeName = "image")]
    public class RssImage : RssParserBase, IRssImage
    {
        #region Required image sub-elements


        private string _url;
        /// <summary>
        /// The URL of a GIF, JPEG or PNG image that represents the channel. 
        /// </summary>
        [XmlElement(DataType = "string", ElementName = "url")]
        public string Url
        {
            get { return _url; }
            set
            {
                _url = value;
                OnPropertyChanged("Url");
            }
        }


        private string _title;
        /// <summary>
        /// Describes the image, it's used in the ALT attribute of the HTML &amp; &lt;img&gt; tag when the channel is rendered in HTML. 
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
        /// Is the URL of the site, when the channel is rendered, the image is a link to the site. 
        /// Note, in practice the image &lt;title&gt; and &lt;link&gt; should have the same value as the channel's &lt;title&gt; and &lt;link&gt;.
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


        #endregion


        #region Optional image sub-elements


        private string _description;
        /// <summary>
        /// Contains text that is included in the TITLE attribute of the link formed around the image in the HTML rendering.
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


        private int _width;
        /// <summary>
        /// Maximum value for width is 144, default value is 88. 
        /// </summary>
        [XmlElement(DataType = "int", ElementName = "width")]
        public int Width
        {
            get { return _width; }
            set
            {
                _width = value;
                OnPropertyChanged("Width");
            }
        }


        private int _height;
        /// <summary>
        /// Maximum value for height is 400, default value is 31.
        /// </summary>
        [XmlElement(DataType = "int", ElementName = "height")]
        public int Height
        {
            get { return _height; }
            set
            {
                _height = value;
                OnPropertyChanged("Height");
            }
        }


        #endregion
    }
}
