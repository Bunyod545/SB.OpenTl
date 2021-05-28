// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x6f747657)]
	public sealed class TPageCaption : IPageCaption
	{
       [SerializationOrder(0)]
       public OpenTl.Schema.IRichText Text {get; set;}

       [SerializationOrder(1)]
       public OpenTl.Schema.IRichText Credit {get; set;}

	}
}
