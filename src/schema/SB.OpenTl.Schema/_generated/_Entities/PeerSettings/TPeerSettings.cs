// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x733f2961)]
	public sealed class TPeerSettings : IPeerSettings
	{
       [SerializationOrder(0)]
       public BitArray Flags {get; set;}

       [SerializationOrder(1)]
       [FromFlag("Flags", 0)]
       public bool ReportSpam {get; set;}

       [SerializationOrder(2)]
       [FromFlag("Flags", 1)]
       public bool AddContact {get; set;}

       [SerializationOrder(3)]
       [FromFlag("Flags", 2)]
       public bool BlockContact {get; set;}

       [SerializationOrder(4)]
       [FromFlag("Flags", 3)]
       public bool ShareContact {get; set;}

       [SerializationOrder(5)]
       [FromFlag("Flags", 4)]
       public bool NeedContactsException {get; set;}

       [SerializationOrder(6)]
       [FromFlag("Flags", 5)]
       public bool ReportGeo {get; set;}

       [SerializationOrder(7)]
       [FromFlag("Flags", 7)]
       public bool Autoarchived {get; set;}

       [SerializationOrder(8)]
       [FromFlag("Flags", 8)]
       public bool InviteMembers {get; set;}

       [SerializationOrder(9)]
       [CanSerialize("Flags", 6)]
       public int GeoDistance {get; set;}

	}
}
