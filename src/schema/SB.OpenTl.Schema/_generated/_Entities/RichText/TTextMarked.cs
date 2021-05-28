// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x34b8621)]
	public sealed class TTextMarked : IRichText
	{
       [SerializationOrder(0)]
       public OpenTl.Schema.IRichText Text {get; set;}

	}
}
