// ReSharper disable All

namespace OpenTl.Schema.Messages
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0xf731a9f4)]
    public sealed class RequestReadDiscussion : IRequest<bool>
    {
       [SerializationOrder(0)]
       public OpenTl.Schema.IInputPeer Peer {get; set;}

       [SerializationOrder(1)]
       public int MsgId {get; set;}

       [SerializationOrder(2)]
       public int ReadMaxId {get; set;}

    }
}
