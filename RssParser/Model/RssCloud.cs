using System.Xml.Serialization;

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
    [XmlType(TypeName = "cloud")]
    public class RssCloud : RssParserBase, IRssCloud
    {
        private string _domain;
        /// <summary>
        /// Gets or sets the domain. Example: rpc.sys.com
        /// </summary>
        [XmlAttribute(DataType = "string", AttributeName = "domain")]
        public string Domain
        {
            get { return _domain; }
            set
            {
                _domain = value;
                OnPropertyChanged("Domain");
            }
        }


        private string _port;
        /// <summary>
        /// Gets or sets the port. Example: 80
        /// </summary>
        [XmlAttribute(DataType = "string", AttributeName = "port")]
        public string Port
        {
            get { return _port; }
            set
            {
                _port = value;
                OnPropertyChanged("Port");
            }
        }


        private string _path;
        /// <summary>
        /// Gets or sets the path. Example: /RPC2
        /// </summary>
        [XmlAttribute(DataType = "string", AttributeName = "path")]
        public string Path
        {
            get { return _path; }
            set
            {
                _path = value;
                OnPropertyChanged("Path");
            }
        }


        private string _registerProcedure;
        /// <summary>
        /// Gets or sets the register procedure. Example: myCloud.rssPleaseNotify
        /// </summary>
        [XmlAttribute(DataType = "string", AttributeName = "registerProcedure")]
        public string RegisterProcedure
        {
            get { return _registerProcedure; }
            set
            {
                _registerProcedure = value;
                OnPropertyChanged("RegisterProcedure");
            }
        }


        private string _protocol;
        /// <summary>
        /// Gets or sets the protocol. Example: xml-rpc
        /// </summary>
        [XmlAttribute(DataType = "string", AttributeName = "protocol")]
        public string Protocol
        {
            get { return _protocol; }
            set
            {
                _protocol = value;
                OnPropertyChanged("Protocol");
            }
        }
    }
}
