// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x286fa604)]
	public sealed class TMessageService : IMessage
	{
       [SerializationOrder(0)]
       public BitArray Flags {get; set;}

       [SerializationOrder(1)]
       [FromFlag("Flags", 1)]
       public bool Out {get; set;}

       [SerializationOrder(2)]
       [FromFlag("Flags", 4)]
       public bool Mentioned {get; set;}

       [SerializationOrder(3)]
       [FromFlag("Flags", 5)]
       public bool MediaUnread {get; set;}

       [SerializationOrder(4)]
       [FromFlag("Flags", 13)]
       public bool Silent {get; set;}

       [SerializationOrder(5)]
       [FromFlag("Flags", 14)]
       public bool Post {get; set;}

       [SerializationOrder(6)]
       [FromFlag("Flags", 19)]
       public bool Legacy {get; set;}

       [SerializationOrder(7)]
       public int Id {get; set;}

       [SerializationOrder(8)]
       [CanSerialize("Flags", 8)]
       public OpenTl.Schema.IPeer FromId {get; set;}

       [SerializationOrder(9)]
       public OpenTl.Schema.IPeer PeerId {get; set;}

       [SerializationOrder(10)]
       [CanSerialize("Flags", 3)]
       public OpenTl.Schema.IMessageReplyHeader ReplyTo {get; set;}

       [SerializationOrder(11)]
       public int Date {get; set;}

       [SerializationOrder(12)]
       public OpenTl.Schema.IMessageAction Action {get; set;}

	}
}
