// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x39a51dfb)]
	public sealed class TUpdateNewScheduledMessage : IUpdate
	{
       [SerializationOrder(0)]
       public OpenTl.Schema.IMessage Message {get; set;}

	}
}
