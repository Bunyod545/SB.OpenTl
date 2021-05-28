// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x997c454a)]
	public sealed class TPhoneCallAccepted : IPhoneCall
	{
       [SerializationOrder(0)]
       public BitArray Flags {get; set;}

       [SerializationOrder(1)]
       [FromFlag("Flags", 6)]
       public bool Video {get; set;}

       [SerializationOrder(2)]
       public long Id {get; set;}

       [SerializationOrder(3)]
       public long AccessHash {get; set;}

       [SerializationOrder(4)]
       public int Date {get; set;}

       [SerializationOrder(5)]
       public int AdminId {get; set;}

       [SerializationOrder(6)]
       public int ParticipantId {get; set;}

       [SerializationOrder(7)]
       public byte[] GB {get; set;}

       [SerializationOrder(8)]
       public OpenTl.Schema.IPhoneCallProtocol Protocol {get; set;}

	}
}
