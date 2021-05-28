// ReSharper disable All

namespace OpenTl.Schema.Stats
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0xb6e0a3f5)]
    public sealed class RequestGetMessageStats : IRequest<OpenTl.Schema.Stats.IMessageStats>
    {
       [SerializationOrder(0)]
       public BitArray Flags {get; set;}

       [SerializationOrder(1)]
       [FromFlag("Flags", 0)]
       public bool Dark {get; set;}

       [SerializationOrder(2)]
       public OpenTl.Schema.IInputChannel Channel {get; set;}

       [SerializationOrder(3)]
       public int MsgId {get; set;}

    }
}
