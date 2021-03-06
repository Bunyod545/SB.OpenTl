// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0xfb197a65)]
	public sealed class TPhoto : IPhoto
	{
       [SerializationOrder(0)]
       public BitArray Flags {get; set;}

       [SerializationOrder(1)]
       [FromFlag("Flags", 0)]
       public bool HasStickers {get; set;}

       [SerializationOrder(2)]
       public long Id {get; set;}

       [SerializationOrder(3)]
       public long AccessHash {get; set;}

       [SerializationOrder(4)]
       public byte[] FileReference {get; set;}

       [SerializationOrder(5)]
       public int Date {get; set;}

       [SerializationOrder(6)]
       public OpenTl.Schema.TVector<OpenTl.Schema.IPhotoSize> Sizes {get; set;}

       [SerializationOrder(7)]
       [CanSerialize("Flags", 1)]
       public OpenTl.Schema.TVector<OpenTl.Schema.IVideoSize> VideoSizes {get; set;}

       [SerializationOrder(8)]
       public int DcId {get; set;}

	}
}
