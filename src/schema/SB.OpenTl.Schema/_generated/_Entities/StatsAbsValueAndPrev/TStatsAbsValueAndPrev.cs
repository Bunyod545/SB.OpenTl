// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0xcb43acde)]
	public sealed class TStatsAbsValueAndPrev : IStatsAbsValueAndPrev
	{
       [SerializationOrder(0)]
       public double Current {get; set;}

       [SerializationOrder(1)]
       public double Previous {get; set;}

	}
}
