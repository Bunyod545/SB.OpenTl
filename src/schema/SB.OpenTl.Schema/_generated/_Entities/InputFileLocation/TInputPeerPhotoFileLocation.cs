// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x27d69997)]
	public sealed class TInputPeerPhotoFileLocation : IInputFileLocation
	{
       [SerializationOrder(0)]
       public BitArray Flags {get; set;}

       [SerializationOrder(1)]
       [FromFlag("Flags", 0)]
       public bool Big {get; set;}

       [SerializationOrder(2)]
       public OpenTl.Schema.IInputPeer Peer {get; set;}

       [SerializationOrder(3)]
       public long VolumeId {get; set;}

       [SerializationOrder(4)]
       public int LocalId {get; set;}

	}
}
