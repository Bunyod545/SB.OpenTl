// ReSharper disable All

namespace OpenTl.Schema.Messages
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0xd2aaf7ec)]
    public sealed class RequestUpdatePinnedMessage : IRequest<OpenTl.Schema.IUpdates>
    {
       [SerializationOrder(0)]
       public BitArray Flags {get; set;}

       [SerializationOrder(1)]
       [FromFlag("Flags", 0)]
       public bool Silent {get; set;}

       [SerializationOrder(2)]
       [FromFlag("Flags", 1)]
       public bool Unpin {get; set;}

       [SerializationOrder(3)]
       [FromFlag("Flags", 2)]
       public bool PmOneside {get; set;}

       [SerializationOrder(4)]
       public OpenTl.Schema.IInputPeer Peer {get; set;}

       [SerializationOrder(5)]
       public int Id {get; set;}

    }
}
