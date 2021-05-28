// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x48222faf)]
	public sealed class TInputGeoPoint : IInputGeoPoint
	{
       [SerializationOrder(0)]
       public BitArray Flags {get; set;}

       [SerializationOrder(1)]
       public double Lat {get; set;}

       [SerializationOrder(2)]
       public double Long {get; set;}

       [SerializationOrder(3)]
       [CanSerialize("Flags", 0)]
       public int AccuracyRadius {get; set;}

	}
}
