// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x98e0d697)]
	public sealed class TMessageActionGeoProximityReached : IMessageAction
	{
       [SerializationOrder(0)]
       public OpenTl.Schema.IPeer FromId {get; set;}

       [SerializationOrder(1)]
       public OpenTl.Schema.IPeer ToId {get; set;}

       [SerializationOrder(2)]
       public int Distance {get; set;}

	}
}
