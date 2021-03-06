// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0xbc7fc6cd)]
	public sealed class TFileLocationToBeDeprecated : IFileLocation
	{
       [SerializationOrder(0)]
       public long VolumeId {get; set;}

       [SerializationOrder(1)]
       public int LocalId {get; set;}

	}
}
