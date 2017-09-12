
namespace RssParser
{
    /// <summary>
    /// Source is an optional sub-element of 'item'.
    /// It has one required attribute, url, which links to the XMLization of the source.
    /// </summary>
    public interface IRssSource
    {
        /// <summary>
        /// The name of the RSS channel that the item came from, derived from its 'title'
        /// </summary>
        string Source { get; set; }

        /// <summary>
        /// The URL of the item.
        /// </summary>
        string Url { get; set; }
    }
}
