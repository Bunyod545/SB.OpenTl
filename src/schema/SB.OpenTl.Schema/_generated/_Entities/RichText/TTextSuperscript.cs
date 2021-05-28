// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0xc7fb5e01)]
	public sealed class TTextSuperscript : IRichText
	{
       [SerializationOrder(0)]
       public OpenTl.Schema.IRichText Text {get; set;}

	}
}
