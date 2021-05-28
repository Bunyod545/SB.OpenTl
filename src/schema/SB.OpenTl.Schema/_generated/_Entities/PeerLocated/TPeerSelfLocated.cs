// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0xf8ec284b)]
	public sealed class TPeerSelfLocated : IPeerLocated
	{
       [SerializationOrder(0)]
       public int Expires {get; set;}

	}
}
