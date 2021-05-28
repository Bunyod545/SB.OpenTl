// ReSharper disable All

namespace OpenTl.Schema.Help
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x98f6ac75)]
	public sealed class TPromoDataEmpty : IPromoData, IEmpty
	{
       [SerializationOrder(0)]
       public int Expires {get; set;}

	}
}
