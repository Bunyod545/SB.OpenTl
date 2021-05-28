// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x8742ae7f)]
	public sealed class TPhoneCall : IPhoneCall
	{
       [SerializationOrder(0)]
       public BitArray Flags {get; set;}

       [SerializationOrder(1)]
       [FromFlag("Flags", 5)]
       public bool P2pAllowed {get; set;}

       [SerializationOrder(2)]
       [FromFlag("Flags", 6)]
       public bool Video {get; set;}

       [SerializationOrder(3)]
       public long Id {get; set;}

       [SerializationOrder(4)]
       public long AccessHash {get; set;}

       [SerializationOrder(5)]
       public int Date {get; set;}

       [SerializationOrder(6)]
       public int AdminId {get; set;}

       [SerializationOrder(7)]
       public int ParticipantId {get; set;}

       [SerializationOrder(8)]
       public byte[] GAOrB {get; set;}

       [SerializationOrder(9)]
       public long KeyFingerprint {get; set;}

       [SerializationOrder(10)]
       public OpenTl.Schema.IPhoneCallProtocol Protocol {get; set;}

       [SerializationOrder(11)]
       public OpenTl.Schema.TVector<OpenTl.Schema.IPhoneConnection> Connections {get; set;}

       [SerializationOrder(12)]
       public int StartDate {get; set;}

	}
}
