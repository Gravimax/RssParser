using System.Xml.Serialization;

namespace RssParser
{
    /// <summary>
    /// Category is an optional sub-element of 'item' and 'channel'
    /// </summary>
    [XmlType(TypeName = "category")]
    public class RssCategory : RssParserBase, IRssCategory
    {
        private string _category;
        /// <summary>
        /// The category name.
        /// </summary>
        [XmlText]
        public string Category
        {
            get { return _category; }
            set
            {
                _category = value;
                OnPropertyChanged("Category");
            }
        }


        private string _domain;
        /// <summary>
        /// Identifies the categorization taxonomy. Optional.
        /// </summary>
        [XmlAttribute(DataType = "string", AttributeName = "domain")]
        public string Domain
        {
            get { return _domain; }
            set
            {
                _domain = value;
                OnPropertyChanged("Domain");
            }
        }
    }
}
