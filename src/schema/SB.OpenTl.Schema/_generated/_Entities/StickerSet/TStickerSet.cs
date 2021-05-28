// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0xeeb46f27)]
	public sealed class TStickerSet : IStickerSet
	{
       [SerializationOrder(0)]
       public BitArray Flags {get; set;}

       [SerializationOrder(1)]
       [FromFlag("Flags", 1)]
       public bool Archived {get; set;}

       [SerializationOrder(2)]
       [FromFlag("Flags", 2)]
       public bool Official {get; set;}

       [SerializationOrder(3)]
       [FromFlag("Flags", 3)]
       public bool Masks {get; set;}

       [SerializationOrder(4)]
       [FromFlag("Flags", 5)]
       public bool Animated {get; set;}

       [SerializationOrder(5)]
       [CanSerialize("Flags", 0)]
       public int InstalledDate {get; set;}

       [SerializationOrder(6)]
       public long Id {get; set;}

       [SerializationOrder(7)]
       public long AccessHash {get; set;}

       /// <summary>Binary representation for the 'Title' property</summary>
       [SerializationOrder(8)]
       public byte[] TitleAsBinary { get => _TitleAsBinary; set { _Title = Encoding.UTF8.GetString(value); _TitleAsBinary = value; }}
       private byte[] _TitleAsBinary;
       private string _Title;
       public string Title { get => _Title; set { TitleAsBinary = Encoding.UTF8.GetBytes(value); _Title = value; }}

       /// <summary>Binary representation for the 'ShortName' property</summary>
       [SerializationOrder(9)]
       public byte[] ShortNameAsBinary { get => _ShortNameAsBinary; set { _ShortName = Encoding.UTF8.GetString(value); _ShortNameAsBinary = value; }}
       private byte[] _ShortNameAsBinary;
       private string _ShortName;
       public string ShortName { get => _ShortName; set { ShortNameAsBinary = Encoding.UTF8.GetBytes(value); _ShortName = value; }}

       [SerializationOrder(10)]
       [CanSerialize("Flags", 4)]
       public OpenTl.Schema.IPhotoSize Thumb {get; set;}

       [SerializationOrder(11)]
       [CanSerialize("Flags", 4)]
       public int ThumbDcId {get; set;}

       [SerializationOrder(12)]
       public int Count {get; set;}

       [SerializationOrder(13)]
       public int Hash {get; set;}

	}
}
