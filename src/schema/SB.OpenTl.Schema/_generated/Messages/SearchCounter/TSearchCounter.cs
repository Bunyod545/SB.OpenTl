// ReSharper disable All

namespace OpenTl.Schema.Messages
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0xe844ebff)]
	public sealed class TSearchCounter : ISearchCounter
	{
       [SerializationOrder(0)]
       public BitArray Flags {get; set;}

       [SerializationOrder(1)]
       [FromFlag("Flags", 1)]
       public bool Inexact {get; set;}

       [SerializationOrder(2)]
       public OpenTl.Schema.IMessagesFilter Filter {get; set;}

       [SerializationOrder(3)]
       public int Count {get; set;}

	}
}
