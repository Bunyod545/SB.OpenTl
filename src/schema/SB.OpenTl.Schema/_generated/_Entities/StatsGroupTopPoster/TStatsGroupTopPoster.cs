// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x18f3d0f7)]
	public sealed class TStatsGroupTopPoster : IStatsGroupTopPoster
	{
       [SerializationOrder(0)]
       public int UserId {get; set;}

       [SerializationOrder(1)]
       public int Messages {get; set;}

       [SerializationOrder(2)]
       public int AvgChars {get; set;}

	}
}
