// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0xf041e250)]
	public sealed class TChatOnlines : IChatOnlines
	{
       [SerializationOrder(0)]
       public int Onlines {get; set;}

	}
}
