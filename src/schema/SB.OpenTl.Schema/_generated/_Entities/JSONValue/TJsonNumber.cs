// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x2be0dfa4)]
	public sealed class TJsonNumber : IJSONValue
	{
       [SerializationOrder(0)]
       public double Value {get; set;}

	}
}
