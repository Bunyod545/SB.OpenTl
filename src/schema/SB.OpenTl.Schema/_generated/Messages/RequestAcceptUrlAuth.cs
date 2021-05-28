// ReSharper disable All

namespace OpenTl.Schema.Messages
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0xf729ea98)]
    public sealed class RequestAcceptUrlAuth : IRequest<OpenTl.Schema.IUrlAuthResult>
    {
       [SerializationOrder(0)]
       public BitArray Flags {get; set;}

       [SerializationOrder(1)]
       [FromFlag("Flags", 0)]
       public bool WriteAllowed {get; set;}

       [SerializationOrder(2)]
       public OpenTl.Schema.IInputPeer Peer {get; set;}

       [SerializationOrder(3)]
       public int MsgId {get; set;}

       [SerializationOrder(4)]
       public int ButtonId {get; set;}

    }
}
