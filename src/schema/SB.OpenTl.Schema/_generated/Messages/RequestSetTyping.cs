// ReSharper disable All

namespace OpenTl.Schema.Messages
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x58943ee2)]
    public sealed class RequestSetTyping : IRequest<bool>
    {
       [SerializationOrder(0)]
       public BitArray Flags {get; set;}

       [SerializationOrder(1)]
       public OpenTl.Schema.IInputPeer Peer {get; set;}

       [SerializationOrder(2)]
       [CanSerialize("Flags", 0)]
       public int TopMsgId {get; set;}

       [SerializationOrder(3)]
       public OpenTl.Schema.ISendMessageAction Action {get; set;}

    }
}
