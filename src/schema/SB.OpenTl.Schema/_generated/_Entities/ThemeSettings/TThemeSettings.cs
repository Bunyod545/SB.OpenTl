// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x9c14984a)]
	public sealed class TThemeSettings : IThemeSettings
	{
       [SerializationOrder(0)]
       public BitArray Flags {get; set;}

       [SerializationOrder(1)]
       public OpenTl.Schema.IBaseTheme BaseTheme {get; set;}

       [SerializationOrder(2)]
       public int AccentColor {get; set;}

       [SerializationOrder(3)]
       [CanSerialize("Flags", 0)]
       public int MessageTopColor {get; set;}

       [SerializationOrder(4)]
       [CanSerialize("Flags", 0)]
       public int MessageBottomColor {get; set;}

       [SerializationOrder(5)]
       [CanSerialize("Flags", 1)]
       public OpenTl.Schema.IWallPaper Wallpaper {get; set;}

	}
}
