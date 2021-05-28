// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0xdbaeae9)]
	public sealed class TInputStickerSetThumb : IInputFileLocation
	{
       [SerializationOrder(0)]
       public OpenTl.Schema.IInputStickerSet Stickerset {get; set;}

       [SerializationOrder(1)]
       public long VolumeId {get; set;}

       [SerializationOrder(2)]
       public int LocalId {get; set;}

	}
}
