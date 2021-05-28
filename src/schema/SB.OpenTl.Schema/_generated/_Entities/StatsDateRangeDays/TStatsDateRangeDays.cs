// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0xb637edaf)]
	public sealed class TStatsDateRangeDays : IStatsDateRangeDays
	{
       [SerializationOrder(0)]
       public int MinDate {get; set;}

       [SerializationOrder(1)]
       public int MaxDate {get; set;}

	}
}
