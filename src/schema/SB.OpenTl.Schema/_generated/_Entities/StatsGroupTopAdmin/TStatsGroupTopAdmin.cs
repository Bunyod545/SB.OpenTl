// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x6014f412)]
	public sealed class TStatsGroupTopAdmin : IStatsGroupTopAdmin
	{
       [SerializationOrder(0)]
       public int UserId {get; set;}

       [SerializationOrder(1)]
       public int Deleted {get; set;}

       [SerializationOrder(2)]
       public int Kicked {get; set;}

       [SerializationOrder(3)]
       public int Banned {get; set;}

	}
}
