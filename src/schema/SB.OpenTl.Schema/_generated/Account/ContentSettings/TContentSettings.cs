// ReSharper disable All

namespace OpenTl.Schema.Account
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x57e28221)]
	public sealed class TContentSettings : IContentSettings
	{
       [SerializationOrder(0)]
       public BitArray Flags {get; set;}

       [SerializationOrder(1)]
       [FromFlag("Flags", 0)]
       public bool SensitiveEnabled {get; set;}

       [SerializationOrder(2)]
       [FromFlag("Flags", 1)]
       public bool SensitiveCanChange {get; set;}

	}
}
