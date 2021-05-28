// ReSharper disable All

namespace OpenTl.Schema.Messages
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0xe2c2685b)]
    public sealed class RequestGetScheduledHistory : IRequest<OpenTl.Schema.Messages.IMessages>
    {
       [SerializationOrder(0)]
       public OpenTl.Schema.IInputPeer Peer {get; set;}

       [SerializationOrder(1)]
       public int Hash {get; set;}

    }
}
