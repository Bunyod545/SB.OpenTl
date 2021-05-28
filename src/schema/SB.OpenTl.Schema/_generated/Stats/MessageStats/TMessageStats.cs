// ReSharper disable All

namespace OpenTl.Schema.Stats
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x8999f295)]
	public sealed class TMessageStats : IMessageStats
	{
       [SerializationOrder(0)]
       public OpenTl.Schema.IStatsGraph ViewsGraph {get; set;}

	}
}
