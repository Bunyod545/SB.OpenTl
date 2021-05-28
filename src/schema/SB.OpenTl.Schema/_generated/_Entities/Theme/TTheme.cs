// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x28f1114)]
	public sealed class TTheme : ITheme
	{
       [SerializationOrder(0)]
       public BitArray Flags {get; set;}

       [SerializationOrder(1)]
       [FromFlag("Flags", 0)]
       public bool Creator {get; set;}

       [SerializationOrder(2)]
       [FromFlag("Flags", 1)]
       public bool Default {get; set;}

       [SerializationOrder(3)]
       public long Id {get; set;}

       [SerializationOrder(4)]
       public long AccessHash {get; set;}

       /// <summary>Binary representation for the 'Slug' property</summary>
       [SerializationOrder(5)]
       public byte[] SlugAsBinary { get => _SlugAsBinary; set { _Slug = Encoding.UTF8.GetString(value); _SlugAsBinary = value; }}
       private byte[] _SlugAsBinary;
       private string _Slug;
       public string Slug { get => _Slug; set { SlugAsBinary = Encoding.UTF8.GetBytes(value); _Slug = value; }}

       /// <summary>Binary representation for the 'Title' property</summary>
       [SerializationOrder(6)]
       public byte[] TitleAsBinary { get => _TitleAsBinary; set { _Title = Encoding.UTF8.GetString(value); _TitleAsBinary = value; }}
       private byte[] _TitleAsBinary;
       private string _Title;
       public string Title { get => _Title; set { TitleAsBinary = Encoding.UTF8.GetBytes(value); _Title = value; }}

       [SerializationOrder(7)]
       [CanSerialize("Flags", 2)]
       public OpenTl.Schema.IDocument Document {get; set;}

       [SerializationOrder(8)]
       [CanSerialize("Flags", 3)]
       public OpenTl.Schema.IThemeSettings Settings {get; set;}

       [SerializationOrder(9)]
       public int InstallsCount {get; set;}

	}
}
