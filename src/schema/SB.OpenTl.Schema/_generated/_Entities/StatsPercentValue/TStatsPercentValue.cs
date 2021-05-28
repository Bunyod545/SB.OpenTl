// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0xcbce2fe0)]
	public sealed class TStatsPercentValue : IStatsPercentValue
	{
       [SerializationOrder(0)]
       public double Part {get; set;}

       [SerializationOrder(1)]
       public double Total {get; set;}

	}
}
