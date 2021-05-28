// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0xa437c3ed)]
	public sealed class TWallPaper : IWallPaper
	{
       [SerializationOrder(0)]
       public long Id {get; set;}

       [SerializationOrder(1)]
       public BitArray Flags {get; set;}

       [SerializationOrder(2)]
       [FromFlag("Flags", 0)]
       public bool Creator {get; set;}

       [SerializationOrder(3)]
       [FromFlag("Flags", 1)]
       public bool Default {get; set;}

       [SerializationOrder(4)]
       [FromFlag("Flags", 3)]
       public bool Pattern {get; set;}

       [SerializationOrder(5)]
       [FromFlag("Flags", 4)]
       public bool Dark {get; set;}

       [SerializationOrder(6)]
       public long AccessHash {get; set;}

       /// <summary>Binary representation for the 'Slug' property</summary>
       [SerializationOrder(7)]
       public byte[] SlugAsBinary { get => _SlugAsBinary; set { _Slug = Encoding.UTF8.GetString(value); _SlugAsBinary = value; }}
       private byte[] _SlugAsBinary;
       private string _Slug;
       public string Slug { get => _Slug; set { SlugAsBinary = Encoding.UTF8.GetBytes(value); _Slug = value; }}

       [SerializationOrder(8)]
       public OpenTl.Schema.IDocument Document {get; set;}

       [SerializationOrder(9)]
       [CanSerialize("Flags", 2)]
       public OpenTl.Schema.IWallPaperSettings Settings {get; set;}

	}
}
