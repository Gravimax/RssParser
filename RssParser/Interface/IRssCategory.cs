
namespace RssParser
{
    /// <summary>
    /// Category is an optional sub-element of 'item' and 'channel'
    /// </summary>
    public interface IRssCategory
    {
        /// <summary>
        /// The category name.
        /// </summary>
        string Category { get; set; }

        /// <summary>
        /// Identifies the categorization taxonomy. Optional.
        /// </summary>
        string Domain { get; set; }
    }
}
