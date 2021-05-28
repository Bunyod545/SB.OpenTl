// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0xd20b9f3c)]
	public sealed class TChatPhoto : IChatPhoto
	{
       [SerializationOrder(0)]
       public BitArray Flags {get; set;}

       [SerializationOrder(1)]
       [FromFlag("Flags", 0)]
       public bool HasVideo {get; set;}

       [SerializationOrder(2)]
       public OpenTl.Schema.IFileLocation PhotoSmall {get; set;}

       [SerializationOrder(3)]
       public OpenTl.Schema.IFileLocation PhotoBig {get; set;}

       [SerializationOrder(4)]
       public int DcId {get; set;}

	}
}
