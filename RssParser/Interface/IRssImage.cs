
namespace RssParser
{
    /// <summary>
    /// Image is an optional sub-element of 'channel', 
    /// which contains three required and three optional sub-elements.
    /// </summary>
    public interface IRssImage
    {
        #region Required image sub-elements

        /// <summary>
        /// The URL of a GIF, JPEG or PNG image that represents the channel. 
        /// </summary>
        string Url { get; set; }

        /// <summary>
        /// Describes the image, it's used in the ALT attribute of the HTML &amp; &lt;img&gt; tag when the channel is rendered in HTML. 
        /// </summary>
        string Title { get; set; }

        /// <summary>
        /// Is the URL of the site, when the channel is rendered, the image is a link to the site. 
        /// Note, in practice the image &lt;title&gt; and &lt;link&gt; should have the same value as the channel's &lt;title&gt; and &lt;link&gt;.
        /// </summary>
        string Link { get; set; }

        #endregion

        #region Optional image sub-elements

        /// <summary>
        /// Contains text that is included in the TITLE attribute of the link formed around the image in the HTML rendering.
        /// </summary>
        string Description { get; set; }

        /// <summary>
        /// Maximum value for width is 144, default value is 88. 
        /// </summary>
        int Width { get; set; }

        /// <summary>
        /// Maximum value for height is 400, default value is 31.
        /// </summary>
        int Height { get; set; }

        #endregion
    }
}
