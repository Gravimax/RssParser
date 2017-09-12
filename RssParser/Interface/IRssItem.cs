using System.Collections.Generic;

namespace RssParser
{
    /// <summary>
    /// All elements of an item are optional, 
    /// however at least one of title or description must be present. 
    /// </summary>
    public interface IRssItem
    {
        /// <summary>
        /// The title of the item.
        /// </summary>
        string Title { get; set; }

        /// <summary>
        /// The URL of the item.
        /// </summary>
        string Link { get; set; }

        /// <summary>
        /// The item synopsis.
        /// </summary>
        string Description { get; set; }

        /// <summary>
        /// Email address of the author of the item.
        /// </summary>
        string Author { get; set; }

        /// <summary>
        /// Includes the item in one or more categories.
        /// </summary>
        List<RssCategory> Categories { get; set; }

        /// <summary>
        /// URL of a page for comments relating to the item.
        /// </summary>
        string Comments { get; set; }

        /// <summary>
        /// Describes a media object that is attached to the item.
        /// </summary>
        RssEnclosure Enclosure { get; set; }

        /// <summary>
        /// A string that uniquely identifies the item.
        /// </summary>
        RssGuid Guid { get; set; }

        /// <summary>
        /// The publication date for the item.
        /// </summary>
        string PubDate { get; set; }

        /// <summary>
        /// The RSS channel that the item came from.
        /// </summary>
        RssSource Source { get; set; }
    }
}
