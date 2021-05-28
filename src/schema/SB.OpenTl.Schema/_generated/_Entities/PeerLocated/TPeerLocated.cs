// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0xca461b5d)]
	public sealed class TPeerLocated : IPeerLocated
	{
       [SerializationOrder(0)]
       public OpenTl.Schema.IPeer Peer {get; set;}

       [SerializationOrder(1)]
       public int Expires {get; set;}

       [SerializationOrder(2)]
       public int Distance {get; set;}

	}
}
