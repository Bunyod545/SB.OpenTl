// ReSharper disable All

namespace OpenTl.Schema.Messages
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x5784d3e1)]
    public sealed class RequestGetMessagesViews : IRequest<OpenTl.Schema.Messages.IMessageViews>
    {
       [SerializationOrder(0)]
       public OpenTl.Schema.IInputPeer Peer {get; set;}

       [SerializationOrder(1)]
       public OpenTl.Schema.TVector<int> Id {get; set;}

       [SerializationOrder(2)]
       public bool Increment {get; set;}

    }
}
