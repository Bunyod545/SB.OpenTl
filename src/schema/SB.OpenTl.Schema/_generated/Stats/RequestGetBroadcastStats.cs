// ReSharper disable All

namespace OpenTl.Schema.Stats
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0xab42441a)]
    public sealed class RequestGetBroadcastStats : IRequest<OpenTl.Schema.Stats.IBroadcastStats>
    {
       [SerializationOrder(0)]
       public BitArray Flags {get; set;}

       [SerializationOrder(1)]
       [FromFlag("Flags", 0)]
       public bool Dark {get; set;}

       [SerializationOrder(2)]
       public OpenTl.Schema.IInputChannel Channel {get; set;}

    }
}
