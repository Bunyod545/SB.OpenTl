// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x971fa843)]
	public sealed class TInputMediaGeoLive : IInputMedia
	{
       [SerializationOrder(0)]
       public BitArray Flags {get; set;}

       [SerializationOrder(1)]
       [FromFlag("Flags", 0)]
       public bool Stopped {get; set;}

       [SerializationOrder(2)]
       public OpenTl.Schema.IInputGeoPoint GeoPoint {get; set;}

       [SerializationOrder(3)]
       [CanSerialize("Flags", 2)]
       public int Heading {get; set;}

       [SerializationOrder(4)]
       [CanSerialize("Flags", 1)]
       public int Period {get; set;}

       [SerializationOrder(5)]
       [CanSerialize("Flags", 3)]
       public int ProximityNotificationRadius {get; set;}

	}
}
