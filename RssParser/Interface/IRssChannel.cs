using System.Collections.Generic;

namespace RssParser
{
    /// <summary>
    /// Channel is a required element that contains all the feed data.
    /// </summary>
    public interface IRssChannel
    {
        #region Required Rss channel fields

        /// <summary>
        /// The name of the channel.
        /// </summary>
        string Title { get; set; }

        /// <summary>
        /// The URL to the HTML website corresponding to the channel.
        /// </summary>
        string Link { get; set; }

        /// <summary>
        /// Phrase or sentence describing the channel.
        /// </summary>
        string Description { get; set; }

        #endregion

        #region Optional Rss channel fields

        /// <summary>
        /// The language the channel is written in.
        /// </summary>
        string Language { get; set; }

        /// <summary>
        /// Copyright notice for content in the channel.
        /// </summary>
        string Copyright { get; set; }

        /// <summary>
        /// Email address for person responsible for editorial content.
        /// </summary>
        string ManagingEditor { get; set; }

        /// <summary>
        /// Email address for person responsible for technical issues relating to channel.
        /// </summary>
        string WebMaster { get; set; }

        /// <summary>
        /// The publication date for the content in the channel.
        /// </summary>
        string PubDate { get; set; }

        /// <summary>
        /// The last time the content of the channel changed.
        /// </summary>
        string LastBuildDate { get; set; }

        /// <summary>
        /// Specify one or more categories that the channel belongs to.
        /// </summary>
        List<RssCategory> Categories { get; set; }

        /// <summary>
        /// A string indicating the program used to generate the channel.
        /// </summary>
        string Generator { get; set; }

        /// <summary>
        /// A URL that points to the documentation for the format used in the RSS file.
        /// </summary>
        string Docs { get; set; }

        /// <summary>
        /// Allows processes to register with a cloud to be notified of updates to the channel, 
        /// implementing a lightweight publish-subscribe protocol for RSS feeds.
        /// </summary>
        RssCloud Cloud { get; set; }

        /// <summary>
        /// The number of minutes that indicates how long a channel can be cached before refreshing.
        /// </summary>
        int Ttl { get; set; }

        /// <summary>
        /// The PICS rating for the channel.
        /// </summary>
        string Rating { get; set; }

        /// <summary>
        /// A hint for aggregators telling them which hours they can skip.
        /// </summary>
        string SkipHours { get; set; }

        /// <summary>
        /// A hint for aggregators telling them which days they can skip.
        /// </summary>
        string SkipDays { get; set; }

        /// <summary>
        /// Specifies a GIF, JPEG or PNG image that can be displayed with the channel.
        /// </summary>
        RssImage Image { get; set; }

        /// <summary>
        /// The list of news items.
        /// </summary>
        List<RssItem> Items { get; set; }

        #endregion
    }
}
