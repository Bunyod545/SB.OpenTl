// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x72091c80)]
	public sealed class TInputWallPaperSlug : IInputWallPaper
	{
       /// <summary>Binary representation for the 'Slug' property</summary>
       [SerializationOrder(0)]
       public byte[] SlugAsBinary { get => _SlugAsBinary; set { _Slug = Encoding.UTF8.GetString(value); _SlugAsBinary = value; }}
       private byte[] _SlugAsBinary;
       private string _Slug;
       public string Slug { get => _Slug; set { SlugAsBinary = Encoding.UTF8.GetBytes(value); _Slug = value; }}

	}
}
