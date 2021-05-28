// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x54b56617)]
	public sealed class TWebPageAttributeTheme : IWebPageAttribute
	{
       [SerializationOrder(0)]
       public BitArray Flags {get; set;}

       [SerializationOrder(1)]
       [CanSerialize("Flags", 0)]
       public OpenTl.Schema.TVector<OpenTl.Schema.IDocument> Documents {get; set;}

       [SerializationOrder(2)]
       [CanSerialize("Flags", 1)]
       public OpenTl.Schema.IThemeSettings Settings {get; set;}

	}
}
