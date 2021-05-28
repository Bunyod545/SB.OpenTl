// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x455b853d)]
	public sealed class TMessageViews : IMessageViews
	{
       [SerializationOrder(0)]
       public BitArray Flags {get; set;}

       [SerializationOrder(1)]
       [CanSerialize("Flags", 0)]
       public int Views {get; set;}

       [SerializationOrder(2)]
       [CanSerialize("Flags", 1)]
       public int Forwards {get; set;}

       [SerializationOrder(3)]
       [CanSerialize("Flags", 2)]
       public OpenTl.Schema.IMessageReplies Replies {get; set;}

	}
}
