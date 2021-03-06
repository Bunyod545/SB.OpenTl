// ReSharper disable All

namespace OpenTl.Schema.Help
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x6a4ee832)]
	public sealed class TDeepLinkInfo : IDeepLinkInfo
	{
       [SerializationOrder(0)]
       public BitArray Flags {get; set;}

       [SerializationOrder(1)]
       [FromFlag("Flags", 0)]
       public bool UpdateApp {get; set;}

       /// <summary>Binary representation for the 'Message' property</summary>
       [SerializationOrder(2)]
       public byte[] MessageAsBinary { get => _MessageAsBinary; set { _Message = Encoding.UTF8.GetString(value); _MessageAsBinary = value; }}
       private byte[] _MessageAsBinary;
       private string _Message;
       public string Message { get => _Message; set { MessageAsBinary = Encoding.UTF8.GetBytes(value); _Message = value; }}

       [SerializationOrder(3)]
       [CanSerialize("Flags", 1)]
       public OpenTl.Schema.TVector<OpenTl.Schema.IMessageEntity> Entities {get; set;}

	}
}
