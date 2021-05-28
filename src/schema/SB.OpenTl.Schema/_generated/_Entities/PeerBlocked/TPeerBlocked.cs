// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0xe8fd8014)]
	public sealed class TPeerBlocked : IPeerBlocked
	{
       [SerializationOrder(0)]
       public OpenTl.Schema.IPeer PeerId {get; set;}

       [SerializationOrder(1)]
       public int Date {get; set;}

	}
}
