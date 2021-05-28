// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x5086cf8)]
	public sealed class TWallPaperSettings : IWallPaperSettings
	{
       [SerializationOrder(0)]
       public BitArray Flags {get; set;}

       [SerializationOrder(1)]
       [FromFlag("Flags", 1)]
       public bool Blur {get; set;}

       [SerializationOrder(2)]
       [FromFlag("Flags", 2)]
       public bool Motion {get; set;}

       [SerializationOrder(3)]
       [CanSerialize("Flags", 0)]
       public int BackgroundColor {get; set;}

       [SerializationOrder(4)]
       [CanSerialize("Flags", 4)]
       public int SecondBackgroundColor {get; set;}

       [SerializationOrder(5)]
       [CanSerialize("Flags", 3)]
       public int Intensity {get; set;}

       [SerializationOrder(6)]
       [CanSerialize("Flags", 4)]
       public int Rotation {get; set;}

	}
}
