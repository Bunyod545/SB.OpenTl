// ReSharper disable All

namespace OpenTl.Schema.Messages
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0xe33f5613)]
    public sealed class RequestRequestUrlAuth : IRequest<OpenTl.Schema.IUrlAuthResult>
    {
       [SerializationOrder(0)]
       public OpenTl.Schema.IInputPeer Peer {get; set;}

       [SerializationOrder(1)]
       public int MsgId {get; set;}

       [SerializationOrder(2)]
       public int ButtonId {get; set;}

    }
}
