// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x80e11a7f)]
	public sealed class TMessageActionPhoneCall : IMessageAction
	{
       [SerializationOrder(0)]
       public BitArray Flags {get; set;}

       [SerializationOrder(1)]
       [FromFlag("Flags", 2)]
       public bool Video {get; set;}

       [SerializationOrder(2)]
       public long CallId {get; set;}

       [SerializationOrder(3)]
       [CanSerialize("Flags", 0)]
       public OpenTl.Schema.IPhoneCallDiscardReason Reason {get; set;}

       [SerializationOrder(4)]
       [CanSerialize("Flags", 1)]
       public int Duration {get; set;}

	}
}
