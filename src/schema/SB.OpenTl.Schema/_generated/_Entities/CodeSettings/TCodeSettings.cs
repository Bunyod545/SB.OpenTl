// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0xdebebe83)]
	public sealed class TCodeSettings : ICodeSettings
	{
       [SerializationOrder(0)]
       public BitArray Flags {get; set;}

       [SerializationOrder(1)]
       [FromFlag("Flags", 0)]
       public bool AllowFlashcall {get; set;}

       [SerializationOrder(2)]
       [FromFlag("Flags", 1)]
       public bool CurrentNumber {get; set;}

       [SerializationOrder(3)]
       [FromFlag("Flags", 4)]
       public bool AllowAppHash {get; set;}

	}
}
