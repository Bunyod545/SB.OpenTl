// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x246a4b22)]
	public sealed class TUpdatePeerBlocked : IUpdate
	{
       [SerializationOrder(0)]
       public OpenTl.Schema.IPeer PeerId {get; set;}

       [SerializationOrder(1)]
       public bool Blocked {get; set;}

	}
}
