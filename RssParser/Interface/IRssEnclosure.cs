
namespace RssParser
{
    /// <summary>
    /// Enclosure is an optional sub-element of 'item'.
    /// </summary>
    public interface IRssEnclosure
    {
        /// <summary>
        /// The url of the media.
        /// </summary>
        string Url { get; set; }

        /// <summary>
        /// The length of the media in bytes.
        /// </summary>
        long Length { get; set; }

        /// <summary>
        /// The type of media as a standard MIME type.
        /// </summary>
        string Type { get; set; }
    }
}
