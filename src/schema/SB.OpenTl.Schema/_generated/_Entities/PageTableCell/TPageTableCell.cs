// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x34566b6a)]
	public sealed class TPageTableCell : IPageTableCell
	{
       [SerializationOrder(0)]
       public BitArray Flags {get; set;}

       [SerializationOrder(1)]
       [FromFlag("Flags", 0)]
       public bool Header {get; set;}

       [SerializationOrder(2)]
       [FromFlag("Flags", 3)]
       public bool AlignCenter {get; set;}

       [SerializationOrder(3)]
       [FromFlag("Flags", 4)]
       public bool AlignRight {get; set;}

       [SerializationOrder(4)]
       [FromFlag("Flags", 5)]
       public bool ValignMiddle {get; set;}

       [SerializationOrder(5)]
       [FromFlag("Flags", 6)]
       public bool ValignBottom {get; set;}

       [SerializationOrder(6)]
       [CanSerialize("Flags", 7)]
       public OpenTl.Schema.IRichText Text {get; set;}

       [SerializationOrder(7)]
       [CanSerialize("Flags", 1)]
       public int Colspan {get; set;}

       [SerializationOrder(8)]
       [CanSerialize("Flags", 2)]
       public int Rowspan {get; set;}

	}
}
