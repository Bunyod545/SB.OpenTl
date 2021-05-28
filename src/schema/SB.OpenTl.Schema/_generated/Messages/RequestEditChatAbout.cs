// ReSharper disable All

namespace OpenTl.Schema.Messages
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0xdef60797)]
    public sealed class RequestEditChatAbout : IRequest<bool>
    {
       [SerializationOrder(0)]
       public OpenTl.Schema.IInputPeer Peer {get; set;}

       /// <summary>Binary representation for the 'About' property</summary>
       [SerializationOrder(1)]
       public byte[] AboutAsBinary { get => _AboutAsBinary; set { _About = Encoding.UTF8.GetString(value); _AboutAsBinary = value; }}
       private byte[] _AboutAsBinary;
       private string _About;
       public string About { get => _About; set { AboutAsBinary = Encoding.UTF8.GetBytes(value); _About = value; }}

    }
}
