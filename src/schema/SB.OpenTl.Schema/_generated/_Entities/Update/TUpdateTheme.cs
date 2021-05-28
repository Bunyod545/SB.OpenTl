// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x8216fba3)]
	public sealed class TUpdateTheme : IUpdate
	{
       [SerializationOrder(0)]
       public OpenTl.Schema.ITheme Theme {get; set;}

	}
}
