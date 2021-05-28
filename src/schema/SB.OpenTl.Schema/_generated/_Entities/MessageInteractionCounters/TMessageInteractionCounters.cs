// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0xad4fc9bd)]
	public sealed class TMessageInteractionCounters : IMessageInteractionCounters
	{
       [SerializationOrder(0)]
       public int MsgId {get; set;}

       [SerializationOrder(1)]
       public int Views {get; set;}

       [SerializationOrder(2)]
       public int Forwards {get; set;}

	}
}
