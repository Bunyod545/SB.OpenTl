// ReSharper disable All

namespace OpenTl.Schema.Contacts
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0xd348bc44)]
    public sealed class RequestGetLocated : IRequest<OpenTl.Schema.IUpdates>
    {
       [SerializationOrder(0)]
       public BitArray Flags {get; set;}

       [SerializationOrder(1)]
       [FromFlag("Flags", 1)]
       public bool Background {get; set;}

       [SerializationOrder(2)]
       public OpenTl.Schema.IInputGeoPoint GeoPoint {get; set;}

       [SerializationOrder(3)]
       [CanSerialize("Flags", 0)]
       public int SelfExpires {get; set;}

    }
}
