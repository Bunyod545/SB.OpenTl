// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0xb2a2f663)]
	public sealed class TGeoPoint : IGeoPoint
	{
       [SerializationOrder(0)]
       public BitArray Flags {get; set;}

       [SerializationOrder(1)]
       public double Long {get; set;}

       [SerializationOrder(2)]
       public double Lat {get; set;}

       [SerializationOrder(3)]
       public long AccessHash {get; set;}

       [SerializationOrder(4)]
       [CanSerialize("Flags", 0)]
       public int AccuracyRadius {get; set;}

	}
}
