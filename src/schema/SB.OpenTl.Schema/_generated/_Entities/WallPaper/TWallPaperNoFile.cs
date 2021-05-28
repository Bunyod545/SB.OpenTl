// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x8af40b25)]
	public sealed class TWallPaperNoFile : IWallPaper
	{
       [SerializationOrder(0)]
       public BitArray Flags {get; set;}

       [SerializationOrder(1)]
       [FromFlag("Flags", 1)]
       public bool Default {get; set;}

       [SerializationOrder(2)]
       [FromFlag("Flags", 4)]
       public bool Dark {get; set;}

       [SerializationOrder(3)]
       [CanSerialize("Flags", 2)]
       public OpenTl.Schema.IWallPaperSettings Settings {get; set;}

	}
}
