// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x3b6ddad2)]
	public sealed class TPollAnswerVoters : IPollAnswerVoters
	{
       [SerializationOrder(0)]
       public BitArray Flags {get; set;}

       [SerializationOrder(1)]
       [FromFlag("Flags", 0)]
       public bool Chosen {get; set;}

       [SerializationOrder(2)]
       [FromFlag("Flags", 1)]
       public bool Correct {get; set;}

       [SerializationOrder(3)]
       public byte[] Option {get; set;}

       [SerializationOrder(4)]
       public int Voters {get; set;}

	}
}
