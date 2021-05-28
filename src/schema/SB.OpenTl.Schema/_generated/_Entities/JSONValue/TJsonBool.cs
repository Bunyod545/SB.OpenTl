// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0xc7345e6a)]
	public sealed class TJsonBool : IJSONValue
	{
       [SerializationOrder(0)]
       public bool Value {get; set;}

	}
}
