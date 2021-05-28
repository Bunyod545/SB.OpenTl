// ReSharper disable All

namespace OpenTl.Schema.Stats
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x5630281b)]
    public sealed class RequestGetMessagePublicForwards : IRequest<OpenTl.Schema.Messages.IMessages>
    {
       [SerializationOrder(0)]
       public OpenTl.Schema.IInputChannel Channel {get; set;}

       [SerializationOrder(1)]
       public int MsgId {get; set;}

       [SerializationOrder(2)]
       public int OffsetRate {get; set;}

       [SerializationOrder(3)]
       public OpenTl.Schema.IInputPeer OffsetPeer {get; set;}

       [SerializationOrder(4)]
       public int OffsetId {get; set;}

       [SerializationOrder(5)]
       public int Limit {get; set;}

    }
}
