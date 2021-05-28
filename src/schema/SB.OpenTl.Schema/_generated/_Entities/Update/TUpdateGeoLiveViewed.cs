// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x871fb939)]
	public sealed class TUpdateGeoLiveViewed : IUpdate
	{
       [SerializationOrder(0)]
       public OpenTl.Schema.IPeer Peer {get; set;}

       [SerializationOrder(1)]
       public int MsgId {get; set;}

	}
}
