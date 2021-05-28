// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x6a7e7366)]
	public sealed class TUpdatePeerSettings : IUpdate
	{
       [SerializationOrder(0)]
       public OpenTl.Schema.IPeer Peer {get; set;}

       [SerializationOrder(1)]
       public OpenTl.Schema.IPeerSettings Settings {get; set;}

	}
}
