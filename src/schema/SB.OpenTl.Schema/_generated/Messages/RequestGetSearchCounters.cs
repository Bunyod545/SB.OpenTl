// ReSharper disable All

namespace OpenTl.Schema.Messages
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x732eef00)]
    public sealed class RequestGetSearchCounters : IRequest<OpenTl.Schema.TVector<OpenTl.Schema.Messages.ISearchCounter>>
    {
       [SerializationOrder(0)]
       public OpenTl.Schema.IInputPeer Peer {get; set;}

       [SerializationOrder(1)]
       public OpenTl.Schema.TVector<OpenTl.Schema.IMessagesFilter> Filters {get; set;}

    }
}
