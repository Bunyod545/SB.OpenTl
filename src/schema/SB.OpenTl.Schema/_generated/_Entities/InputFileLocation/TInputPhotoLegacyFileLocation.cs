// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0xd83466f3)]
	public sealed class TInputPhotoLegacyFileLocation : IInputFileLocation
	{
       [SerializationOrder(0)]
       public long Id {get; set;}

       [SerializationOrder(1)]
       public long AccessHash {get; set;}

       [SerializationOrder(2)]
       public byte[] FileReference {get; set;}

       [SerializationOrder(3)]
       public long VolumeId {get; set;}

       [SerializationOrder(4)]
       public int LocalId {get; set;}

       [SerializationOrder(5)]
       public long Secret {get; set;}

	}
}
