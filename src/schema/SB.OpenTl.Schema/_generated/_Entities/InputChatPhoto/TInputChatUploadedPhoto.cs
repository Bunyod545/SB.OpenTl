// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0xc642724e)]
	public sealed class TInputChatUploadedPhoto : IInputChatPhoto
	{
       [SerializationOrder(0)]
       public BitArray Flags {get; set;}

       [SerializationOrder(1)]
       [CanSerialize("Flags", 0)]
       public OpenTl.Schema.IInputFile File {get; set;}

       [SerializationOrder(2)]
       [CanSerialize("Flags", 1)]
       public OpenTl.Schema.IInputFile Video {get; set;}

       [SerializationOrder(3)]
       [CanSerialize("Flags", 2)]
       public double VideoStartTs {get; set;}

	}
}
