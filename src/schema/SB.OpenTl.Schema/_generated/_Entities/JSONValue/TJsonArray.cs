// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0xf7444763)]
	public sealed class TJsonArray : IJSONValue
	{
       [SerializationOrder(0)]
       public OpenTl.Schema.TVector<OpenTl.Schema.IJSONValue> Value {get; set;}

	}
}
