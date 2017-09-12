
namespace RssParser
{
    /// <summary>
    /// RSS 2.0 Specification: http://cyber.law.harvard.edu/rss/rss.html
    /// http://www.w3schools.com/rss/default.asp
    /// </summary>
    public interface IRssFeed
    {
        /// <summary>
        /// The RSS version number.
        /// </summary>
        double Version { get; set; }

        /// <summary>
        /// The required channel element
        /// </summary>
        RssChannel Channel { get; set; }
    }
}
