
namespace RssParser
{
    /// <summary>
    /// Guid is an optional sub-element of 'item'.
    /// A string that uniquely identifies the item.
    /// </summary>
    public interface IRssGuid
    {
        /// <summary>
        /// The guid.
        /// </summary>
        string Guid { get; set; }

        /// <summary>
        /// isPermaLink is optional, its default value is true. If its value is false, 
        /// the guid may not be assumed to be a url, or a url to anything in particular.
        /// </summary>
        bool IsPermaLink { get; set; }
    }
}
