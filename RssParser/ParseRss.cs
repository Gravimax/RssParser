using System;
using System.IO;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace RssParser
{
    /// <summary>
    /// Converts an rss document to an RssFeed object or an RssFeed object to an xml string.
    /// </summary>
    public class ParseRss
    {
        /// <summary>
        /// Parses the RSS feed from a url or local file.
        /// </summary>
        /// <param name="uri">The URI.</param>
        /// <returns>
        /// RssFeed Object
        /// </returns>
        /// <exception cref="System.Exception">The uri or path must be absolute</exception>
        /// <exception cref="System.ArgumentNullException">uri can not be null or empty</exception>
        public RssFeed Parse(Uri uri)
        {

            if (uri != null && !string.IsNullOrEmpty(uri.OriginalString))
            {
                return Parse(XDocument.Load(uri.OriginalString));
            }
            else
            {
                throw new ArgumentNullException("uri can not be null or empty");
            }
        }


        /// <summary>
        /// Converts an rss xml string.
        /// </summary>
        /// <param name="xmlString">The XML string.</param>
        /// <returns>
        /// RssFeed Object
        /// </returns>
        /// <exception cref="System.ArgumentNullException">xmlString can not be null or empty</exception>
        public RssFeed Parse(string xmlString)
        {
            if (!string.IsNullOrEmpty(xmlString))
            {
                return Parse(XDocument.Parse(xmlString));
            }
            else
            {
                throw new ArgumentNullException("xmlString can not be null or empty");
            }
        }


        /// <summary>
        /// Converts the RSS feed from an XDocument.
        /// </summary>
        /// <param name="xdoc">The xdoc.</param>
        /// <returns>
        /// RssFeed Object
        /// </returns>
        /// <exception cref="System.ArgumentNullException">XDocument can not be null</exception>
        public RssFeed Parse(XDocument xdoc)
        {
            if (xdoc != null)
            {
                ConvertRssFeed convert = new ConvertRssFeed();
                return convert.Convert(xdoc);
            }
            else
            {
                throw new ArgumentNullException("XDocument can not be null");
            }
        }


        /// <summary>
        /// Saves the specified RSS feed as an xml file.
        /// </summary>
        /// <param name="rssFeed">The RSS feed.</param>
        /// <param name="path">The path.</param>
        public void Save(RssFeed rssFeed, string path)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(RssFeed));

            using (TextWriter textWriter = new StreamWriter(path))
            {
                serializer.Serialize(textWriter, rssFeed);
            }
        }


        /// <summary>
        /// Converts an RssFeed object to a string.
        /// </summary>
        /// <param name="rssFeed">The RSS feed.</param>
        /// <returns></returns>
        /// <exception cref="System.ArgumentNullException">RssFeed can not be null</exception>
        public string ConvertToString(RssFeed rssFeed)
        {
            if (rssFeed != null)
            {
                XmlSerializer serializer = new XmlSerializer(typeof(RssFeed));

                using (MemoryStream stream = new MemoryStream())
                {
                    serializer.Serialize(stream, rssFeed);
                    return System.Text.Encoding.Default.GetString(stream.ToArray());
                }
            }
            else
            {
                throw new ArgumentNullException("RssFeed can not be null");
            }
        }
    }
}
