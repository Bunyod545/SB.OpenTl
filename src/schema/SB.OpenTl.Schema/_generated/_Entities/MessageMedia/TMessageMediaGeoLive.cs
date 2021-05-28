// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0xb940c666)]
	public sealed class TMessageMediaGeoLive : IMessageMedia
	{
       [SerializationOrder(0)]
       public BitArray Flags {get; set;}

       [SerializationOrder(1)]
       public OpenTl.Schema.IGeoPoint Geo {get; set;}

       [SerializationOrder(2)]
       [CanSerialize("Flags", 0)]
       public int Heading {get; set;}

       [SerializationOrder(3)]
       public int Period {get; set;}

       [SerializationOrder(4)]
       [CanSerialize("Flags", 1)]
       public int ProximityNotificationRadius {get; set;}

	}
}
