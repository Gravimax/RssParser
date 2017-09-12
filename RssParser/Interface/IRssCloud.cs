
namespace RssParser
{
    /// <summary>
    /// Cloud is an optional sub-element of 'channel'. 
    /// It specifies a web service that supports the rssCloud interface 
    /// which can be implemented in HTTP-POST, XML-RPC or SOAP 1.1. 
    /// Its purpose is to allow processes to register with a cloud to be 
    /// notified of updates to the channel, implementing a lightweight 
    /// publish-subscribe protocol for RSS feeds.
    /// </summary>
    public interface IRssCloud
    {
        /// <summary>
        /// Gets or sets the domain. Example: rpc.sys.com
        /// </summary>
        string Domain { get; set; }

        /// <summary>
        /// Gets or sets the port. Example: 80
        /// </summary>
        string Port { get; set; }

        /// <summary>
        /// Gets or sets the path. Example: /RPC2
        /// </summary>
        string Path { get; set; }

        /// <summary>
        /// Gets or sets the register procedure. Example: myCloud.rssPleaseNotify
        /// </summary>
        string RegisterProcedure { get; set; }

        /// <summary>
        /// Gets or sets the protocol. Example: xml-rpc
        /// </summary>
        string Protocol { get; set; }
    }
}
